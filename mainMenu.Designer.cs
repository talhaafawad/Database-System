namespace BankManagement
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            AccountPictureBox = new PictureBox();
            SettingsPicBox = new PictureBox();
            TransactionPicBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)AccountPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingsPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransactionPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // AccountPictureBox
            // 
            AccountPictureBox.Image = Properties.Resources.user;
            AccountPictureBox.Location = new Point(690, 83);
            AccountPictureBox.Margin = new Padding(3, 4, 3, 4);
            AccountPictureBox.Name = "AccountPictureBox";
            AccountPictureBox.Size = new Size(139, 139);
            AccountPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            AccountPictureBox.TabIndex = 0;
            AccountPictureBox.TabStop = false;
            AccountPictureBox.Click += AccountPictureBox_Click;
            // 
            // SettingsPicBox
            // 
            SettingsPicBox.Image = (Image)resources.GetObject("SettingsPicBox.Image");
            SettingsPicBox.Location = new Point(693, 445);
            SettingsPicBox.Margin = new Padding(3, 4, 3, 4);
            SettingsPicBox.Name = "SettingsPicBox";
            SettingsPicBox.Size = new Size(137, 139);
            SettingsPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            SettingsPicBox.TabIndex = 1;
            SettingsPicBox.TabStop = false;
            SettingsPicBox.Click += SettingsPicBox_Click;
            // 
            // TransactionPicBox
            // 
            TransactionPicBox.Image = (Image)resources.GetObject("TransactionPicBox.Image");
            TransactionPicBox.Location = new Point(667, 261);
            TransactionPicBox.Margin = new Padding(3, 4, 3, 4);
            TransactionPicBox.Name = "TransactionPicBox";
            TransactionPicBox.Size = new Size(162, 139);
            TransactionPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            TransactionPicBox.TabIndex = 2;
            TransactionPicBox.TabStop = false;
            TransactionPicBox.Click += TransactionPicBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 61);
            label1.Name = "label1";
            label1.Size = new Size(598, 46);
            label1.TabIndex = 3;
            label1.Text = "Account Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(693, 35);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 4;
            label2.Text = "Accounts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(693, 225);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 5;
            label3.Text = "Transactions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(693, 404);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 6;
            label4.Text = "Settings";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bank;
            pictureBox4.Location = new Point(267, 155);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(234, 261);
            label5.Name = "label5";
            label5.Size = new Size(194, 39);
            label5.TabIndex = 9;
            label5.Text = "Main Menu";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(843, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TransactionPicBox);
            Controls.Add(SettingsPicBox);
            Controls.Add(AccountPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainMenu";
            Load += mainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)AccountPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingsPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransactionPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AccountPictureBox;
        private PictureBox SettingsPicBox;
        private PictureBox TransactionPicBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private PictureBox pictureBox2;
    }
}