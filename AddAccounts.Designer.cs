namespace BankManagement
{
    partial class AddAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccounts));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            AcNameTb = new TextBox();
            label2 = new Label();
            OccupationTb = new TextBox();
            label3 = new Label();
            AcPhoneTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            AcAddressTb = new RichTextBox();
            EducationCb = new ComboBox();
            GenCb = new ComboBox();
            IncomeTb = new TextBox();
            label8 = new Label();
            CancelBtn = new Button();
            EditBtn = new Button();
            SubmitBtn = new Button();
            AccountDGV = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 565);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(249, 24);
            label1.Name = "label1";
            label1.Size = new Size(311, 37);
            label1.TabIndex = 4;
            label1.Text = "New Form Account";
            // 
            // AcNameTb
            // 
            AcNameTb.Location = new Point(109, 130);
            AcNameTb.Name = "AcNameTb";
            AcNameTb.Size = new Size(153, 23);
            AcNameTb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 89);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 5;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // OccupationTb
            // 
            OccupationTb.Location = new Point(109, 224);
            OccupationTb.Name = "OccupationTb";
            OccupationTb.Size = new Size(153, 23);
            OccupationTb.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 183);
            label3.Name = "label3";
            label3.Size = new Size(128, 24);
            label3.TabIndex = 7;
            label3.Text = "Occupation";
            // 
            // AcPhoneTb
            // 
            AcPhoneTb.Location = new Point(302, 130);
            AcPhoneTb.Name = "AcPhoneTb";
            AcPhoneTb.Size = new Size(153, 23);
            AcPhoneTb.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(302, 89);
            label4.Name = "label4";
            label4.Size = new Size(75, 24);
            label4.TabIndex = 9;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(302, 183);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 11;
            label5.Text = "Education";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(485, 183);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 13;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(485, 89);
            label7.Name = "label7";
            label7.Size = new Size(94, 24);
            label7.TabIndex = 15;
            label7.Text = "Address";
            // 
            // AcAddressTb
            // 
            AcAddressTb.Location = new Point(485, 116);
            AcAddressTb.Name = "AcAddressTb";
            AcAddressTb.Size = new Size(259, 64);
            AcAddressTb.TabIndex = 16;
            AcAddressTb.Text = "";
            // 
            // EducationCb
            // 
            EducationCb.FormattingEnabled = true;
            EducationCb.Items.AddRange(new object[] { "UnEducated", "Diploma", "UG", "PG", "PHD" });
            EducationCb.Location = new Point(302, 224);
            EducationCb.Name = "EducationCb";
            EducationCb.Size = new Size(153, 23);
            EducationCb.TabIndex = 17;
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(485, 224);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(160, 23);
            GenCb.TabIndex = 18;
            GenCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // IncomeTb
            // 
            IncomeTb.Location = new Point(109, 307);
            IncomeTb.Name = "IncomeTb";
            IncomeTb.Size = new Size(153, 23);
            IncomeTb.TabIndex = 20;
            IncomeTb.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(109, 266);
            label8.Name = "label8";
            label8.Size = new Size(86, 24);
            label8.TabIndex = 19;
            label8.Text = "Income";
            label8.Click += label8_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(608, 361);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(190, 46);
            CancelBtn.TabIndex = 21;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(389, 361);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(190, 46);
            EditBtn.TabIndex = 22;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(151, 361);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(190, 46);
            SubmitBtn.TabIndex = 23;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // AccountDGV
            // 
            AccountDGV.BackgroundColor = SystemColors.ActiveCaption;
            AccountDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountDGV.Location = new Point(81, 415);
            AccountDGV.Name = "AccountDGV";
            AccountDGV.RowTemplate.Height = 25;
            AccountDGV.Size = new Size(846, 147);
            AccountDGV.TabIndex = 24;
            AccountDGV.CellContentClick += AccountDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(879, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(927, 565);
            Controls.Add(pictureBox1);
            Controls.Add(AccountDGV);
            Controls.Add(SubmitBtn);
            Controls.Add(EditBtn);
            Controls.Add(CancelBtn);
            Controls.Add(IncomeTb);
            Controls.Add(label8);
            Controls.Add(GenCb);
            Controls.Add(EducationCb);
            Controls.Add(AcAddressTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(AcPhoneTb);
            Controls.Add(label4);
            Controls.Add(OccupationTb);
            Controls.Add(label3);
            Controls.Add(AcNameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAccounts";
            Load += AddAccounts_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox AcNameTb;
        private Label label2;
        private TextBox OccupationTb;
        private Label label3;
        private TextBox AcPhoneTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox AcAddressTb;
        private ComboBox EducationCb;
        private ComboBox GenCb;
        private TextBox IncomeTb;
        private Label label8;
        private Button CancelBtn;
        private Button EditBtn;
        private Button SubmitBtn;
        private DataGridView AccountDGV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}