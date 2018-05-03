using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 设置定时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            //按照时间,定时播放音乐
            if (DateTime.Now.Hour == 13 && DateTime.Now.Minute == 23)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer(@"C:\Users\yurifeng\Desktop\Ring05.wav");
                sp.Load();
                sp.Play();
            }
        }
    }
}
