namespace BankManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < ProgressBar.Maximum)
            {
                ProgressBar.Value += 1;
            }
            else
            {
                // Reset the progress bar to 0 when it reaches the maximum
                ProgressBar.Value = 0;

                // Stop the timer
                timer1.Stop();

                // Show the login form and hide the current form
                login Obj = new login();
                Obj.Show();
                this.Hide();
            }
        }
    }
}