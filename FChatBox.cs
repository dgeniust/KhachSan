using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class FChatBox : Form
    {
        IPEndPoint IP;
        Socket server;
        //Socket client;
        public List<Socket> clientList;
        string tentk;
        public FChatBox(string TENTK)
        {
            InitializeComponent();
            this.tentk = TENTK;
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {   
            foreach(Socket s in clientList)
            {
                Send(s);
            }
            txt_Input.Clear();
            AddMess(txt_Input.Text);
        }

        private void FChatBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        public void Connect()
        {
            clientList = new List<Socket>();
            //IP : địa chỉ của server
            //IP = new IPEndPoint(IPAddress.Parse("26.240.138.246"), 8888);
            IP = new IPEndPoint(IPAddress.Any, 8888);
            //nơi để xài cái địa chỉ đó
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(1);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        public void Close()
        {
            server.Close();
        }
        public void Send(Socket client)
        {
            string sender = tentk +": " +txt_Input.Text;
            if (txt_Input.Text != string.Empty)
            {
                client.Send(Serialize(sender));
                AddMess(txt_Input.Text);
            }
        }
        public void Receive(Object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    AddMess(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        public void AddMess(string mes)
        {
            listView.Items.Add(new ListViewItem() { Text = mes });
            txt_Input.Clear();
        }
        //Phân mảnh
        byte[] Serialize(Object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter format = new BinaryFormatter();

            format.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter format = new BinaryFormatter();

            return format.Deserialize(stream);
        }
    }
}
