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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BaudRatecomboBox = new System.Windows.Forms.ComboBox();
            this.DisconnectPortbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxButton = new System.Windows.Forms.Button();
            this.TxTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RxTextBox = new System.Windows.Forms.TextBox();
            this.RxButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.PortNameComboBox);
            this.groupBox3.Controls.Add(this.ConnectPortbutton);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.BaudRatecomboBox);
            this.groupBox3.Controls.Add(this.DisconnectPortbutton);
            this.groupBox3.Location = new System.Drawing.Point(486, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 208);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port Name";
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNameComboBox.FormattingEnabled = true;
            this.PortNameComboBox.Location = new System.Drawing.Point(6, 42);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.Size = new System.Drawing.Size(88, 21);
            this.PortNameComboBox.TabIndex = 4;
            // 
            // ConnectPortbutton
            // 
            this.ConnectPortbutton.Location = new System.Drawing.Point(6, 109);
            this.ConnectPortbutton.Name = "ConnectPortbutton";
            this.ConnectPortbutton.Size = new System.Drawing.Size(88, 33);
            this.ConnectPortbutton.TabIndex = 0;
            this.ConnectPortbutton.Text = "Connect";
            this.ConnectPortbutton.UseVisualStyleBackColor = true;
            this.ConnectPortbutton.Click += new System.EventHandler(this.ConnectPortbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 148);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(88, 14);
            this.progressBar1.TabIndex = 4;
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
            this.BaudRatecomboBox.Location = new System.Drawing.Point(6, 82);
            this.BaudRatecomboBox.Name = "BaudRatecomboBox";
            this.BaudRatecomboBox.Size = new System.Drawing.Size(88, 21);
            this.BaudRatecomboBox.TabIndex = 5;
            // 
            // DisconnectPortbutton
            // 
            this.DisconnectPortbutton.Enabled = false;
            this.DisconnectPortbutton.Location = new System.Drawing.Point(7, 168);
            this.DisconnectPortbutton.Name = "DisconnectPortbutton";
            this.DisconnectPortbutton.Size = new System.Drawing.Size(87, 33);
            this.DisconnectPortbutton.TabIndex = 1;
            this.DisconnectPortbutton.Text = "Disconnect";
            this.DisconnectPortbutton.UseVisualStyleBackColor = true;
            this.DisconnectPortbutton.Click += new System.EventHandler(this.DisconnectPortbutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxButton);
            this.groupBox2.Controls.Add(this.TxTextBox);
            this.groupBox2.Location = new System.Drawing.Point(249, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 208);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data To Send";
            // 
            // TxButton
            // 
            this.TxButton.Enabled = false;
            this.TxButton.Location = new System.Drawing.Point(6, 179);
            this.TxButton.Name = "TxButton";
            this.TxButton.Size = new System.Drawing.Size(87, 23);
            this.TxButton.TabIndex = 3;
            this.TxButton.Text = "Send Data";
            this.TxButton.UseVisualStyleBackColor = true;
            // 
            // TxTextBox
            // 
            this.TxTextBox.Enabled = false;
            this.TxTextBox.Location = new System.Drawing.Point(6, 19);
            this.TxTextBox.Multiline = true;
            this.TxTextBox.Name = "TxTextBox";
            this.TxTextBox.Size = new System.Drawing.Size(219, 154);
            this.TxTextBox.TabIndex = 10;
            this.TxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RxTextBox);
            this.groupBox1.Controls.Add(this.RxButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data To read";
            // 
            // RxTextBox
            // 
            this.RxTextBox.Enabled = false;
            this.RxTextBox.Location = new System.Drawing.Point(6, 19);
            this.RxTextBox.Multiline = true;
            this.RxTextBox.Name = "RxTextBox";
            this.RxTextBox.ReadOnly = true;
            this.RxTextBox.Size = new System.Drawing.Size(219, 154);
            this.RxTextBox.TabIndex = 9;
            // 
            // RxButton
            // 
            this.RxButton.Enabled = false;
            this.RxButton.Location = new System.Drawing.Point(6, 179);
            this.RxButton.Name = "RxButton";
            this.RxButton.Size = new System.Drawing.Size(87, 23);
            this.RxButton.TabIndex = 3;
            this.RxButton.Text = "Read Data";
            this.RxButton.UseVisualStyleBackColor = true;
            this.RxButton.Click += new System.EventHandler(this.RxButton_Click_1);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.RxFlag);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 236);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serieal Port";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortNameComboBox;
        private System.Windows.Forms.Button ConnectPortbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox BaudRatecomboBox;
        private System.Windows.Forms.Button DisconnectPortbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TxButton;
        private System.Windows.Forms.TextBox TxTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RxTextBox;
        private System.Windows.Forms.Button RxButton;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

