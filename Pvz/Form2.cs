using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pvz
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMenu(GameManager.Login(textBox1.Text, textBox2.Text));
        }

        private void LoadMenu(bool status)
        {

            newGameBtn.Enabled = status;
            newGameBtn.Visible = status;
            continueBtn.Enabled = status;
            continueBtn.Visible = status;
            quitBtn.Enabled = status;
            quitBtn.Visible = status;
            loginPanel.Visible = !status;
            loginPanel.Enabled = !status;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();

            form.TopMost = true;
            form.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadMenu(false);
            
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Are you want to quit ? ", "Confirm", MessageBoxButtons.OKCancel);
            if (dia == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            if (GameManager.Round > 1)
            {
                DialogResult dia = MessageBox.Show("Your previous results will be reset, are you sure about this?", "Warning", MessageBoxButtons.OKCancel);
                if (dia == DialogResult.OK)
                {
                    GameManager.Round = 1;
                    GameManager.Score = 0;
                    CreateF();
                }

            }
            else
            {
                GameManager.Round = 1;
                GameManager.Score = 0;
                CreateF();
            }
        }

        private void CreateF()
        {
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Show();
            this.Hide();
            form1.Show();
        }
        private void continueBtn_Click(object sender, EventArgs e)
        {
            
            CreateF();
        }
    }
}
