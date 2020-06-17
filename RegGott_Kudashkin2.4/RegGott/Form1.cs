using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegGott

{
    public partial class Form1 : Form
    {
        int time = 0;
        int counter = 0;
        int lim = 3;
        int timeleft = 60;
        string tb;
        public Form1() 

        {

            InitializeComponent();
            TimeS.Text = "Авторизация";

        }


        private void button1_Click(object sender, EventArgs e)
        {

            

            if (counter == lim)
            {

                LoginB.Enabled = false;     //блокируем ввод логина
                PasswordB.Enabled = false; //блокируем ввод пароля

                button1.Enabled = false; //блокируем кнопку входа

                timer1.Start();

                counter = 0;

            }
            if (LoginB.Text == "Gott" && PasswordB.Text == "13572468") //Верный логин и пароль
            {
                tb = "Вход выполнен ";

                MessageBox.Show(tb);

            }
            else if (counter < lim)
            {
                counter++;
                tb = "Неправильный логин/пароль. У вас осталось " + (3 - counter).ToString() + " попыток входа";


                MessageBox.Show(tb);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft -1;
            TimeS.Text = "До разблокировки: " + timeleft.ToString() + " секунд";
            time++;

            if (timeleft <= 0)
            {
                LoginB.Enabled = Enabled;     // Разблокировки
                PasswordB.Enabled = Enabled; //  полей ввода

                button1.Enabled = Enabled;   // разблокировка входа
                timer1.Stop();
                timeleft = 60;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
