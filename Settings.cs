using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\talha\Downloads\BankManagement\BankManagement\BankManagement\BankDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPassBtn_Click(object sender, EventArgs e)
        {
            if (NewPassTb.Text == "")
            {
                MessageBox.Show("Enter New Password");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPass=@AP where AdId=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AP", NewPassTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Password Updated!");
                    con.Close();
                    NewPassTb.Text = "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
