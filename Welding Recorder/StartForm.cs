﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Welding_Recorder
{
    public partial class StartForm : Form
    {
        
        /***************************************************************************
                              Properties and Local Variables
        ****************************************************************************/
        
        private SerialPort currentSerialPort = null;
        private SerialDataReceivedEventHandler dataReceivedEventHandler;
        private List<byte> signalBuffer = new List<byte>(6);
        private DateTime timestamp = DateTime.Now;

        /***************************************************************************
                                    Form Initlaization
        ****************************************************************************/

        public StartForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        void InitializeUI()
        {
            string portName = Properties.Settings.Default.SerialPortName;

            string[] ports = SerialPort.GetPortNames();
            portsBox.Items.Clear();

            foreach (var port in ports)
            {
                portsBox.Items.Add(port);
            }

            if (portsBox.Items.IndexOf(portName) == -1)
            {
                portsBox.Text = "";
                Properties.Settings.Default.SerialPortName = "";
                try
                {
                    Properties.Settings.Default.Save();
                }
                catch (Exception excp)
                {
                    Console.WriteLine(excp.Message);
                }
            }
            else
            {
                portsBox.Text = portName;
                openPortWithName(portName);
            }
#if DEBUG
            // Simulate a start collect signal:
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += new EventHandler((s, evt) =>
            {
                timer.Stop();
                var signal = new Signal(SignalType.CollectStart);
                var data = signal.RawBytes;
                Console.WriteLine(string.Format("发送指令:{0}, raw: {1}", signal.ToString(), signal.ToHexString()));
                currentSerialPort.Write(data, 0, data.Length);
            });
            timer.Start();
#endif
        }
        
        /***************************************************************************
                                      Event Handlers
        ****************************************************************************/

        private void SerialPortSettingsMenuItem_Click(object sender, EventArgs e)
        {
            var serialPortSettingsForm = new SerialPortSettingsForm();
            var result = serialPortSettingsForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                portsBox.Text = Properties.Settings.Default.SerialPortName;
            }
        }

        private void DataCollectButton_Click(object sender, EventArgs e)
        {
            var serialPort = currentSerialPort;
            if (serialPort == null)
            {
                MessageBox.Show("请选择一个端口并打开。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new RecordForm(serialPort);
            form.ShowDialog(this);
        }

        private void AutoControlButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectTemplateButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenCloseButton_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var portName = portsBox.Text;
            if (currentSerialPort == null)
            {
                openPortWithName(portName);
            }
            else
            {
                closePortWithName(portName);
            }
        }
        
        /***************************************************************************
                               Serial port data processing
        ****************************************************************************/

        private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
#if (DEBUG)
            Console.WriteLine("Serial Port Data Receivered.");
#endif
            SerialPort port = (SerialPort)sender;

            int bytesInBuffer = port.BytesToRead;

            byte[] readBytes = new byte[bytesInBuffer];
            try
            {
                port.Read(readBytes, 0, bytesInBuffer);
            }
            catch (TimeoutException)
            {

                MessageBox.Show(this, "数据读取超时。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {

                MessageBox.Show(this, "非法操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show(this, "未知错误。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < bytesInBuffer; i++)
            {
                var b = readBytes[i];

                if (b == 0xFF)
                {
                    signalBuffer.Clear();
                    timestamp = DateTime.Now;
                }

                signalBuffer.Add(b);

                if (signalBuffer.Count == Signal.LENGTH) // Signal catch finished.
                {
#if (DEBUG)
                    Console.Write("Signal content: ");
                    for (int j = 0; j < signalBuffer.Count; j++)
                    {
                        Console.Write("{0}", signalBuffer[j]);
                    }
                    Console.WriteLine();
#endif
                    Signal signal = new Signal(signalBuffer.ToArray(), timestamp);
                    SignalProcess(signal);
                }
            }
        }

        void SignalProcess(Signal signal)
        {
            if (signal.Type == SignalType.CollectStart)
            {
                this.UIThread(() => {
                    DataCollectButton.PerformClick();
                });
            }
            else
            {
                Console.WriteLine("SerialPort signal received in StartForm: {0}", signal.ToString());
            }
        }

        /***************************************************************************
                               Serial port helper methods start
        ****************************************************************************/

        private void openPortWithName(string portName)
        {
            if (String.IsNullOrEmpty(portName))
            {
                MessageBox.Show(this, "请选择一个串口或输入串口名称。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!isPortNameValid(portName.ToUpper()))
            {
                MessageBox.Show(this, "串口名不合法或串口不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SerialPort p = new SerialPort(portName);
            p.BaudRate = Convert.ToInt32(Properties.Settings.Default.Baudrate);
            p.Parity = translateStringToParity(Properties.Settings.Default.Parity);
            p.DataBits = Convert.ToInt32(Properties.Settings.Default.DataBits);
            p.StopBits = translateStringToStopBits(Properties.Settings.Default.StopBit);
            p.DataReceived += new SerialDataReceivedEventHandler(serialPortDataReceived);
            p.ErrorReceived += new SerialErrorReceivedEventHandler((sender, e) => {
                var evt = e;
                Console.WriteLine(e.EventType);
            });
            currentSerialPort = p;

            try
            {
                p.Open();
                portsBox.Enabled = false;
                PortStatusImageBox.Image = Properties.Resources.Green_Ball;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(this, "端口被占用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //throw;
            }
            Console.Write(portName + "已打开。\r\n");
            OpenCloseButton.Text = "关闭";
        }

        private void closePortWithName(string portName)
        {
            SerialPort p = currentSerialPort;
            if (p != null)
            {
                p.Close();
                if (!p.IsOpen)
                {
                    Console.Write(portName + "已关闭。\r\n");
                    OpenCloseButton.Text = "打开";
                    // Re-enable PortsBox after port closed.
                    portsBox.Enabled = true;
                    PortStatusImageBox.Image = Properties.Resources.Red_Ball;
                    currentSerialPort = null;
                }
                else
                {
                    Console.Write("端口" + portName + "关闭失败。\r\n");
                }
            }
        }

        private void loadPortList()
        {
            // 初始化端口列表
            string[] ports = SerialPort.GetPortNames();
            portsBox.Items.Clear();
            foreach (var port in ports)
            {
                portsBox.Items.Add(port);
            }
            if (portsBox.Items.Count > 0)
            {
                portsBox.SelectedIndex = 0;
            }
        }
        
        private Parity translateStringToParity(string str)
        {
            Parity p = Parity.None;
            switch (str)
            {
                case "Even":
                    p = Parity.Even;
                    break;
                case "Mark":
                    p = Parity.Mark;
                    break;
                case "Space":
                    p = Parity.Space;
                    break;
                case "Odd":
                    p = Parity.Odd;
                    break;
                case "None":
                default:
                    p = Parity.None;
                    break;
            }
            return p;
        }

        private StopBits translateStringToStopBits(string str)
        {
            StopBits p = StopBits.One;
            switch (str)
            {
                case "2":
                    p = StopBits.Two;
                    break;
                case "1":
                default:
                    p = StopBits.One;
                    break;
            }
            return p;
        }

        private bool isPortNameValid(string portName)
        {
            bool result = false;
            var names = SerialPort.GetPortNames();
            foreach (var name in names)
            {
                if (name == portName)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

    }
}