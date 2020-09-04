using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonExist_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxExist.Enabled = true;
            textBoxNew.Enabled = false;
        }

        private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxExist.Enabled = false;
            textBoxNew.Enabled = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int multiplier, key;
            string encryptedKey;
            if(radioButton1.Checked == true)
            {
                key = 127;
                multiplier = GenerateRandomNo1();
                key = key * multiplier;
                encryptedKey = key.ToString("X");
                textBoxKey.Text = key.ToString();
            }
            if (radioButton2.Checked == true)
            {
                key = 271;
                multiplier = GenerateRandomNo2();
                key = key * multiplier;
                encryptedKey = key.ToString("X");
                textBoxKey.Text = key.ToString();
            }
            if (radioButton3.Checked == true)
            {
                key = 727;
                multiplier = GenerateRandomNo3();
                key = key * multiplier;
                encryptedKey = key.ToString("X");
                textBoxKey.Text = key.ToString();
            }
        }

        public int GenerateRandomNo1()
        {
            int random = 271;
            while(random % 271 == 0 || random % 727 == 0)
            {
                int _min = 100000000;
                int _max = 999999999;
                Random _rdm = new Random();
                random = _rdm.Next(_min, _max);
            }
            return random;
        }

        public int GenerateRandomNo2()
        {
            int random = 127;
            while (random % 127 == 0 || random % 727 == 0)
            {
                int _min = 100000000;
                int _max = 999999999;
                Random _rdm = new Random();
                random = _rdm.Next(_min, _max);
            }
            return random;
        }

        public int GenerateRandomNo3()
        {
            int random = 127;
            while (random % 127 == 0 || random % 271 == 0)
            {
                int _min = 100000000;
                int _max = 999999999;
                Random _rdm = new Random();
                random = _rdm.Next(_min, _max);
            }
            return random;
        }
    }
}
