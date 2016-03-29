﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;

namespace Welding_Recorder
{
    public partial class RecordForm : Form
    {
        private List<SerialPort> portsList = new List<SerialPort>();
        private List<byte> signalBuffer = new List<byte>(6);
        private DateTime timestamp = DateTime.Now;
        private bool isRecording = false;
        private List<Signal> signalCache = new List<Signal>(); // Signal cache to save recording process.
        private int currentSpeed = 0;
        private double currentTime = 0.0;

        private PlotView Plot = new PlotView();
        private LinearAxis axis1 = new LinearAxis();
        //private LineSeries s1 = new LineSeries { Title = "Speed", StrokeThickness = 1 };
        private ScatterSeries s1 = new ScatterSeries { MarkerType = MarkerType.Circle };

        public RecordForm()
        {
            InitializeComponent();

            PortsBox.SelectedIndexChanged += new EventHandler(portsBox_SelectedIndexChanged);
            PortsBox.DropDown += new EventHandler(portsBox_DropDown);

            // 波特率默认选择9600。 // BaudRate
            rateBox.SelectedIndex = 6;
            // 校验位默认选择None。 // Parity
            parityBox.SelectedIndex = 2;
            // 数据位默认选8。      // DataBit
            dataBitsBox.SelectedIndex = 3;
            // 停止位              // StopBits
            stopBitsBox.SelectedIndex = 0;
        }

        /***************************************************************************
                               Form life cycle
        ****************************************************************************/

        private void RecordForm_Load(object sender, EventArgs e)
        {
            InitialRecordingUI();
            InitializePlot();
        }

        private void RecordForm_Closing(object sender, EventArgs e)
        {
            string portName = PortsBox.Text.ToUpper();
            SerialPort port = getPortWithPortName(portName);
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        /***************************************************************************
                               Serial port event handlers start
        ****************************************************************************/

        private void openCloseButton_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                MessageBox.Show("You can not close port while recording data.");
            }
            else
            {
                string portName = PortsBox.Text.ToUpper();
                SerialPort port = getPortWithPortName(portName);
                if (port != null && port.IsOpen)
                {
                    closePortWithName(portName);
                }
                else
                {
                    openPortWithName(portName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logBox.Text = "";
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            dataOutputBox.Text = "";
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            SerialPort p = getPortWithPortName(PortsBox.Text.ToUpper());
            if (p == null)
            {
                logBox.Text += "端口未打开。\r\n";
                return;
            }
            else
            {
                sendMessage(p, p, 1024);
            }
        }

        private void portsBox_DropDown(object sender, EventArgs e)
        {
            loadPortList();
        }

        private void portsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox pb = (ComboBox)sender;
            string selectedPortName = ((string)pb.SelectedItem).ToUpper();
            SerialPort port = getPortWithPortName(selectedPortName);
            if (port != null && port.IsOpen)
            {
                OpenCloseButton.Text = "关闭";
            }
            else
            {
                OpenCloseButton.Text = "打开";
            }
        }

        private void serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
#if (DEBUG)
            Console.WriteLine("Serial Port Data Receivered.");
#endif
            SerialPort port = (SerialPort)sender;
            bool isBase64 = base64CheckBox.Checked;

            int bytesInBuffer = port.BytesToRead;

            byte[] readBytes = new byte[bytesInBuffer];
            try
            {
                port.Read(readBytes, 0, bytesInBuffer);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("数据读取超时。");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("非法操作。");
                throw;
            }
            catch (Exception)
            {
                MessageBox.Show("未知错误。");
            }

            for (int i = 0; i < bytesInBuffer; i++)
            {
                var b = readBytes[i];

                if ((signalBuffer.Count == 6 || signalBuffer.Count == 0) && b == 0xFF) // Signal start
                {
                    timestamp = DateTime.Now; // Save TimeStamp for signal start.
                    signalBuffer.Clear();
                    signalBuffer.Add(b);
                }
                else if (signalBuffer.Count() < 6) // Signal continue 
                {
                    signalBuffer.Add(b);
                }
                else
                {
                    // Do nothing.
                }

                if (signalBuffer.Count == 6) // Signal catch finished.
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

        /***************************************************************************
                               Serial port helper methods start
        ****************************************************************************/

        private void loadPortList()
        {
            // 初始化端口列表
            string[] ports = SerialPort.GetPortNames();
            PortsBox.Items.Clear();
            foreach (var port in ports)
            {
                PortsBox.Items.Add(port);
            }
            if (PortsBox.Items.Count > 0)
            {
                PortsBox.SelectedIndex = 0;
            }
        }

        private void openPortWithName(string portName)
        {
            if (String.IsNullOrEmpty(portName))
            {
                MessageBox.Show("请选择一个串口或输入串口名称。");
                return;
            }
            else if (!isPortNameValid(portName.ToUpper()))
            {
                MessageBox.Show("串口名不合法或串口不存在。");
                return;
            }
            SerialPort p = getPortWithPortName(portName);
            if (p != null)
            {
                return;
            }
            else
            {
                p = new SerialPort(portName);
                p.BaudRate = Convert.ToInt32(rateBox.Text);
                p.Parity = translateStringToParity(parityBox.Text);
                p.DataBits = Convert.ToInt32(dataBitsBox.Text);
                p.StopBits = translateStringToStopBits(stopBitsBox.Text);
                p.DataReceived += new SerialDataReceivedEventHandler(serialPortDataReceived);
                try
                {
                    p.Open();
                    // Disable PortsBox after port opened.
                    PortsBox.Enabled = false;
                    PortStatusImageBox.Image = Properties.Resources.Green_Ball;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("端口被占用。");
                    return;
                    //throw;
                }
                portsList.Add(p);
                logBox.Text += portName + "已打开。" + "共打开了" + portsList.Count + "个串口。\r\n";
                OpenCloseButton.Text = "关闭";
            }
        }

        private void closePortWithName(string portName)
        {
            SerialPort p = getPortWithPortName(portName);
            if (p != null)
            {
                p.Close();
                if (!p.IsOpen)
                {
                    portsList.Remove(p);
                    logBox.Text += portName + "已关闭。" + "共打开了" + portsList.Count + "个串口。\r\n";
                    OpenCloseButton.Text = "打开";
                    dataOutputBox.Text = ""; //清空数据框。
                    // Re-enable PortsBox after port closed.
                    PortsBox.Enabled = true;
                    PortStatusImageBox.Image = Properties.Resources.Red_Ball;
                }
                else
                {
                    logBox.Text += "端口" + portName + "关闭失败。\r\n";
                }
            }
        }

        private SerialPort getPortWithPortName(string portname)
        {
            foreach (var p in portsList)
            {
                if (p.PortName == portname)
                {
                    return p;
                }
            }

            return null;
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

        private void sendMessage(SerialPort from, SerialPort to, object obj)
        {
            byte[] dataBytes = { 0xFF, 0x01, 0x00, 0x08, 0x00, 0x09 };
            from.Write(dataBytes, 0, dataBytes.Count());
        }

        /***************************************************************************
                               General helper methods start
        ****************************************************************************/

        // Form initialization
        private void InitialRecordingUI()
        {
            loadPortList();
            loadWeldingDataLists();
        }

        // Load static data from database to UI.
        private void loadWeldingDataLists()
        {
            var db = new DataProcess();
            var gangtaoList = db.GangTaoList();
            gangtaoList.ForEach((item) => {
                GangTaoTypeComboBox.Items.Add(item);
            });
            var operatorList = db.OperatorList();
            operatorList.ForEach((item) => {
                OperatorNameComboBox.Items.Add(item);
            });
            var weldingItemList = db.WeldingItemList();
            weldingItemList.ForEach((item) => {
                WeldingItemComboBox.Items.Add(item);
            });

            if (WeldingItemComboBox.Items.Count > 0)
            {
                WeldingItemComboBox.SelectedIndex = 0;
            }
        }
        
        private void InitializePlot()
        {
            Plot.Model = new PlotModel();
            Plot.Dock = DockStyle.Fill;
            this.PlotBox.Controls.Add(Plot);
            //this.Controls.Add(Plot);

            Plot.Model.PlotType = PlotType.XY;
            Plot.Model.Background = OxyColor.FromRgb(255, 255, 255);
            Plot.Model.TextColor = OxyColor.FromRgb(0, 0, 0);

            axis1.Position = AxisPosition.Bottom;
            axis1.Minimum = -1.0;
            axis1.Maximum = 10.0;
            Plot.Model.Axes.Add(axis1);

            var axis2 = new LinearAxis();
            axis2.Position = AxisPosition.Left;
            axis2.Minimum = -15.0;
            axis2.Maximum = 15.0;
            Plot.Model.Axes.Add(axis2);
            
            // add Series and Axis to plot model
            Plot.Model.Series.Add(s1);
        }

        // Validate text input
        private void UpdateControlColor(Control sender, bool isFloat = false)
        {
            string text = sender.Text;
            text = text.Trim();
            sender.Text = text;

            var property = sender.GetType().GetProperty("SelectionStart");
            property?.SetValue(sender, sender.Text.Length + 1, null);

            if (isValidNumberInput(text, isFloat))
            {
                sender.BackColor = Color.White;
            }
            else
            {
                sender.BackColor = Color.Red;
            }
        }

        private bool isValidNumberInput(string text, bool isFloatNumber = false)
        {
            string pattern;
            if (isFloatNumber)
            {
                pattern = "^(\\s?\\s?\\d+(\\.\\d{0,3}){0,1}\\s?)?$"; // Negtive number is excluded.
            }
            else
            {
                pattern = "^(\\s?-?\\s?\\d+\\s?)?$";
            }
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        private void SignalProcess(Signal signal)
        {
            //TODO: Do more with signals.
            string message = "";

            if (signal.isValid())
            {
                signalCache.Add(signal);
                if (signal.Step != int.MaxValue)
                {
                    message = signal.Type.ToString() + " step " + signal.Step + " detected.\r\n";
                }
                else
                {
                    message = signal.Type.ToString() + " detected.\r\n";
                }
                if (signal.Type == SignalType.SolderStart)
                {
                    isRecording = true;
                }
                if (signal.Type == SignalType.SolderEnd)
                {
                    isRecording = false;
                    SaveRecordButton.Enabled = true; // enable save record button
                }
            }
            else
            {
                message = "Invalid signal: " + signal.Type.ToString() + " step " + signal.Step + " detected.\r\n";
            }

            this.UIThread(() => {
                this.dataOutputBox.Text += message;

                Plot.Model.InvalidatePlot(true);
                var signals = signalCache;
                var signalCount = signals.Count;
                var r = new Random(signalCount);

                if (signalCount == 1) // First point
                {
                    s1.Points.Add(new ScatterPoint(currentTime, 0, r.Next(1, 5), 0xFFAABB));
                }
                if (signalCount > 1)
                {
                    var previousSignal = signals[signalCount - 2];
                    var currentSignal = signals[signalCount - 1];

                    TimeSpan span = currentSignal.Timestamp - previousSignal.Timestamp;
                    currentTime += span.TotalSeconds;
                    s1.Points.Add(new ScatterPoint(currentTime, currentSpeed++, r.Next(1, 5), 0xFFBBAA));
                    axis1.Maximum = currentTime + 10;
                }
                // Create Line series
                
            });
        }

        /***************************************************************************
                              General Event handlers start
        ****************************************************************************/

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            { // Not recording...
                string[] ports = SerialPort.GetPortNames();
                foreach (var port in ports)
                {
                    try
                    {
                        var p = new SerialPort(port);
                        if (p.IsOpen)
                        {
                            p.Close();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Failed to close serial port {0}", port);
                    }
                }
                DialogResult = DialogResult.Cancel;
                Close(); // Close form.
            }
            else // Prevent form close while recording.
            {
                MessageBox.Show("You can not close this window while recording data.");
            }
        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {
            // Prompt user to ender a name for the record,
            // Read metadata from UI, 
            // and do database saving...

            // If all OK, close.
            DialogResult = DialogResult.OK;
            Close();
            // If database save failed, save data to text file, 
            // which user can import to database after this error.
        }

        private void GangTaoTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControlColor((ComboBox)sender);
        }

        private void WeldingCurrentTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControlColor((TextBox)sender, true);
        }

        private void ArGasFlowTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControlColor((TextBox)sender, true);
        }

        private void RoomTempTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControlColor((TextBox)sender, true);
        }
    }

    public static class ControlExtensions
    {
        public static void UIThread(this Control @this, Action code)
        {
            if (@this.InvokeRequired)
            {
                @this.BeginInvoke(code);
            }
            else
            {
                code.Invoke();
            }
        }
    }
}
