using System;

using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.ReceivedBytesThreshold = 1;
            GetAvilablePorts();
        }

        private static string rxString = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void GetAvilablePorts()
        {
            String[] Ports = SerialPort.GetPortNames();
            PortNameComboBox.Items.AddRange(Ports);
        }

        private void ConnectPortbutton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (PortNameComboBox.Text == "" || BaudRatecomboBox.Text == "")
                {
                    RxTextBox.Text = "Please select port settings";
                }
                else
                {
                    RxTextBox.Enabled = true;
                    serialPort1.PortName = PortNameComboBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudRatecomboBox.Text);
                    serialPort1.Open();
                    RxButton.Enabled = true;
                    TxButton.Enabled = true;
                    TxTextBox.Enabled = true;
                    ConnectPortbutton.Enabled = false;
                    DisconnectPortbutton.Enabled = true;

                    progressBar1.Value = 100;
                }
            }
            catch(UnauthorizedAccessException)
            {
                RxTextBox.Text = "UnauthorizedAccessException";
            }
        }

        private void DisconnectPortbutton_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();

                RxButton.Enabled = false;
                TxButton.Enabled = false;
                TxTextBox.Enabled = false;
                ConnectPortbutton.Enabled = true;
                DisconnectPortbutton.Enabled = false;

                progressBar1.Value = 0;
            }

        }
        
        private void DisplayText(object sender, EventArgs e)
        {
            RxTextBox.AppendText(rxString);
        }

        private void RxFlag(object sender, SerialDataReceivedEventArgs e)
        {
            //serialPort1.ReadLine();
            //RxTextBox.Text = Convert.ToString(serialPort1.ReadChar());
            //RxTextBox.Text =  "Dada Rx Event";
            rxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void RxButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                RxTextBox.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                RxTextBox.Text = "TimeoutException";
            }
        }

        private void TxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] buff = new char[1];
            buff[0] = e.KeyChar;
            serialPort1.Write(buff, 0, 1);
        }
    }
}
