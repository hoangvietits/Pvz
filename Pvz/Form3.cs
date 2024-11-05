using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();
            string comfpassword = textBox3.Text.ToString();
            if (password == comfpassword)
            {
                if (password.Length < 8)
                {
                    MessageBox.Show("Password must have at least 8 characters!");
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    if (GameManager.AddUser(username, password))
                    {
                        MessageBox.Show("Register successfully");
                        this.Close();

                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("You must enter the correct password");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
