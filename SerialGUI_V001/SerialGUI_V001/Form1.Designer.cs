namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortNameComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectPortbutton = new System.Windows.Forms.Button();
            this.BaudRatecomboBox = new System.Windows.Forms.ComboBox();
            this.DisconnectPortbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxButton = new System.Windows.Forms.Button();
            this.terminalBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txBox = new System.Windows.Forms.TextBox();
            this.sendLF = new System.Windows.Forms.CheckBox();
            this.sendCR = new System.Windows.Forms.CheckBox();
            this.clrButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PortNameComboBox);
            this.groupBox3.Controls.Add(this.ConnectPortbutton);
            this.groupBox3.Controls.Add(this.BaudRatecomboBox);
            this.groupBox3.Controls.Add(this.DisconnectPortbutton);
            this.groupBox3.Location = new System.Drawing.Point(486, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 223);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port Name";
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNameComboBox.FormattingEnabled = true;
            this.PortNameComboBox.Location = new System.Drawing.Point(6, 44);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.Size = new System.Drawing.Size(88, 21);
            this.PortNameComboBox.TabIndex = 4;
            // 
            // ConnectPortbutton
            // 
            this.ConnectPortbutton.Location = new System.Drawing.Point(6, 127);
            this.ConnectPortbutton.Name = "ConnectPortbutton";
            this.ConnectPortbutton.Size = new System.Drawing.Size(88, 42);
            this.ConnectPortbutton.TabIndex = 0;
            this.ConnectPortbutton.Text = "Connect";
            this.ConnectPortbutton.UseVisualStyleBackColor = true;
            this.ConnectPortbutton.Click += new System.EventHandler(this.ConnectPortbutton_Click);
            // 
            // BaudRatecomboBox
            // 
            this.BaudRatecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRatecomboBox.FormattingEnabled = true;
            this.BaudRatecomboBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRatecomboBox.Location = new System.Drawing.Point(6, 89);
            this.BaudRatecomboBox.Name = "BaudRatecomboBox";
            this.BaudRatecomboBox.Size = new System.Drawing.Size(88, 21);
            this.BaudRatecomboBox.TabIndex = 5;
            // 
            // DisconnectPortbutton
            // 
            this.DisconnectPortbutton.Enabled = false;
            this.DisconnectPortbutton.Location = new System.Drawing.Point(7, 175);
            this.DisconnectPortbutton.Name = "DisconnectPortbutton";
            this.DisconnectPortbutton.Size = new System.Drawing.Size(87, 42);
            this.DisconnectPortbutton.TabIndex = 1;
            this.DisconnectPortbutton.Text = "Disconnect";
            this.DisconnectPortbutton.UseVisualStyleBackColor = true;
            this.DisconnectPortbutton.Click += new System.EventHandler(this.DisconnectPortbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.terminalBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 223);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminal";
            // 
            // TxButton
            // 
            this.TxButton.Enabled = false;
            this.TxButton.Location = new System.Drawing.Point(493, 281);
            this.TxButton.Name = "TxButton";
            this.TxButton.Size = new System.Drawing.Size(87, 23);
            this.TxButton.TabIndex = 3;
            this.TxButton.Text = "Send Data";
            this.TxButton.UseVisualStyleBackColor = true;
            // 
            // terminalBox
            // 
            this.terminalBox.Location = new System.Drawing.Point(6, 19);
            this.terminalBox.Multiline = true;
            this.terminalBox.Name = "terminalBox";
            this.terminalBox.ReadOnly = true;
            this.terminalBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.terminalBox.Size = new System.Drawing.Size(456, 189);
            this.terminalBox.TabIndex = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.RxFlag);
            // 
            // txBox
            // 
            this.txBox.Enabled = false;
            this.txBox.Location = new System.Drawing.Point(18, 254);
            this.txBox.Multiline = true;
            this.txBox.Name = "txBox";
            this.txBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txBox.Size = new System.Drawing.Size(456, 79);
            this.txBox.TabIndex = 15;
            this.txBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBox_KeyPress);
            // 
            // sendLF
            // 
            this.sendLF.AutoSize = true;
            this.sendLF.Location = new System.Drawing.Point(542, 258);
            this.sendLF.Name = "sendLF";
            this.sendLF.Size = new System.Drawing.Size(38, 17);
            this.sendLF.TabIndex = 16;
            this.sendLF.Text = "LF";
            this.sendLF.UseVisualStyleBackColor = true;
            // 
            // sendCR
            // 
            this.sendCR.AutoSize = true;
            this.sendCR.Location = new System.Drawing.Point(495, 258);
            this.sendCR.Name = "sendCR";
            this.sendCR.Size = new System.Drawing.Size(41, 17);
            this.sendCR.TabIndex = 17;
            this.sendCR.Text = "CR";
            this.sendCR.UseVisualStyleBackColor = true;
            // 
            // clrButton
            // 
            this.clrButton.Enabled = false;
            this.clrButton.Location = new System.Drawing.Point(493, 310);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(87, 23);
            this.clrButton.TabIndex = 18;
            this.clrButton.Text = "Clear";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 347);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.sendCR);
            this.Controls.Add(this.sendLF);
            this.Controls.Add(this.txBox);
            this.Controls.Add(this.TxButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serieal Port";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortNameComboBox;
        private System.Windows.Forms.Button ConnectPortbutton;
        private System.Windows.Forms.ComboBox BaudRatecomboBox;
        private System.Windows.Forms.Button DisconnectPortbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TxButton;
        private System.Windows.Forms.TextBox terminalBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txBox;
        private System.Windows.Forms.CheckBox sendLF;
        private System.Windows.Forms.CheckBox sendCR;
        private System.Windows.Forms.Button clrButton;
    }
}

