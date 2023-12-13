using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManagement
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAccounts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\talha\Downloads\BankManagement\BankManagement\BankManagement\BankDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void DisplayAccounts()
        {
            con.Open();
            string Query = "select * from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            AnameTb.Text = "";
            APhoneTb.Text = "";

            AAddressTb.Text = "";
            PasswordTb.Text = "";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            if (AnameTb.Text == "" || APhoneTb.Text == "" || AAddressTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl(Aname,Apass,Aaddress, Aphone) values (@AN, @APA, @AA, @Ah)", con);
                    cmd.Parameters.AddWithValue("@AN", AnameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@Ah", APhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!");
                    con.Close();
                    Reset();
                    DisplayAccounts();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agents_Load(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AnameTb.Text == "" || APhoneTb.Text == "" || AAddressTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AgentTbl set Aname=@AN,Apass=@APA,Aaddress=@AA, Aphone=@Ah where AId=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AN", AnameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@Ah", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated!");
                    con.Close();
                    Reset();
                    DisplayAccounts();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        int Key = 0;
        private void AgentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AgentDGV.Rows[e.RowIndex];
                AnameTb.Text = row.Cells[1].Value.ToString();
                PasswordTb.Text = row.Cells[2].Value.ToString();
                AAddressTb.Text = row.Cells[3].Value.ToString();
                APhoneTb.Text = row.Cells[4].Value.ToString();


                if (AnameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select An Account To Delete");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where AId = @AcKey", con);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted!!!");
                    con.Close();
                    Reset();
                    DisplayAccounts();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void SettingsImg_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
        }
    }
}
