using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EasyMcLauncher;

namespace EasyMcLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {

                method.delay(3);
                this.Opacity =(double) i/100;
                double o = this.Opacity;
                this.Text = o + "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
