using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace KlientForm
{
    public partial class Form1 : Form
    {


        TcpClient klient = new TcpClient();
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }


        private void inputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!klient.Connected)
            {
                StartaAnslutning();
            }
        }

        private void klientButton_Click(object sender, EventArgs e)
        {
            StartaSändning(textBox1.Text);
            textBox1.Text = "";
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(ipTextbox.Text);
                await klient.ConnectAsync(adress, port);
                StartaLäsning(klient);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
            connectBtn.Enabled = false;
        }

        public async void StartaSändning (string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
        }
        public async void StartaLäsning(TcpClient k)
        {
            byte[] buffert = new byte[1024];

            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }

            chatTextBox.AppendText(Encoding.Unicode.GetString(buffert, 0, n));

            StartaLäsning(k);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
