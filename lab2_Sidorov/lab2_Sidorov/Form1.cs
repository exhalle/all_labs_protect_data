using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Sidorov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox_C.Text = strC;

            label_P_hex.Text = Convert.ToString(intP, 16);
            label_P_10.Text = Convert.ToString(intP, 10);
            label_P_2.Text = Convert.ToString(intP, 2);

            label_key_hex.Text = Convert.ToString(intKey, 16);
            label_key_10.Text = Convert.ToString(intKey, 10);
            label_key_2.Text = Convert.ToString(intKey, 2);

            label_C_hex.Text = Convert.ToString(intC, 16);
            label_C_10.Text = Convert.ToString(intC, 10);
            label_C_2.Text = Convert.ToString(intC, 2);

            textBox_C_OUT.Text = textBox_C.Text;
            textBox_Key_OUT.Text = textBox_Key.Text;
            textBox_P_OUT.Text = textBox_P.Text;



        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";

            textBox_C_OUT.Text = "";
            textBox_Key_OUT.Text = "";
            textBox_P_OUT.Text = "";



            label_P_hex.Text = "hex";
            label_P_10.Text = "dec";
            label_P_2.Text = "bin";

            label_key_hex.Text = "hex";
            label_key_10.Text = "dec";
            label_key_2.Text = "bin";

            label_C_hex.Text = "hex";
            label_C_10.Text = "dec";
            label_C_2.Text = "bin";



        }
    }
}
