//1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
//должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте
// обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.
//Рыбин

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";

        }

        Stack<int> numbers = new Stack<int>();

        static int Compare(int a, int b)
        {
            if (a == b) return 1;
            else return 0;
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
            numbers.Push(int.Parse(lblNumber.Text));
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
            numbers.Push(int.Parse(lblNumber.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            lblCounter.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                numbers.Pop().ToString();
                lblNumber.Text = numbers.Peek().ToString();
                lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
            }
            catch
            {
                lblNumber.Text = "0";
            }
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lblNeeded.Text = ("Мне нужно число");
            lblNumberGame.Text = ($"{r.Next(1000)}");
            lblCounter.Text = "0";
            lblNumber.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (Compare(int.Parse(lblNumber.Text), int.Parse(lblNumberGame.Text)) == 1)
                    MessageBox.Show("Поздавляю!");
                else
                    MessageBox.Show("Постарайтесь еще");
            }
            catch
            {
            }
        }
    }
}
