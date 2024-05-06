using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KhachSan
{
    public class ChatBoxDAO
    {
        IPEndPoint IP;
        Socket server;
        //Socket client;
        public List<Socket> clientList;
        FChatBox fcb;
        /*public void Connect()
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
        }*/
        public void Close()
        {
            server.Close();
        }
        /*public void Send(Socket client, string mess)
        {
            string sender = "Nhân viên: " + mess;
            if (mess != string.Empty)
            {
                client.Send(Serialize(sender));
                AddMess(mess);
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
        }*/
        /*public void AddMess(string mes)
        {
            fcb.lView.Items.Add(new ListViewItem() { Text = mes });
            fcb.TXT_INPUT.Clear();
        }*/
        /*public void AddMess(string mes)
        {
            listView.Items.Add(new ListViewItem() { Text = mes });
            input.Clear();
        }*/
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
