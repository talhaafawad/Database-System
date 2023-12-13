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

namespace BankManagement
{
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\talha\Downloads\BankManagement\BankManagement\BankManagement\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayAccounts()
        {
            con.Open();
            string Query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            AcNameTb.Text = "";
            AcPhoneTb.Text = "";

            AcAddressTb.Text = "";
            GenCb.SelectedIndex = -1;
            OccupationTb.Text = "";
            IncomeTb.Text = "";
            EducationCb.SelectedIndex = -1;
        }
        private void AddAccounts_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == " " || AcPhoneTb.Text == " " ||
               AcAddressTb.Text == " " ||
               GenCb.SelectedIndex == -1 ||
               OccupationTb.Text == "" ||
               EducationCb.SelectedIndex == -1 ||
               IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(AcName,AcPhone,AcAddress, AcGen, AcOccup, AcEduc, AcInc, AcBal)values(@AN, @AP, @AA, @AG, @AO, @AE, @AI, @AB)", con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!");
                    con.Close();
                    Reset();
                    DisplayAccounts();


                }
                catch (Exception )
                {

                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Key = 0;
        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = AccountDGV.Rows[e.RowIndex];
                AcNameTb.Text = row.Cells[1].Value.ToString();
                AcPhoneTb.Text = row.Cells[2].Value.ToString();
                AcAddressTb.Text = row.Cells[3].Value.ToString();
                GenCb.SelectedItem = row.Cells[4].Value.ToString();
                OccupationTb.Text = row.Cells[5].Value.ToString();
                EducationCb.SelectedItem = row.Cells[6].Value.ToString();
                IncomeTb.Text = row.Cells[7].Value.ToString();

                if (AcNameTb.Text == "")
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
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where ACNum = @AcKey", con);
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == " " || AcPhoneTb.Text == " " ||
              AcAddressTb.Text == " " ||
              GenCb.SelectedIndex == -1 ||
              OccupationTb.Text == "" ||
              EducationCb.SelectedIndex == -1 ||
              IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcName=@AN,AcPhone=@AP,AcAddress=@AA, AcGen=@AG, AcOccup=@AO, AcEduc=@AE, AcInc=@AI where ACNUM=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated!");
                    con.Close();
                    Reset();
                    DisplayAccounts();


                }
                catch (Exception )
                {

                }
            }
        }
    }
}
