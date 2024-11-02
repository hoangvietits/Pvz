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
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            string connection = @"Server = DESKTOP-TU4C4IS\GODMODE; Database = Pvz; Trusted_Connection = True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserName, Score, Round, Role FROM [dbo].Player WHERE Username = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        var result = cmd.ExecuteReader();
                        if (result.Read())
                        {
                            GameManager.Name = result["UserName"].ToString();
                            GameManager.Score = Convert.ToInt32(result["Score"]);
                            GameManager.Round = Convert.ToInt32(result["Round"]);
                            GameManager.Role = result["Role"].ToString();
                            LoadMenu(true);

                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Erro");
                }
            }
        }

        private void LoadMenu(bool status)
        {
            newGameBtn.Enabled = status;
            newGameBtn.Visible = status;
            continueBtn.Enabled = status;
            continueBtn.Visible = status;
            rankBtn.Enabled = status;
            rankBtn.Visible = status;
            quitBtn.Enabled = status;
            quitBtn.Visible = status;
            loginPanel.Visible = !status;
            loginPanel.Enabled = !status;
        }
        private void button2_Click(object sender, EventArgs e)
        {

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
            else
            {

            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            GameManager.Round = 1;
            GameManager.Score = 0;
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
