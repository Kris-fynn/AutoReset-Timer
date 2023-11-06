using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoReset_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timeRight = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeRight < 100)
            {
                timeRight = timeRight + 1;
                label2.Text = timeRight + "";
            }
            if (label2.Text == "100")
            {
                timeRight = 0;
            }
        }
    }
}
