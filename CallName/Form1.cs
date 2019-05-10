using CallName.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallName
{
    public partial class Form1 : Form
    {
        Thread thread1 = null;
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDraw_Click(object sender, EventArgs e)
        {
            btnDraw.Hide();
            btnStart.Show();
            thread1.Abort();
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            btnDraw.Show();
            var list = PersonRepository.GetPersonList();
            Random random = new Random();
            thread1 = new Thread(() =>
            {
                while (true)
                {
                    if (lblValueName.InvokeRequired)
                    {
                        lblValueName.Invoke(new Action<int>(t => { lblValueName.Text = list[t].Name; }), random.Next(list.Count));
                    }
                    else
                    {
                        lblValueName.Text = list[random.Next(list.Count)].Name;
                    }
                    Thread.Sleep(100);
                }

            });
            thread1.IsBackground = true;
            thread1.Start();

        }
    }
}
