﻿namespace Welding_Recorder
{
    partial class MainForm
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
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewDataRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.缸套规格管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作人员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteHistoryButton = new System.Windows.Forms.Button();
            this.historiesList = new System.Windows.Forms.ListBox();
            this.historiesLabel = new System.Windows.Forms.Label();
            this.historyDetailTextBox = new System.Windows.Forms.TextBox();
            this.newRecordButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.EditHistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditHistoryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewDataRecordToolStripMenuItem});
            this.文件ToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.文件ToolStripMenuItem.Text = "操作";
            // 
            // startNewDataRecordToolStripMenuItem
            // 
            this.startNewDataRecordToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startNewDataRecordToolStripMenuItem.Name = "startNewDataRecordToolStripMenuItem";
            this.startNewDataRecordToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.startNewDataRecordToolStripMenuItem.Text = "开始数据采集...";
            this.startNewDataRecordToolStripMenuItem.Click += new System.EventHandler(this.startNewDataRecordToolStripMenuItem_Click);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.缸套规格管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.操作人员管理ToolStripMenuItem});
            this.preferenceToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.preferenceToolStripMenuItem.Text = "设置";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "程序设置";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // 缸套规格管理ToolStripMenuItem
            // 
            this.缸套规格管理ToolStripMenuItem.Name = "缸套规格管理ToolStripMenuItem";
            this.缸套规格管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.缸套规格管理ToolStripMenuItem.Text = "缸套规格管理";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.用户管理ToolStripMenuItem.Text = "焊接项目管理";
            // 
            // 操作人员管理ToolStripMenuItem
            // 
            this.操作人员管理ToolStripMenuItem.Name = "操作人员管理ToolStripMenuItem";
            this.操作人员管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.操作人员管理ToolStripMenuItem.Text = "操作人员管理";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.editToolStripMenuItem,
            this.preferenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditHistoryMenu});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "编辑";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteHistoryButton);
            this.splitContainer1.Panel1.Controls.Add(this.historiesList);
            this.splitContainer1.Panel1.Controls.Add(this.historiesLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.EditHistoryButton);
            this.splitContainer1.Panel2.Controls.Add(this.historyDetailTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.newRecordButton);
            this.splitContainer1.Size = new System.Drawing.Size(638, 356);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 1;
            // 
            // deleteHistoryButton
            // 
            this.deleteHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteHistoryButton.Location = new System.Drawing.Point(3, 330);
            this.deleteHistoryButton.Name = "deleteHistoryButton";
            this.deleteHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteHistoryButton.TabIndex = 2;
            this.deleteHistoryButton.Text = "删除";
            this.deleteHistoryButton.UseVisualStyleBackColor = true;
            // 
            // historiesList
            // 
            this.historiesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historiesList.FormattingEnabled = true;
            this.historiesList.ItemHeight = 12;
            this.historiesList.Location = new System.Drawing.Point(4, 20);
            this.historiesList.Name = "historiesList";
            this.historiesList.Size = new System.Drawing.Size(158, 304);
            this.historiesList.TabIndex = 1;
            this.historiesList.SelectedIndexChanged += new System.EventHandler(this.historiesList_SelectedIndexChanged);
            this.historiesList.DoubleClick += new System.EventHandler(this.historiesList_DoubleClick);
            // 
            // historiesLabel
            // 
            this.historiesLabel.AutoSize = true;
            this.historiesLabel.Location = new System.Drawing.Point(4, 4);
            this.historiesLabel.Name = "historiesLabel";
            this.historiesLabel.Size = new System.Drawing.Size(77, 12);
            this.historiesLabel.TabIndex = 0;
            this.historiesLabel.Text = "焊接数据记录";
            // 
            // historyDetailTextBox
            // 
            this.historyDetailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyDetailTextBox.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.historyDetailTextBox.Location = new System.Drawing.Point(4, 4);
            this.historyDetailTextBox.Multiline = true;
            this.historyDetailTextBox.Name = "historyDetailTextBox";
            this.historyDetailTextBox.ReadOnly = true;
            this.historyDetailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyDetailTextBox.Size = new System.Drawing.Size(462, 320);
            this.historyDetailTextBox.TabIndex = 3;
            // 
            // newRecordButton
            // 
            this.newRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newRecordButton.Location = new System.Drawing.Point(369, 330);
            this.newRecordButton.Name = "newRecordButton";
            this.newRecordButton.Size = new System.Drawing.Size(97, 23);
            this.newRecordButton.TabIndex = 2;
            this.newRecordButton.Text = "启动自动焊接";
            this.newRecordButton.UseVisualStyleBackColor = true;
            this.newRecordButton.Click += new System.EventHandler(this.newRecordButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 369);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // EditHistoryMenu
            // 
            this.EditHistoryMenu.Name = "EditHistoryMenu";
            this.EditHistoryMenu.Size = new System.Drawing.Size(152, 22);
            this.EditHistoryMenu.Text = "编辑焊接程序";
            this.EditHistoryMenu.Click += new System.EventHandler(this.EditHistoryMenu_Click);
            // 
            // EditHistoryButton
            // 
            this.EditHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditHistoryButton.Location = new System.Drawing.Point(277, 330);
            this.EditHistoryButton.Name = "EditHistoryButton";
            this.EditHistoryButton.Size = new System.Drawing.Size(86, 23);
            this.EditHistoryButton.TabIndex = 4;
            this.EditHistoryButton.Text = "编辑焊接信号";
            this.EditHistoryButton.UseVisualStyleBackColor = true;
            this.EditHistoryButton.Click += new System.EventHandler(this.EditHistoryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 393);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "焊接控制台";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startNewDataRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button newRecordButton;
        private System.Windows.Forms.ListBox historiesList;
        private System.Windows.Forms.Label historiesLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 缸套规格管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作人员管理ToolStripMenuItem;
        private System.Windows.Forms.Button deleteHistoryButton;
        private System.Windows.Forms.TextBox historyDetailTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem EditHistoryMenu;
        private System.Windows.Forms.Button EditHistoryButton;
    }
}
