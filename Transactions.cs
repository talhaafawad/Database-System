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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\talha\Downloads\BankManagement\BankManagement\BankManagement\BankDB.mdf;Integrated Security=True;Connect Timeout=30");

        int Balance;
        private void CheckBalance()
        {
            try
            {

                {
                    con.Open();

                    string query = "SELECT * FROM AccountTbl WHERE AcNum = @AcNum";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AcNum", CheckBalTb.Text);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    BalanceLbl.Text = "Rs " + dr["AcBal"].ToString();
                                    Balance = Convert.ToInt32(dr["AcBal"].ToString());
                                }
                            }
                            else
                            {
                                // Handle case when no data is found
                                MessageBox.Show("Account not found");
                            }
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (display an error message, log the error, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GetNewBalance()
        {
            try
            {

                {
                    con.Open();

                    string query = "SELECT * FROM AccountTbl WHERE AcNum = @AcNum";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AcNum", CheckBalTb.Text);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {

                                    Balance = Convert.ToInt32(dr["AcBal"].ToString());
                                }
                            }
                            else
                            {
                                // Handle case when no data is found
                                MessageBox.Show("Account not found");
                            }
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (display an error message, log the error, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WdAccountTb.Text == "" || WdAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Withdraw();
                GetNewBalance();
                if (Balance < Convert.ToInt32(WdAmountTb.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int newBal = Balance - Convert.ToInt32(WdAmountTb.Text);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AN where AcNum=@AcKey", con);
                        cmd.Parameters.AddWithValue("@AN", newBal);
                        cmd.Parameters.AddWithValue("@AcKey", WdAccountTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Withdrawn!");
                        con.Close();
                        WdAmountTb.Text = "";
                        WdAmountTb.Text = "";
                        BalanceLbl.Text = "Balance";


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckBalTb.Text == "")
            {
                MessageBox.Show("Enter Correct Account Number");
            }
            else
            {
                CheckBalance();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Deposit()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TACNum) values (@TN,@TD,@TA,@TAC)", con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmountTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmountTb.Text);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }
        private void Withdraw()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmt,TACNum) values (@TN,@TD,@TA,@TAC)", con);
                cmd.Parameters.AddWithValue("@TN", "Withdraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmountTb.Text);
                cmd.Parameters.AddWithValue("@TAC", DepAmountTb.Text);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }
        private void SubstractBal()
        {

            int newBal = Balance - Convert.ToInt32(TransAmtTb.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AN where AcNum=@AcKey", con);
                cmd.Parameters.AddWithValue("@AN", newBal);
                cmd.Parameters.AddWithValue("@AcKey", FromTb.Text);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Money Deposited!");
                con.Close();
                //DepAccountTb.Text = "";
                //DepAmountTb.Text = "";
                //BalanceLbl.Text = "Balance";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddBal()
        {

            int newBal = Convert.ToInt32(TransAmtTb.Text);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcBal = AcBal + @AN WHERE AcNum = @AcKey", con);
                cmd.Parameters.AddWithValue("@AN", newBal);
                cmd.Parameters.AddWithValue("@AcKey", ToTb.Text);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Money Deposited!");
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DepAccountTb.Text == "" || DepAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                Deposit();
                GetNewBalance();
                int newBal = Balance + Convert.ToInt32(DepAmountTb.Text);
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AN where AcNum=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AN", newBal);
                    cmd.Parameters.AddWithValue("@AcKey", DepAccountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Deposited!");
                    con.Close();
                    DepAccountTb.Text = "";
                    DepAmountTb.Text = "";
                    BalanceLbl.Text = "Balance";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        private void CheckAvailableBalance()
        {
            try
            {

                {
                    //con.Open();

                    string query = "SELECT * FROM AccountTbl WHERE AcNum = @AcNum";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AcNum", FromTb.Text);

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    BalLbl.Text = "Rs " + dr["AcBal"].ToString();
                                    Balance = Convert.ToInt32(dr["AcBal"].ToString());
                                }
                            }
                            else
                            {
                                // Handle case when no data is found
                                MessageBox.Show("Account not found");
                            }
                            //con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (display an error message, log the error, etc.)
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (FromTb.Text == "")
            {
                MessageBox.Show("Enter Source Account");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AccountTbl WHERE AcNum = '" + FromTb.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    con.Close();
                }



                else
                {
                    MessageBox.Show("Account Doesn't Exist");
                    FromTb.Text = "";
                    con.Close();

                }
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "")
            {
                MessageBox.Show("Enter Destination Account");
            }
            else
            {

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AccountTbl WHERE AcNum = '" + ToTb.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    con.Close();
                    if (ToTb.Text != FromTb.Text)
                    {
                        MessageBox.Show("Account Found");

                    }
                    else if (ToTb.Text == FromTb.Text)
                    {
                        MessageBox.Show("Source and Destination Accounts are Same");
                        ToTb.Text = "";
                    }

                }



                else
                {
                    MessageBox.Show("Account Doesn't Exist");
                    ToTb.Text = "";
                    con.Close();

                }
                con.Close();
            }
        }
        private void Transfer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransferTbl(TrSrc,TrDest,TrAmt,TrDate) values (@TS,@TD,@TA,@TDA)", con);
                cmd.Parameters.AddWithValue("@TS", FromTb.Text);
                cmd.Parameters.AddWithValue("@TD", ToTb.Text);
                cmd.Parameters.AddWithValue("@TA", TransAmtTb.Text);
                cmd.Parameters.AddWithValue("@TDA", DateTime.Now.Date);
                MessageBox.Show("Money Transferred!");
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "" || FromTb.Text == "" || TransAmtTb.Text == "")
            {

                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt16(TransAmtTb.Text) > Balance)
            {

                MessageBox.Show("Insufficient Balance");
            }
            else
            {

                Transfer();
                SubstractBal();
                AddBal();
                FromTb.Text = "";
                ToTb.Text = "";
                TransAmtTb.Text = "";

            }
        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }
    }
}
