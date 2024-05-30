using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// gui tin cho tat ca client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach(Socket Item in clientList)
            {
                Send(Item);
            }
            AddMessage(txbMessage.Text);
           txbMessage.Clear();
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        

        /// <summary>
        /// ket noi toi server
        /// </summary>

        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9998);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);

            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch {
                    IP = new IPEndPoint(IPAddress.Any, 9998);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        /// <summary>
        /// Dong ket noi toi server
        /// </summary>
        void Close()
        {
            server.Close();
        }

        /// <summary>
        /// gui tin
        /// </summary>
        void Send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(txbMessage.Text);
            if (client != null && txbMessage.Text != string.Empty)
            client.Send(data);
        }
        /// <summary>
        /// nhan tin
        /// </summary>
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Encoding.UTF8.GetString(data);
                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(data);
                        }    
                        
                    }
                    AddMessage(message);
                }

            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }
        void AddMessage(string data)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = data });
        }
    }
}
