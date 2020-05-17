using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //定义一个socket用于监听
            Socket _server = new Socket(SocketType.Stream, ProtocolType.Tcp);
            var ip = IPAddress.Parse(txtIP.Text);
            _server.Bind(new IPEndPoint(ip, Convert.ToInt32(txtPort.Text)));
            _server.Listen(10);//设置最大监听多少个连接
            var accept = _server.Accept();
            accept.RemoteEndPoint.ToString();
        }
    }
}
