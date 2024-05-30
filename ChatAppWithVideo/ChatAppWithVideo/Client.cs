using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatAppWithVideo
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        /// <summary>
        /// gui tin di
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txbMessage.Text);

        }
        IPEndPoint IP;
        Socket client;
        
        
        /// <summary>
        /// ket noi toi server
        /// </summary>
        
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9998);
            client = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// Dong ket noi toi server
        /// </summary>
        void Close()
        {
            client.Close();
        }

        /// <summary>
        /// gui tin
        /// </summary>
        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(txbMessage.Text);
            if (txbMessage.Text != string.Empty )
            client.Send(data);
        }
        /// <summary>
        /// nhan tin
        /// </summary>
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Encoding.UTF8.GetString(data);
                    AddMessage(message);
                }

            }
            catch
            {
                Close();
            }
        }
        void AddMessage(string data)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = data });
            txbMessage.Clear();
        }
        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

    }
}
