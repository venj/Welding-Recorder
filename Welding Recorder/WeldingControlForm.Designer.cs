﻿namespace Welding_Recorder
{
    partial class WeldingControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenCloseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.OperatorNameComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ArGasFlowTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RoomTempTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GangTaoTypeComboBox = new System.Windows.Forms.ComboBox();
            this.WeldingCurrentTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WeldingItemComboBox = new System.Windows.Forms.ComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortStatusImageBox = new System.Windows.Forms.PictureBox();
            this.rateBox = new System.Windows.Forms.ComboBox();
            this.PortsBox = new System.Windows.Forms.ComboBox();
            this.base64CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stopBitsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataBitsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveRecordButton = new System.Windows.Forms.Button();
            this.CancelFormButton = new System.Windows.Forms.Button();
            this.PlotBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.dataOutputBox = new System.Windows.Forms.TextBox();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.RecordGroupBox = new System.Windows.Forms.GroupBox();
            this.StartWeldingButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortStatusImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCloseButton
            // 
            this.OpenCloseButton.Location = new System.Drawing.Point(17, 104);
            this.OpenCloseButton.Name = "OpenCloseButton";
            this.OpenCloseButton.Size = new System.Drawing.Size(73, 23);
            this.OpenCloseButton.TabIndex = 16;
            this.OpenCloseButton.Text = "打开";
            this.OpenCloseButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.OperatorNameComboBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ArGasFlowTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.RoomTempTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.GangTaoTypeComboBox);
            this.groupBox1.Controls.Add(this.WeldingCurrentTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.WeldingItemComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 113);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "焊接信息";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(199, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 47;
            this.label15.Text = "操作人员";
            // 
            // OperatorNameComboBox
            // 
            this.OperatorNameComboBox.FormattingEnabled = true;
            this.OperatorNameComboBox.Location = new System.Drawing.Point(258, 75);
            this.OperatorNameComboBox.Name = "OperatorNameComboBox";
            this.OperatorNameComboBox.Size = new System.Drawing.Size(108, 20);
            this.OperatorNameComboBox.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 46;
            this.label13.Text = "L/min";
            // 
            // ArGasFlowTextBox
            // 
            this.ArGasFlowTextBox.Location = new System.Drawing.Point(258, 46);
            this.ArGasFlowTextBox.Name = "ArGasFlowTextBox";
            this.ArGasFlowTextBox.Size = new System.Drawing.Size(74, 21);
            this.ArGasFlowTextBox.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(199, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "氩气流量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 43;
            this.label11.Text = "℃";
            // 
            // RoomTempTextBox
            // 
            this.RoomTempTextBox.Location = new System.Drawing.Point(71, 73);
            this.RoomTempTextBox.Name = "RoomTempTextBox";
            this.RoomTempTextBox.Size = new System.Drawing.Size(89, 21);
            this.RoomTempTextBox.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 41;
            this.label12.Text = "室内温度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "A";
            // 
            // GangTaoTypeComboBox
            // 
            this.GangTaoTypeComboBox.FormattingEnabled = true;
            this.GangTaoTypeComboBox.Location = new System.Drawing.Point(71, 20);
            this.GangTaoTypeComboBox.Name = "GangTaoTypeComboBox";
            this.GangTaoTypeComboBox.Size = new System.Drawing.Size(108, 20);
            this.GangTaoTypeComboBox.TabIndex = 35;
            // 
            // WeldingCurrentTextBox
            // 
            this.WeldingCurrentTextBox.Location = new System.Drawing.Point(71, 46);
            this.WeldingCurrentTextBox.Name = "WeldingCurrentTextBox";
            this.WeldingCurrentTextBox.Size = new System.Drawing.Size(89, 21);
            this.WeldingCurrentTextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "缸套规格";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "焊接电流";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "焊接项目";
            // 
            // WeldingItemComboBox
            // 
            this.WeldingItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeldingItemComboBox.FormattingEnabled = true;
            this.WeldingItemComboBox.Location = new System.Drawing.Point(258, 20);
            this.WeldingItemComboBox.Name = "WeldingItemComboBox";
            this.WeldingItemComboBox.Size = new System.Drawing.Size(108, 20);
            this.WeldingItemComboBox.TabIndex = 37;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 661);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(974, 22);
            this.statusBar.TabIndex = 56;
            this.statusBar.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PortStatusImageBox);
            this.groupBox2.Controls.Add(this.rateBox);
            this.groupBox2.Controls.Add(this.OpenCloseButton);
            this.groupBox2.Controls.Add(this.PortsBox);
            this.groupBox2.Controls.Add(this.base64CheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.stopBitsBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.parityBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataBitsBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 139);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口设置";
            // 
            // PortStatusImageBox
            // 
            this.PortStatusImageBox.Image = global::Welding_Recorder.Properties.Resources.Red_Ball;
            this.PortStatusImageBox.Location = new System.Drawing.Point(96, 103);
            this.PortStatusImageBox.Name = "PortStatusImageBox";
            this.PortStatusImageBox.Size = new System.Drawing.Size(24, 24);
            this.PortStatusImageBox.TabIndex = 33;
            this.PortStatusImageBox.TabStop = false;
            // 
            // rateBox
            // 
            this.rateBox.FormattingEnabled = true;
            this.rateBox.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.rateBox.Location = new System.Drawing.Point(246, 20);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(120, 20);
            this.rateBox.TabIndex = 20;
            // 
            // PortsBox
            // 
            this.PortsBox.FormattingEnabled = true;
            this.PortsBox.Location = new System.Drawing.Point(62, 20);
            this.PortsBox.Name = "PortsBox";
            this.PortsBox.Size = new System.Drawing.Size(117, 20);
            this.PortsBox.TabIndex = 17;
            // 
            // base64CheckBox
            // 
            this.base64CheckBox.AutoSize = true;
            this.base64CheckBox.Location = new System.Drawing.Point(201, 74);
            this.base64CheckBox.Name = "base64CheckBox";
            this.base64CheckBox.Size = new System.Drawing.Size(60, 16);
            this.base64CheckBox.TabIndex = 32;
            this.base64CheckBox.Text = "Base64";
            this.base64CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "串口";
            // 
            // stopBitsBox
            // 
            this.stopBitsBox.FormattingEnabled = true;
            this.stopBitsBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitsBox.Location = new System.Drawing.Point(246, 46);
            this.stopBitsBox.Name = "stopBitsBox";
            this.stopBitsBox.Size = new System.Drawing.Size(120, 20);
            this.stopBitsBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "波特率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "停止位";
            // 
            // parityBox
            // 
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.parityBox.Location = new System.Drawing.Point(62, 72);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(117, 20);
            this.parityBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "数据位";
            // 
            // dataBitsBox
            // 
            this.dataBitsBox.FormattingEnabled = true;
            this.dataBitsBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitsBox.Location = new System.Drawing.Point(62, 46);
            this.dataBitsBox.Name = "dataBitsBox";
            this.dataBitsBox.Size = new System.Drawing.Size(117, 20);
            this.dataBitsBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "校验位";
            // 
            // SaveRecordButton
            // 
            this.SaveRecordButton.Enabled = false;
            this.SaveRecordButton.Location = new System.Drawing.Point(887, 601);
            this.SaveRecordButton.Name = "SaveRecordButton";
            this.SaveRecordButton.Size = new System.Drawing.Size(75, 23);
            this.SaveRecordButton.TabIndex = 55;
            this.SaveRecordButton.Text = "保存记录";
            this.SaveRecordButton.UseVisualStyleBackColor = true;
            // 
            // CancelFormButton
            // 
            this.CancelFormButton.Location = new System.Drawing.Point(887, 630);
            this.CancelFormButton.Name = "CancelFormButton";
            this.CancelFormButton.Size = new System.Drawing.Size(75, 23);
            this.CancelFormButton.TabIndex = 54;
            this.CancelFormButton.Text = "取消";
            this.CancelFormButton.UseVisualStyleBackColor = true;
            // 
            // PlotBox
            // 
            this.PlotBox.Location = new System.Drawing.Point(418, 6);
            this.PlotBox.Name = "PlotBox";
            this.PlotBox.Size = new System.Drawing.Size(544, 459);
            this.PlotBox.TabIndex = 57;
            this.PlotBox.TabStop = false;
            this.PlotBox.Text = "监控图";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(597, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 12);
            this.label6.TabIndex = 51;
            this.label6.Text = "发送消息按钮仅用于单串口调试。-->";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(806, 630);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageButton.TabIndex = 50;
            this.sendMessageButton.Text = "发送消息";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // dataOutputBox
            // 
            this.dataOutputBox.Location = new System.Drawing.Point(418, 471);
            this.dataOutputBox.Multiline = true;
            this.dataOutputBox.Name = "dataOutputBox";
            this.dataOutputBox.ReadOnly = true;
            this.dataOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataOutputBox.Size = new System.Drawing.Size(463, 153);
            this.dataOutputBox.TabIndex = 49;
            this.dataOutputBox.Tag = "是";
            // 
            // clearDataButton
            // 
            this.clearDataButton.Location = new System.Drawing.Point(419, 630);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(75, 23);
            this.clearDataButton.TabIndex = 48;
            this.clearDataButton.Text = "清空数据";
            this.clearDataButton.UseVisualStyleBackColor = true;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(12, 630);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 47;
            this.clearLogButton.Text = "清空日志";
            this.clearLogButton.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 471);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(390, 153);
            this.logBox.TabIndex = 46;
            this.logBox.Tag = "是";
            // 
            // RecordGroupBox
            // 
            this.RecordGroupBox.Location = new System.Drawing.Point(12, 271);
            this.RecordGroupBox.Name = "RecordGroupBox";
            this.RecordGroupBox.Size = new System.Drawing.Size(390, 194);
            this.RecordGroupBox.TabIndex = 58;
            this.RecordGroupBox.TabStop = false;
            this.RecordGroupBox.Text = "焊接曲线";
            // 
            // StartWeldingButton
            // 
            this.StartWeldingButton.Location = new System.Drawing.Point(888, 572);
            this.StartWeldingButton.Name = "StartWeldingButton";
            this.StartWeldingButton.Size = new System.Drawing.Size(75, 23);
            this.StartWeldingButton.TabIndex = 59;
            this.StartWeldingButton.Text = "开始焊接";
            this.StartWeldingButton.UseVisualStyleBackColor = true;
            // 
            // WeldingControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 683);
            this.ControlBox = false;
            this.Controls.Add(this.StartWeldingButton);
            this.Controls.Add(this.RecordGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SaveRecordButton);
            this.Controls.Add(this.CancelFormButton);
            this.Controls.Add(this.PlotBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.dataOutputBox);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.logBox);
            this.Name = "WeldingControlForm";
            this.Text = "焊接控制";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortStatusImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenCloseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox OperatorNameComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ArGasFlowTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RoomTempTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GangTaoTypeComboBox;
        private System.Windows.Forms.TextBox WeldingCurrentTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox WeldingItemComboBox;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PortStatusImageBox;
        private System.Windows.Forms.ComboBox rateBox;
        private System.Windows.Forms.ComboBox PortsBox;
        private System.Windows.Forms.CheckBox base64CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stopBitsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox parityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dataBitsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveRecordButton;
        private System.Windows.Forms.Button CancelFormButton;
        private System.Windows.Forms.GroupBox PlotBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox dataOutputBox;
        private System.Windows.Forms.Button clearDataButton;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.GroupBox RecordGroupBox;
        private System.Windows.Forms.Button StartWeldingButton;
    }
}