using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_Sidorov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Dmytro" && textBox_password.Text == "123")  
            {
                label_ok.BackColor = Color.Green; 
                MessageBox.Show("Hello, Dmytro");
            }
            else
            {
                label_ok.BackColor = Color.Red;
                MessageBox.Show("Error login or password,please retry");
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
