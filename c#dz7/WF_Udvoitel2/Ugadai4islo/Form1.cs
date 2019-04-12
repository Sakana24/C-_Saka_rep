using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugadai4islo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int number;

        static int Check(int a, int b)
        {
            if (a == b) return 1;
            else if (a > b) return 2;
            else if (a < b) return 3;
            else return 0;
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            number = r.Next(100);
            lblAnswer.Text = "Я загадал число от 1 до 100, \nпопробуй угадать!";
        }

        public void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                switch(Check(int.Parse(textBox1.Text), number))
                {
                    case 1: lblAnswer.Text = "Молодец!";
                        break;
                    case 2: lblAnswer.Text = "Мое число меньше";
                        break;
                    case 3: lblAnswer.Text = "Мое число больше";
                        break;
                    case 4:
                        break;
                }
            }
            catch
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
