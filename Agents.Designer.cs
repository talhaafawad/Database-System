namespace BankManagement
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            pictureBox1 = new PictureBox();
            AgentDGV = new DataGridView();
            SubmitBtn = new Button();
            EditBtn = new Button();
            CancelBtn = new Button();
            AAddressTb = new RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            label4 = new Label();
            APhoneTb = new TextBox();
            label3 = new Label();
            AnameTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            PasswordTb = new TextBox();
            SettingsImg = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SettingsImg).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(887, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AgentDGV
            // 
            AgentDGV.BackgroundColor = SystemColors.ActiveCaption;
            AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgentDGV.Location = new Point(84, 347);
            AgentDGV.Name = "AgentDGV";
            AgentDGV.RowTemplate.Height = 25;
            AgentDGV.Size = new Size(846, 147);
            AgentDGV.TabIndex = 46;
            AgentDGV.CellContentClick += AgentDGV_CellContentClick;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Location = new Point(117, 287);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(190, 46);
            SubmitBtn.TabIndex = 45;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(337, 287);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(190, 46);
            EditBtn.TabIndex = 44;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(562, 287);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(190, 46);
            CancelBtn.TabIndex = 43;
            CancelBtn.Text = "Delete";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AAddressTb
            // 
            AAddressTb.Location = new Point(493, 115);
            AAddressTb.Name = "AAddressTb";
            AAddressTb.Size = new Size(259, 64);
            AAddressTb.TabIndex = 38;
            AAddressTb.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(493, 88);
            label7.Name = "label7";
            label7.Size = new Size(94, 24);
            label7.TabIndex = 37;
            label7.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(310, 88);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 33;
            label4.Text = "Password";
            // 
            // APhoneTb
            // 
            APhoneTb.Location = new Point(117, 223);
            APhoneTb.Name = "APhoneTb";
            APhoneTb.Size = new Size(153, 23);
            APhoneTb.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 182);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 31;
            label3.Text = "Phone";
            label3.Click += label3_Click;
            // 
            // AnameTb
            // 
            AnameTb.Location = new Point(117, 129);
            AnameTb.Name = "AnameTb";
            AnameTb.Size = new Size(153, 23);
            AnameTb.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 29;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(350, 12);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 28;
            label1.Text = "Manage Agents";
            label1.Click += label1_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 494);
            panel1.TabIndex = 27;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(310, 129);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(153, 23);
            PasswordTb.TabIndex = 48;
            // 
            // SettingsImg
            // 
            SettingsImg.Image = (Image)resources.GetObject("SettingsImg.Image");
            SettingsImg.Location = new Point(90, 11);
            SettingsImg.Name = "SettingsImg";
            SettingsImg.Size = new Size(36, 32);
            SettingsImg.SizeMode = PictureBoxSizeMode.Zoom;
            SettingsImg.TabIndex = 49;
            SettingsImg.TabStop = false;
            SettingsImg.Click += SettingsImg_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(132, 19);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 50;
            label5.Text = "Settings";
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(931, 494);
            Controls.Add(label5);
            Controls.Add(SettingsImg);
            Controls.Add(PasswordTb);
            Controls.Add(pictureBox1);
            Controls.Add(AgentDGV);
            Controls.Add(SubmitBtn);
            Controls.Add(EditBtn);
            Controls.Add(CancelBtn);
            Controls.Add(AAddressTb);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(APhoneTb);
            Controls.Add(label3);
            Controls.Add(AnameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agents";
            Load += Agents_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SettingsImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView AgentDGV;
        private Button SubmitBtn;
        private Button EditBtn;
        private Button CancelBtn;
        private RichTextBox AAddressTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private TextBox PasswordTb;
        private Label label4;
        private TextBox APhoneTb;
        private Label label3;
        private TextBox AnameTb;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private MaskedTextBox PasswordTB;
        private PictureBox SettingsImg;
        private Label label5;
    }
}