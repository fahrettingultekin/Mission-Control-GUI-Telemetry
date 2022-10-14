using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Telemetry
{
    public partial class Form1 : Form
    {
        string DataIN;   // I create a string Global Variable Data

        string[,] Data;
        string[] StarData;
        int index = 0;

        Label[] lblBMSTop = new Label[3];
        Label[,] lblBMSElevenData = new Label[3, 11];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CBoxCOMPort.Items.AddRange(ports);

            lblBMSTop[0] = lblBMSTop1;
            lblBMSTop[1] = lblBMSTop2;
            lblBMSTop[2] = lblBMSTop3;

            lblBMSElevenData[0, 0] = lblBMSEleven1;
            lblBMSElevenData[0, 1] = lblBMSEleven2;
            lblBMSElevenData[0, 2] = lblBMSEleven3;
            lblBMSElevenData[0, 3] = lblBMSEleven4;
            lblBMSElevenData[0, 4] = lblBMSEleven5;
            lblBMSElevenData[0, 5] = lblBMSEleven6;
            lblBMSElevenData[0, 6] = lblBMSEleven7;
            lblBMSElevenData[0, 7] = lblBMSEleven8;
            lblBMSElevenData[0, 8] = lblBMSEleven9;
            lblBMSElevenData[0, 9] = lblBMSEleven10;
            lblBMSElevenData[0, 10] = lblBMSEleven11;
            lblBMSElevenData[1, 0] = lblBMSEleven12;
            lblBMSElevenData[1, 1] = lblBMSEleven13;
            lblBMSElevenData[1, 2] = lblBMSEleven14;
            lblBMSElevenData[1, 3] = lblBMSEleven15;
            lblBMSElevenData[1, 4] = lblBMSEleven16;
            lblBMSElevenData[1, 5] = lblBMSEleven17;
            lblBMSElevenData[1, 6] = lblBMSEleven18;
            lblBMSElevenData[1, 7] = lblBMSEleven19;
            lblBMSElevenData[1, 8] = lblBMSEleven20;
            lblBMSElevenData[1, 9] = lblBMSEleven21;
            lblBMSElevenData[1, 10] = lblBMSEleven22;
            lblBMSElevenData[2, 0] = lblBMSEleven23;
            lblBMSElevenData[2, 1] = lblBMSEleven24;
            lblBMSElevenData[2, 2] = lblBMSEleven25;
            lblBMSElevenData[2, 3] = lblBMSEleven26;
            lblBMSElevenData[2, 4] = lblBMSEleven27;
            lblBMSElevenData[2, 5] = lblBMSEleven28;
            lblBMSElevenData[2, 6] = lblBMSEleven29;
            lblBMSElevenData[2, 7] = lblBMSEleven30;
            lblBMSElevenData[2, 8] = lblBMSEleven31;
            lblBMSElevenData[2, 9] = lblBMSEleven32;
            lblBMSElevenData[2, 10] = lblBMSEleven33;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {

            // COM PORT Parametleri
            try
            {
                serialPort1.PortName = CBoxCOMPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(CBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
            }
            
            catch (Exception err)

            //COM PORT Hata
            {
                MessageBox.Show(err.Message,"Select a Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Serial Port Data Receive Part
                        
            DataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
                //This methode show the data serial into TextBox
                //Without this methode you can not show the data to the text box
                                                                    
        }

        private void ShowData(object sender, EventArgs e)
        {
            TextBoxDataIN.Text  +=  DataIN;                 //Serial Porttan okunan verinin TextBox'a yazdırılması
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxDataIN.Text != "")
            {
                TextBoxDataIN.Text = "";                   //Gelen veride satır kayması olursa sıfırlamak için
            }
        }

        private void DataProcess(string Text)              //İdrisin kodları split etme
        {
            Data = new string[8, 15];
            StarData = new string[8];
            if (Text != "")
            {
                string SafeText = Text;
                for (int i = 0; i < 7; i++)
                {
                    index = SafeText.IndexOf('\n');
                    Data[i, 0] = SafeText.Substring(0, index);
                    SafeText = SafeText.Substring(index + 1);
                    if (i == 6)
                        Data[i + 1, 0] = SafeText;
                }
                for (int i = 0; i < 7; i++)
                    if (i < 3)
                        DataProcessing(i, 15);
                    else if (i < 6)
                        DataProcessing(i, 5);
                    else if (i == 6)
                        DataProcessing(i, 7);
            }
        }

        private void DataProcessing(int i, int limit)
        {
            Data[i, 0] = Data[i, 0].Substring(1);
            for (int j = 0; j < limit; j++)
            {
                if (j != (limit - 1))
                {
                    index = Data[i, j].IndexOf(',');
                    Data[i, j + 1] = Data[i, j].Substring(index + 1);
                    Data[i, j] = Data[i, j].Substring(0, index);
                }
                else
                {
                    index = Data[i, j].IndexOf(']');
                    StarData[i] = Data[i, j].Substring(index + 1);
                    Data[i, j] = Data[i, j].Substring(0, index);
                    StarData[i] = StarData[i].Substring(0, 3);
                }
            }
        }

      

        private void DataShow_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer T = new System.Windows.Forms.Timer();
            T.Interval = 10;
            T.Tick += delegate (object sender0, EventArgs e0)
            {
                DataProcess(TextBoxDataIN.Text);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        lblBMSElevenData[i, j].Text = Data[i, j + 3];
                    }
                }
            };
            T.Start();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  //Windows State ekran kapatma
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
