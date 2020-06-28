using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplenote.Views
{
    public partial class Help : Form
    {
        public int choosing;
        public int Choosing
        {
            get { return choosing; }
            set
            {
                if (choosing == value)
                    return;
                switch (choosing)
                {
                    case 1:
                        lbl1.BackColor = Color.White;
                        break;
                    case 2:
                        lbl2.BackColor = Color.White;
                        break;
                    case 3:
                        lbl3.BackColor = Color.White;
                        break;
                    case 4:
                        lbl4.BackColor = Color.White;
                        break;
                    case 5:
                        lbl5.BackColor = Color.White;
                        break;
                    case 6:
                        lbl6.BackColor = Color.White;
                        break;
                    default:
                        break;
                }
                switch (value)
                {
                    case 1:
                        lbl1.BackColor = Color.FromArgb(197, 197, 197);
                        picHelp.Image.Dispose();
                        picHelp.Image = Properties.Resources._1_fixed;
                        break;
                    case 2:
                        lbl2.BackColor = Color.FromArgb(197, 197, 197);
                        picHelp.Image.Dispose();
                        picHelp.Image = Properties.Resources._2_fixed;
                        break;
                    case 3:
                        lbl3.BackColor = Color.FromArgb(197, 197, 197);
                        picHelp.Image.Dispose();
                        picHelp.Image = Properties.Resources._3_fixed;
                        break;
                    case 4:
                        lbl4.BackColor = Color.FromArgb(197, 197, 197);
                        picHelp.Image.Dispose();
                        picHelp.Image = Properties.Resources._4_fixed;
                        break;
                    case 5:
                        lbl5.BackColor = Color.FromArgb(197, 197, 197);
                        picHelp.Image.Dispose();
                        picHelp.Image = Properties.Resources._5_fixed;
                        break;
                    case 6:
                        lbl6.BackColor = Color.FromArgb(197, 197, 197);
                        picHelp.Image.Dispose();
                        picHelp.Image = Properties.Resources._6_fixed;
                        break;
                }
                choosing = value;
            }
        }
        public Help()
        {
            InitializeComponent();
            Choosing = 1;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            Choosing = 1;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            Choosing = 2;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            Choosing = 3;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            Choosing = 4;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            Choosing = 5;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            Choosing = 6;
        }

        private void lblColor_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.FromArgb(197, 197, 197);
        }

        private void lblColor_MouseLeave(object sender, EventArgs e)
        {
            if (choosing.ToString() == (sender as Label).Name[3].ToString())
                return;
            (sender as Label).BackColor = Color.White;
        }
    }
}
