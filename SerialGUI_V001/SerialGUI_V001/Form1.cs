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
                    terminalBox.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = PortNameComboBox.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudRatecomboBox.Text);
                    serialPort1.Open();
                    TxButton.Enabled = true;
                    txBox.Enabled = true;
                    clrButton.Enabled = true;
                    DisconnectPortbutton.Enabled = true;
                    ConnectPortbutton.Enabled = false;
                    PortNameComboBox.Enabled = false;
                    BaudRatecomboBox.Enabled = false;
                }
            }
            catch(UnauthorizedAccessException)
            {
                terminalBox.Text = "UnauthorizedAccessException";
            }
        }

        private void DisconnectPortbutton_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();

                TxButton.Enabled = false;
                txBox.Enabled = false;
                DisconnectPortbutton.Enabled = false;
                clrButton.Enabled = false;
                ConnectPortbutton.Enabled = true;
                PortNameComboBox.Enabled = true;
                BaudRatecomboBox.Enabled = true;
            }

        }
        
        private void DisplayText(object sender, EventArgs e)
        {
            terminalBox.AppendText(rxString);
        }

        private void RxFlag(object sender, SerialDataReceivedEventArgs e)
        {
            rxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void RxButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                terminalBox.Text = serialPort1.ReadLine();
            }
            catch (TimeoutException)
            {
                terminalBox.Text = "TimeoutException";
            }
        }

        private void txBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] buff = new char[1];
            buff[0] = e.KeyChar;

            serialPort1.Write(buff, 0, 1);
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            terminalBox.ResetText();
            txBox.ResetText();
        }
    }
}
