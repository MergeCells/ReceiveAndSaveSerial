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
using System.IO;

namespace ReceiveAndSaveSerial
{
    public partial class Form1 : Form
    {
        int[] baudRate = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200 };

        private delegate void Delegate_receiveDataToTextBox(string data);

        public Form1()
        {
            InitializeComponent();
        }

        private void FormInit(){
            string[] PortList = SerialPort.GetPortNames();
            com_cbx.Items.Clear();

            foreach (string PortName in PortList)
            {
                com_cbx.Items.Add(PortName);
            }
            if (com_cbx.Items.Count > 0)
            {
                com_cbx.SelectedIndex = 0;
            }

            baudRate_cbx.Items.Clear();
            foreach (int rate in baudRate)
            {
                baudRate_cbx.Items.Add(rate);
            }
            baudRate_cbx.SelectedIndex = 5;
            state_txb.Text = "Not connecting";
            if (checkBox1.Checked == true)
            {
                filename_txb.Text = DateTime.Now.ToString("yyMMdd_HHmmss");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormInit();
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                com_cbx.Enabled = true;
                baudRate_cbx.Enabled = true;
                connect_btn.Text = "Connect";
                state_txb.Clear();
                state_txb.Text = "Not connecting";
                receive_txb.Clear();
            }
            else
            {
                // オープンするシリアルポートをコンボボックスから取り出す.
                serialPort1.PortName = com_cbx.SelectedItem.ToString();

                // ボーレートをコンボボックスから取り出す.
                serialPort1.BaudRate = baudRate[baudRate_cbx.SelectedIndex];

                // データビットをセットする. (データビット = 8ビット)
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;
                serialPort1.ReceivedBytesThreshold = 1;

                try
                {
                    serialPort1.Open();
                    state_txb.Clear();
                    state_txb.Text = "Open : " + serialPort1.PortName +" "+ serialPort1.BaudRate;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                com_cbx.Enabled = false;
                baudRate_cbx.Enabled = false;
                connect_btn.Text = "Disconnect";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // シリアルポートをオープンしていない場合、処理を行わない.
            if (serialPort1.IsOpen == false)
            {
                return;
            }

            try
            {
                // 受信データを読み込む.
                string data = serialPort1.ReadExisting();

                // 受信したデータをテキストボックスに書き込む.
                Invoke(new Delegate_receiveDataToTextBox(receiveDataToTextBox), new Object[] { data });

                fileWrite(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receiveDataToTextBox(string data)
        {
            // 受信データをテキストボックスの最後に追記する.
            if (data != null)
            {
                receive_txb.AppendText(data);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                connect_btn.PerformClick();
            }
            FormInit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (MessageBox.Show("フォームを終了します", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    serialPort1.Close();
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static bool loggingState = false;

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (loggingState == false)
                {
                    start_btn.Text = "Logging Stop";
                    receive_txb.Clear();
                    state_txb.Text = "Logging";
                    loggingState = true;
                }
                else
                {
                    start_btn.Text = "Logging Start";
                    state_txb.Text = "Logging stopped";
                    loggingState = false;
                    if(checkBox1.Checked == true){
                        filename_txb.Text = DateTime.Now.ToString("yyMMdd_HHmmss");
                    }
                }
            }
        }

        private static string path = "C:";
        private static string file = "";

        private void fileWrite(string words = "")
        {
            file = path + "\\" + filename_txb.Text + ".txt";
            try
            {
                if (file != null)
                {
                    StreamWriter writer = new StreamWriter(file, true, Encoding.GetEncoding("Shift_JIS"));
                    writer.Write(words);
                    writer.Close();
                }
            }
            catch (FileNotFoundException) {
                MessageBox.Show("File save failed");
            }
        }

        private void pathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                path = dialog.SelectedPath;
                path_txb.Text = path;
                state_txb.Text = "Save directory selected.";
            }
        }
    }
}
