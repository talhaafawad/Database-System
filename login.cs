using System;
using System.Collections;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\talha\Downloads\BankManagement\BankManagement\BankManagement\BankDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select The Role");

            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }
                else
                {

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AdminTbl WHERE AdName = '" + UnameTb.Text + "' AND AdPass = '" + PasswordTb.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents Obj = new Agents();
                        Obj.Show();
                        this.Hide();
                        con.Close();
                    }



                    else
                    {
                        MessageBox.Show("Incorrect Admin name or password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    con.Close();
                }
            }
            else if (RoleCb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both User Name and Password");
                }
                else
                {

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AgentTbl WHERE AName = '" + UnameTb.Text + "' AND APass = '" + PasswordTb.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        mainMenu Obj = new mainMenu();
                        Obj.Show();
                        this.Hide();
                        con.Close();
                    }



                    else
                    {
                        MessageBox.Show("Incorrect User name or password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    con.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
