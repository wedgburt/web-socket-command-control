namespace WebSocketWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogMessages = new System.Windows.Forms.ListBox();
            this.WSServerWorker = new System.ComponentModel.BackgroundWorker();
            this.PortScanBox = new System.Windows.Forms.GroupBox();
            this.PortScanIPLabel = new System.Windows.Forms.Label();
            this.PortScanButton = new System.Windows.Forms.Button();
            this.PortScanIPTextBox = new System.Windows.Forms.TextBox();
            this.ConnectedBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JobsBox = new System.Windows.Forms.ListBox();
            this.PortScanBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogMessages
            // 
            this.LogMessages.FormattingEnabled = true;
            this.LogMessages.ItemHeight = 31;
            this.LogMessages.Items.AddRange(new object[] {
            "Starting bot server..."});
            this.LogMessages.Location = new System.Drawing.Point(23, 945);
            this.LogMessages.Name = "LogMessages";
            this.LogMessages.Size = new System.Drawing.Size(1480, 376);
            this.LogMessages.TabIndex = 0;
            this.LogMessages.SelectedIndexChanged += new System.EventHandler(this.LogMessages_SelectedIndexChanged);
            // 
            // PortScanBox
            // 
            this.PortScanBox.Controls.Add(this.PortScanIPLabel);
            this.PortScanBox.Controls.Add(this.PortScanButton);
            this.PortScanBox.Controls.Add(this.PortScanIPTextBox);
            this.PortScanBox.Location = new System.Drawing.Point(30, 38);
            this.PortScanBox.Name = "PortScanBox";
            this.PortScanBox.Size = new System.Drawing.Size(560, 299);
            this.PortScanBox.TabIndex = 1;
            this.PortScanBox.TabStop = false;
            this.PortScanBox.Text = "Port Scan";
            this.PortScanBox.Enter += new System.EventHandler(this.PortScanBox_Enter);
            // 
            // PortScanIPLabel
            // 
            this.PortScanIPLabel.AutoSize = true;
            this.PortScanIPLabel.Location = new System.Drawing.Point(27, 60);
            this.PortScanIPLabel.Name = "PortScanIPLabel";
            this.PortScanIPLabel.Size = new System.Drawing.Size(242, 32);
            this.PortScanIPLabel.TabIndex = 2;
            this.PortScanIPLabel.Text = "Enter IP  Address:";
            // 
            // PortScanButton
            // 
            this.PortScanButton.Location = new System.Drawing.Point(30, 177);
            this.PortScanButton.Name = "PortScanButton";
            this.PortScanButton.Size = new System.Drawing.Size(500, 88);
            this.PortScanButton.TabIndex = 1;
            this.PortScanButton.Text = "Start";
            this.PortScanButton.UseVisualStyleBackColor = true;
            this.PortScanButton.Click += new System.EventHandler(this.PortScan_Click);
            // 
            // PortScanIPTextBox
            // 
            this.PortScanIPTextBox.Location = new System.Drawing.Point(30, 106);
            this.PortScanIPTextBox.MaxLength = 15;
            this.PortScanIPTextBox.Name = "PortScanIPTextBox";
            this.PortScanIPTextBox.Size = new System.Drawing.Size(500, 38);
            this.PortScanIPTextBox.TabIndex = 0;
            this.PortScanIPTextBox.WordWrap = false;
            // 
            // ConnectedBox
            // 
            this.ConnectedBox.FormattingEnabled = true;
            this.ConnectedBox.ItemHeight = 31;
            this.ConnectedBox.Location = new System.Drawing.Point(1549, 70);
            this.ConnectedBox.Name = "ConnectedBox";
            this.ConnectedBox.Size = new System.Drawing.Size(672, 562);
            this.ConnectedBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1544, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connected Clients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 899);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log Messages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1545, 682);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Active Jobs:";
            // 
            // JobsBox
            // 
            this.JobsBox.FormattingEnabled = true;
            this.JobsBox.ItemHeight = 31;
            this.JobsBox.Location = new System.Drawing.Point(1549, 727);
            this.JobsBox.Name = "JobsBox";
            this.JobsBox.Size = new System.Drawing.Size(672, 593);
            this.JobsBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2244, 1344);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JobsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectedBox);
            this.Controls.Add(this.PortScanBox);
            this.Controls.Add(this.LogMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JavaScript Command & Control Server";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PortScanBox.ResumeLayout(false);
            this.PortScanBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox LogMessages;
        private System.ComponentModel.BackgroundWorker WSServerWorker;
        private System.Windows.Forms.GroupBox PortScanBox;
        private System.Windows.Forms.Label PortScanIPLabel;
        private System.Windows.Forms.Button PortScanButton;
        private System.Windows.Forms.TextBox PortScanIPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ConnectedBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox JobsBox;
    }
}

