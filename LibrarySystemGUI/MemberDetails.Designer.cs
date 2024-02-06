namespace LibrarySystemGUI
{
    partial class MemberDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.PesonalDetailsID = new System.Windows.Forms.Label();
            this.PersonalDetailsUsername = new System.Windows.Forms.Label();
            this.PersonalDetailsPassword = new System.Windows.Forms.Label();
            this.PersonalDetailsGender = new System.Windows.Forms.Label();
            this.PersonalDetailsAddress = new System.Windows.Forms.Label();
            this.PersonalDetailsLname = new System.Windows.Forms.Label();
            this.PersonalDetailsFname = new System.Windows.Forms.Label();
            this.PersonalDetailsDOB = new System.Windows.Forms.Label();
            this.MemberIDTxtBox = new System.Windows.Forms.TextBox();
            this.fnameTxtBox = new System.Windows.Forms.TextBox();
            this.LnameTXTBox = new System.Windows.Forms.TextBox();
            this.UsernameTXTbox = new System.Windows.Forms.TextBox();
            this.PasswordTXTBox = new System.Windows.Forms.TextBox();
            this.addressTXTbox = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.GenderTXTBox = new System.Windows.Forms.TextBox();
            this.DOBTTXTBox = new System.Windows.Forms.TextBox();
            this.OvedueTXTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 523);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(52, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personal Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_about_me_male_100;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(174, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 128);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // back_button
            // 
            this.back_button.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.back_icon;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(3, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(47, 46);
            this.back_button.TabIndex = 4;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_about_me_female_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.Min;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(653, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(48, 36);
            this.MinimizeBtn.TabIndex = 14;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // Close_button
            // 
            this.Close_button.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_close_window_100;
            this.Close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Location = new System.Drawing.Point(698, 0);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(57, 56);
            this.Close_button.TabIndex = 13;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // PesonalDetailsID
            // 
            this.PesonalDetailsID.AutoSize = true;
            this.PesonalDetailsID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesonalDetailsID.Location = new System.Drawing.Point(359, 88);
            this.PesonalDetailsID.Name = "PesonalDetailsID";
            this.PesonalDetailsID.Size = new System.Drawing.Size(139, 28);
            this.PesonalDetailsID.TabIndex = 15;
            this.PesonalDetailsID.Text = "Member ID";
            // 
            // PersonalDetailsUsername
            // 
            this.PersonalDetailsUsername.AutoSize = true;
            this.PersonalDetailsUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsUsername.Location = new System.Drawing.Point(359, 230);
            this.PersonalDetailsUsername.Name = "PersonalDetailsUsername";
            this.PersonalDetailsUsername.Size = new System.Drawing.Size(131, 28);
            this.PersonalDetailsUsername.TabIndex = 16;
            this.PersonalDetailsUsername.Text = "Username";
            // 
            // PersonalDetailsPassword
            // 
            this.PersonalDetailsPassword.AutoSize = true;
            this.PersonalDetailsPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsPassword.Location = new System.Drawing.Point(362, 277);
            this.PersonalDetailsPassword.Name = "PersonalDetailsPassword";
            this.PersonalDetailsPassword.Size = new System.Drawing.Size(128, 28);
            this.PersonalDetailsPassword.TabIndex = 17;
            this.PersonalDetailsPassword.Text = "Password";
            // 
            // PersonalDetailsGender
            // 
            this.PersonalDetailsGender.AutoSize = true;
            this.PersonalDetailsGender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsGender.Location = new System.Drawing.Point(362, 330);
            this.PersonalDetailsGender.Name = "PersonalDetailsGender";
            this.PersonalDetailsGender.Size = new System.Drawing.Size(99, 28);
            this.PersonalDetailsGender.TabIndex = 18;
            this.PersonalDetailsGender.Text = "Gender";
            // 
            // PersonalDetailsAddress
            // 
            this.PersonalDetailsAddress.AutoSize = true;
            this.PersonalDetailsAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsAddress.Location = new System.Drawing.Point(362, 374);
            this.PersonalDetailsAddress.Name = "PersonalDetailsAddress";
            this.PersonalDetailsAddress.Size = new System.Drawing.Size(110, 28);
            this.PersonalDetailsAddress.TabIndex = 19;
            this.PersonalDetailsAddress.Text = "Address";
            // 
            // PersonalDetailsLname
            // 
            this.PersonalDetailsLname.AutoSize = true;
            this.PersonalDetailsLname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsLname.Location = new System.Drawing.Point(359, 184);
            this.PersonalDetailsLname.Name = "PersonalDetailsLname";
            this.PersonalDetailsLname.Size = new System.Drawing.Size(124, 28);
            this.PersonalDetailsLname.TabIndex = 21;
            this.PersonalDetailsLname.Text = "Lastname";
            // 
            // PersonalDetailsFname
            // 
            this.PersonalDetailsFname.AutoSize = true;
            this.PersonalDetailsFname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsFname.Location = new System.Drawing.Point(359, 133);
            this.PersonalDetailsFname.Name = "PersonalDetailsFname";
            this.PersonalDetailsFname.Size = new System.Drawing.Size(128, 28);
            this.PersonalDetailsFname.TabIndex = 20;
            this.PersonalDetailsFname.Text = "Firstname";
            // 
            // PersonalDetailsDOB
            // 
            this.PersonalDetailsDOB.AutoSize = true;
            this.PersonalDetailsDOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsDOB.Location = new System.Drawing.Point(362, 424);
            this.PersonalDetailsDOB.Name = "PersonalDetailsDOB";
            this.PersonalDetailsDOB.Size = new System.Drawing.Size(157, 28);
            this.PersonalDetailsDOB.TabIndex = 22;
            this.PersonalDetailsDOB.Text = "Date of Birth";
            // 
            // MemberIDTxtBox
            // 
            this.MemberIDTxtBox.Location = new System.Drawing.Point(529, 88);
            this.MemberIDTxtBox.Name = "MemberIDTxtBox";
            this.MemberIDTxtBox.ReadOnly = true;
            this.MemberIDTxtBox.Size = new System.Drawing.Size(201, 20);
            this.MemberIDTxtBox.TabIndex = 23;
            // 
            // fnameTxtBox
            // 
            this.fnameTxtBox.Location = new System.Drawing.Point(529, 133);
            this.fnameTxtBox.Name = "fnameTxtBox";
            this.fnameTxtBox.ReadOnly = true;
            this.fnameTxtBox.Size = new System.Drawing.Size(201, 20);
            this.fnameTxtBox.TabIndex = 24;
            // 
            // LnameTXTBox
            // 
            this.LnameTXTBox.Location = new System.Drawing.Point(529, 184);
            this.LnameTXTBox.Name = "LnameTXTBox";
            this.LnameTXTBox.ReadOnly = true;
            this.LnameTXTBox.Size = new System.Drawing.Size(201, 20);
            this.LnameTXTBox.TabIndex = 25;
            // 
            // UsernameTXTbox
            // 
            this.UsernameTXTbox.Location = new System.Drawing.Point(529, 238);
            this.UsernameTXTbox.Name = "UsernameTXTbox";
            this.UsernameTXTbox.ReadOnly = true;
            this.UsernameTXTbox.Size = new System.Drawing.Size(201, 20);
            this.UsernameTXTbox.TabIndex = 26;
            // 
            // PasswordTXTBox
            // 
            this.PasswordTXTBox.Location = new System.Drawing.Point(529, 285);
            this.PasswordTXTBox.Name = "PasswordTXTBox";
            this.PasswordTXTBox.ReadOnly = true;
            this.PasswordTXTBox.Size = new System.Drawing.Size(201, 20);
            this.PasswordTXTBox.TabIndex = 27;
            this.PasswordTXTBox.UseSystemPasswordChar = true;
            // 
            // addressTXTbox
            // 
            this.addressTXTbox.Location = new System.Drawing.Point(529, 382);
            this.addressTXTbox.Name = "addressTXTbox";
            this.addressTXTbox.ReadOnly = true;
            this.addressTXTbox.Size = new System.Drawing.Size(201, 20);
            this.addressTXTbox.TabIndex = 28;
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(628, 311);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(102, 17);
            this.showpass.TabIndex = 30;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // GenderTXTBox
            // 
            this.GenderTXTBox.Location = new System.Drawing.Point(529, 334);
            this.GenderTXTBox.Name = "GenderTXTBox";
            this.GenderTXTBox.ReadOnly = true;
            this.GenderTXTBox.Size = new System.Drawing.Size(201, 20);
            this.GenderTXTBox.TabIndex = 31;
            // 
            // DOBTTXTBox
            // 
            this.DOBTTXTBox.Location = new System.Drawing.Point(529, 432);
            this.DOBTTXTBox.Name = "DOBTTXTBox";
            this.DOBTTXTBox.ReadOnly = true;
            this.DOBTTXTBox.Size = new System.Drawing.Size(201, 20);
            this.DOBTTXTBox.TabIndex = 32;
            // 
            // OvedueTXTbox
            // 
            this.OvedueTXTbox.Location = new System.Drawing.Point(529, 474);
            this.OvedueTXTbox.Name = "OvedueTXTbox";
            this.OvedueTXTbox.ReadOnly = true;
            this.OvedueTXTbox.Size = new System.Drawing.Size(201, 20);
            this.OvedueTXTbox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Overdue";
            // 
            // MemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 523);
            this.Controls.Add(this.OvedueTXTbox);
            this.Controls.Add(this.DOBTTXTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenderTXTBox);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.addressTXTbox);
            this.Controls.Add(this.PasswordTXTBox);
            this.Controls.Add(this.UsernameTXTbox);
            this.Controls.Add(this.LnameTXTBox);
            this.Controls.Add(this.fnameTxtBox);
            this.Controls.Add(this.MemberIDTxtBox);
            this.Controls.Add(this.PersonalDetailsDOB);
            this.Controls.Add(this.PersonalDetailsLname);
            this.Controls.Add(this.PersonalDetailsFname);
            this.Controls.Add(this.PersonalDetailsAddress);
            this.Controls.Add(this.PersonalDetailsGender);
            this.Controls.Add(this.PersonalDetailsPassword);
            this.Controls.Add(this.PersonalDetailsUsername);
            this.Controls.Add(this.PesonalDetailsID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberDetails";
            this.Load += new System.EventHandler(this.MemberDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PesonalDetailsID;
        private System.Windows.Forms.Label PersonalDetailsUsername;
        private System.Windows.Forms.Label PersonalDetailsPassword;
        private System.Windows.Forms.Label PersonalDetailsGender;
        private System.Windows.Forms.Label PersonalDetailsAddress;
        private System.Windows.Forms.Label PersonalDetailsLname;
        private System.Windows.Forms.Label PersonalDetailsFname;
        private System.Windows.Forms.Label PersonalDetailsDOB;
        private System.Windows.Forms.TextBox MemberIDTxtBox;
        private System.Windows.Forms.TextBox fnameTxtBox;
        private System.Windows.Forms.TextBox LnameTXTBox;
        private System.Windows.Forms.TextBox UsernameTXTbox;
        private System.Windows.Forms.TextBox PasswordTXTBox;
        private System.Windows.Forms.TextBox addressTXTbox;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox GenderTXTBox;
        private System.Windows.Forms.TextBox DOBTTXTBox;
        private System.Windows.Forms.TextBox OvedueTXTbox;
        private System.Windows.Forms.Label label3;
    }
}