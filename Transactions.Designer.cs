namespace BankManagement
{
    partial class Transactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            checkBalBtn = new Button();
            Wdbtn = new Button();
            label8 = new Label();
            BalanceLbl = new Label();
            label5 = new Label();
            WdAccountTb = new TextBox();
            WdAmountTb = new TextBox();
            label3 = new Label();
            CheckBalTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            DepositBtn = new Button();
            label4 = new Label();
            label6 = new Label();
            DepAccountTb = new TextBox();
            DepAmountTb = new TextBox();
            label9 = new Label();
            dataGridView3 = new DataGridView();
            TransferBtn = new Button();
            label10 = new Label();
            label11 = new Label();
            FromTb = new TextBox();
            label12 = new Label();
            dataGridView4 = new DataGridView();
            ToTb = new TextBox();
            label13 = new Label();
            TransAmtTb = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            BalLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // checkBalBtn
            // 
            checkBalBtn.Location = new Point(384, 104);
            checkBalBtn.Margin = new Padding(3, 4, 3, 4);
            checkBalBtn.Name = "checkBalBtn";
            checkBalBtn.Size = new Size(166, 43);
            checkBalBtn.TabIndex = 41;
            checkBalBtn.Text = "Check";
            checkBalBtn.UseVisualStyleBackColor = true;
            checkBalBtn.Click += button2_Click;
            // 
            // Wdbtn
            // 
            Wdbtn.Location = new Point(138, 393);
            Wdbtn.Margin = new Padding(3, 4, 3, 4);
            Wdbtn.Name = "Wdbtn";
            Wdbtn.Size = new Size(153, 40);
            Wdbtn.TabIndex = 40;
            Wdbtn.Text = "Withdraw";
            Wdbtn.UseVisualStyleBackColor = true;
            Wdbtn.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(64, 347);
            label8.Name = "label8";
            label8.Size = new Size(85, 23);
            label8.TabIndex = 37;
            label8.Text = "Amount";
            label8.Click += label8_Click;
            // 
            // BalanceLbl
            // 
            BalanceLbl.AutoSize = true;
            BalanceLbl.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BalanceLbl.Location = new Point(639, 80);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(120, 32);
            BalanceLbl.TabIndex = 33;
            BalanceLbl.Text = "Balance";
            BalanceLbl.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(64, 293);
            label5.Name = "label5";
            label5.Size = new Size(175, 23);
            label5.TabIndex = 31;
            label5.Text = "Account Number";
            label5.Click += label5_Click;
            // 
            // WdAccountTb
            // 
            WdAccountTb.Location = new Point(234, 293);
            WdAccountTb.Margin = new Padding(3, 4, 3, 4);
            WdAccountTb.Name = "WdAccountTb";
            WdAccountTb.Size = new Size(174, 27);
            WdAccountTb.TabIndex = 30;
            WdAccountTb.TextChanged += textBox3_TextChanged;
            // 
            // WdAmountTb
            // 
            WdAmountTb.Location = new Point(234, 340);
            WdAmountTb.Margin = new Padding(3, 4, 3, 4);
            WdAmountTb.Name = "WdAmountTb";
            WdAmountTb.Size = new Size(174, 27);
            WdAmountTb.TabIndex = 28;
            WdAmountTb.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(64, 243);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 27;
            label3.Text = "Withdraw";
            label3.Click += label3_Click;
            // 
            // CheckBalTb
            // 
            CheckBalTb.Location = new Point(83, 116);
            CheckBalTb.Margin = new Padding(3, 4, 3, 4);
            CheckBalTb.Name = "CheckBalTb";
            CheckBalTb.Size = new Size(174, 27);
            CheckBalTb.TabIndex = 26;
            CheckBalTb.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 80);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 25;
            label2.Text = "Check Your Balance";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(351, 12);
            label1.Name = "label1";
            label1.Size = new Size(206, 34);
            label1.TabIndex = 24;
            label1.Text = "Transactions";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 59);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(801, 131);
            dataGridView1.TabIndex = 42;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(41, 240);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(403, 213);
            dataGridView2.TabIndex = 43;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(566, 393);
            DepositBtn.Margin = new Padding(3, 4, 3, 4);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(153, 40);
            DepositBtn.TabIndex = 49;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(491, 347);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 48;
            label4.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(491, 293);
            label6.Name = "label6";
            label6.Size = new Size(175, 23);
            label6.TabIndex = 47;
            label6.Text = "Account Number";
            // 
            // DepAccountTb
            // 
            DepAccountTb.Location = new Point(662, 293);
            DepAccountTb.Margin = new Padding(3, 4, 3, 4);
            DepAccountTb.Name = "DepAccountTb";
            DepAccountTb.Size = new Size(174, 27);
            DepAccountTb.TabIndex = 46;
            // 
            // DepAmountTb
            // 
            DepAmountTb.Location = new Point(662, 340);
            DepAmountTb.Margin = new Padding(3, 4, 3, 4);
            DepAmountTb.Name = "DepAmountTb";
            DepAmountTb.Size = new Size(174, 27);
            DepAmountTb.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.WindowFrame;
            label9.Location = new Point(491, 243);
            label9.Name = "label9";
            label9.Size = new Size(115, 32);
            label9.TabIndex = 44;
            label9.Text = "Deposit";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(469, 240);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(403, 213);
            dataGridView3.TabIndex = 50;
            // 
            // TransferBtn
            // 
            TransferBtn.Location = new Point(550, 613);
            TransferBtn.Margin = new Padding(3, 4, 3, 4);
            TransferBtn.Name = "TransferBtn";
            TransferBtn.Size = new Size(287, 40);
            TransferBtn.TabIndex = 56;
            TransferBtn.Text = "Transfer";
            TransferBtn.UseVisualStyleBackColor = true;
            TransferBtn.Click += TransferBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(64, 575);
            label10.Name = "label10";
            label10.Size = new Size(35, 23);
            label10.TabIndex = 55;
            label10.Text = "To";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(64, 521);
            label11.Name = "label11";
            label11.Size = new Size(61, 23);
            label11.TabIndex = 54;
            label11.Text = "From";
            // 
            // FromTb
            // 
            FromTb.Location = new Point(138, 515);
            FromTb.Margin = new Padding(3, 4, 3, 4);
            FromTb.Name = "FromTb";
            FromTb.Size = new Size(210, 27);
            FromTb.TabIndex = 53;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.WindowFrame;
            label12.Location = new Point(64, 471);
            label12.Name = "label12";
            label12.Size = new Size(127, 32);
            label12.TabIndex = 51;
            label12.Text = "Transfer";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(41, 468);
            dataGridView4.Margin = new Padding(3, 4, 3, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(831, 213);
            dataGridView4.TabIndex = 57;
            // 
            // ToTb
            // 
            ToTb.Location = new Point(138, 568);
            ToTb.Margin = new Padding(3, 4, 3, 4);
            ToTb.Name = "ToTb";
            ToTb.Size = new Size(210, 27);
            ToTb.TabIndex = 58;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(550, 521);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 59;
            label13.Text = "Amount";
            // 
            // TransAmtTb
            // 
            TransAmtTb.Location = new Point(550, 568);
            TransAmtTb.Margin = new Padding(3, 4, 3, 4);
            TransAmtTb.Name = "TransAmtTb";
            TransAmtTb.Size = new Size(210, 27);
            TransAmtTb.TabIndex = 60;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(355, 515);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(355, 568);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(855, 12);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // BalLbl
            // 
            BalLbl.AutoSize = true;
            BalLbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BalLbl.Location = new Point(397, 521);
            BalLbl.Name = "BalLbl";
            BalLbl.Size = new Size(89, 23);
            BalLbl.TabIndex = 65;
            BalLbl.Text = "Balance";
            BalLbl.Click += label7_Click_1;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(926, 697);
            Controls.Add(BalLbl);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(TransAmtTb);
            Controls.Add(label13);
            Controls.Add(ToTb);
            Controls.Add(TransferBtn);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(FromTb);
            Controls.Add(label12);
            Controls.Add(dataGridView4);
            Controls.Add(DepositBtn);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(DepAccountTb);
            Controls.Add(DepAmountTb);
            Controls.Add(label9);
            Controls.Add(dataGridView3);
            Controls.Add(checkBalBtn);
            Controls.Add(Wdbtn);
            Controls.Add(label8);
            Controls.Add(BalanceLbl);
            Controls.Add(label5);
            Controls.Add(WdAccountTb);
            Controls.Add(WdAmountTb);
            Controls.Add(label3);
            Controls.Add(CheckBalTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transactions";
            Load += Transactions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkBalBtn;
        private Button Wdbtn;
        private Label label8;
        private Label BalanceLbl;
        private Label label5;
        private TextBox WdAccountTb;
        private TextBox WdAmountTb;
        private Label label3;
        private TextBox CheckBalTb;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button DepositBtn;
        private Label label4;
        private Label label6;
        private TextBox DepAccountTb;
        private TextBox DepAmountTb;
        private Label label9;
        private DataGridView dataGridView3;
        private Button TransferBtn;
        private Label label10;
        private Label label11;
        private TextBox FromTb;
        private Label label12;
        private DataGridView dataGridView4;
        private TextBox ToTb;
        private Label label13;
        private TextBox TransAmtTb;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label BalLbl;
    }
}