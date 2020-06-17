using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            answer.Click += Answer_Click;
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AgeCat.Text) == 1)////
            {
                int answer = 15;
                AgePersonTxt.Text = Convert.ToString( answer );
            }

            if (Convert.ToInt32(AgeCat.Text) == 2)////
            {
                int answer = 25;
                AgePersonTxt.Text = Convert.ToString( answer );
            }


            if (Convert.ToInt32(AgeCat.Text) > 2)////
            {
                int answer = Convert.ToInt32(AgeCat.Text) * 4 + 15 + 2;
                AgePersonTxt.Text = Convert.ToString( answer );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
