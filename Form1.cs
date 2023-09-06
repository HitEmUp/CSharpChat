using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Chat
{
    public partial class Form1 : Form
    {
        // Attribute
        private Socket socket;
        private IPEndPoint localIP;
        private EndPoint remoteIP;
        private byte[] buffer;
        private IAsyncResult aResult;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // set up socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get own IP
            tbxLocalIP.Text = GetLocalIP();
            tbxRemoteIP.Text = GetLocalIP();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // binding socket
                localIP = new IPEndPoint(IPAddress.Parse(tbxLocalIP.Text), Convert.ToInt32(tbxLocalPort.Text));
                socket.Bind(localIP);
                // connect to remote IP and port
                remoteIP = new IPEndPoint(IPAddress.Parse(tbxRemoteIP.Text),
                Convert.ToInt32(tbxRemotePort.Text));
                socket.Connect(remoteIP);
                // starts to listen to an specific port
                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteIP, new AsyncCallback(ReciveMessageCallBack), buffer);
                
                // release button to send message
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReciveMessageCallBack(IAsyncResult ar)
        {
            try
            {
                aResult = ar;
                int size = socket.EndReceiveFrom(aResult, ref remoteIP);
                
                if (size > 0)
                {
                    byte[] receivedData = new byte[1500];
                    receivedData = (byte[])aResult.AsyncState;
                
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    lbxChat.Items.Add("Remote: " + receivedMessage);
                }
                // starts to listen the socket again
                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoteIP, new AsyncCallback(ReciveMessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(tbxChatToSend.Text);
                socket.Send(msg);
                
                lbxChat.Items.Add("Local: " + tbxChatToSend.Text);
                tbxChatToSend.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void tbxChatToSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }
    }
}
