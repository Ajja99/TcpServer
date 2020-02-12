using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpServer
{
    public partial class ServerForm : Form
    {
        //KlientForm.Form1 Form1 = new KlientForm.Form1();
        //KlientForm.Form1 Form2 = new KlientForm.Form1();

        Dictionary<TcpClient, string> usernames = new Dictionary<TcpClient, string>();

        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        List<TcpClient> klienter = new List<TcpClient>();

        public ServerForm()
        {
            InitializeComponent();
            //Form1.Show();
            //Form2.Show();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
            }
            catch (Exception)
            {

                return;
            }

            serverButton.Enabled = false;
            
            StartaMottagning();
        }

        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
                AssignUsername(klient);
                klienter.Add(klient);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); throw;
            }
            StartaLäsning(klient);
            StartaMottagning();
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
            string username = usernames[k];
            string s = DateTime.Now + username + ">"
                + Encoding.Unicode.GetString(buffert, 0, n)
                + Environment.NewLine;
            serverTextBox.AppendText(s);

            StartaSändning(s);
            StartaLäsning(k);
        }

        public async void StartaSändning(string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);
            try
            {
                foreach (TcpClient k in klienter)
                {
                    await k.GetStream().WriteAsync(utData, 0, utData.Length);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
        }
        public async void AssignUsername(TcpClient k)
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
            usernames.Add(k, Encoding.Unicode.GetString(buffert, 0, n));
        }
    }
}