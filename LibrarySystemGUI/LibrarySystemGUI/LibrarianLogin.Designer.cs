﻿namespace LibrarySystemGUI
{
    partial class LibrarianLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPassword_ChckBox = new System.Windows.Forms.CheckBox();
            this.AdminClear = new System.Windows.Forms.Button();
            this.Admin_Login_btn = new System.Windows.Forms.Button();
            this.AdminLoginPassword_Input = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.AdminUsername_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel1.Size = new System.Drawing.Size(341, 427);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(57, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Librarian Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // ShowPassword_ChckBox
            // 
            this.ShowPassword_ChckBox.AutoSize = true;
            this.ShowPassword_ChckBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword_ChckBox.Location = new System.Drawing.Point(503, 262);
            this.ShowPassword_ChckBox.Name = "ShowPassword_ChckBox";
            this.ShowPassword_ChckBox.Size = new System.Drawing.Size(117, 20);
            this.ShowPassword_ChckBox.TabIndex = 17;
            this.ShowPassword_ChckBox.Text = "Show Password";
            this.ShowPassword_ChckBox.UseVisualStyleBackColor = true;
            this.ShowPassword_ChckBox.CheckedChanged += new System.EventHandler(this.ShowPassword_ChckBox_CheckedChanged);
            // 
            // AdminClear
            // 
            this.AdminClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AdminClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AdminClear.FlatAppearance.BorderSize = 0;
            this.AdminClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AdminClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AdminClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminClear.ForeColor = System.Drawing.Color.White;
            this.AdminClear.Location = new System.Drawing.Point(514, 320);
            this.AdminClear.Name = "AdminClear";
            this.AdminClear.Size = new System.Drawing.Size(106, 39);
            this.AdminClear.TabIndex = 16;
            this.AdminClear.Text = "Clear";
            this.AdminClear.UseVisualStyleBackColor = false;
            this.AdminClear.Click += new System.EventHandler(this.AdminClear_Click);
            // 
            // Admin_Login_btn
            // 
            this.Admin_Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.Admin_Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.Admin_Login_btn.FlatAppearance.BorderSize = 0;
            this.Admin_Login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.Admin_Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.Admin_Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin_Login_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Login_btn.ForeColor = System.Drawing.Color.White;
            this.Admin_Login_btn.Location = new System.Drawing.Point(359, 320);
            this.Admin_Login_btn.Name = "Admin_Login_btn";
            this.Admin_Login_btn.Size = new System.Drawing.Size(106, 39);
            this.Admin_Login_btn.TabIndex = 15;
            this.Admin_Login_btn.Text = "Log In";
            this.Admin_Login_btn.UseVisualStyleBackColor = false;
            this.Admin_Login_btn.Click += new System.EventHandler(this.Admin_Login_btn_Click_1);
            // 
            // AdminLoginPassword_Input
            // 
            this.AdminLoginPassword_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLoginPassword_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginPassword_Input.Location = new System.Drawing.Point(359, 230);
            this.AdminLoginPassword_Input.Name = "AdminLoginPassword_Input";
            this.AdminLoginPassword_Input.Size = new System.Drawing.Size(261, 26);
            this.AdminLoginPassword_Input.TabIndex = 14;
            this.AdminLoginPassword_Input.UseSystemPasswordChar = true;
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPassword.Location = new System.Drawing.Point(351, 194);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(107, 24);
            this.UserPassword.TabIndex = 13;
            this.UserPassword.Text = "Password";
            this.UserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminUsername_Input
            // 
            this.AdminUsername_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminUsername_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUsername_Input.Location = new System.Drawing.Point(359, 138);
            this.AdminUsername_Input.Name = "AdminUsername_Input";
            this.AdminUsername_Input.Size = new System.Drawing.Size(261, 26);
            this.AdminUsername_Input.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.Min;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(557, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(48, 36);
            this.MinimizeBtn.TabIndex = 18;
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
            this.Close_button.Location = new System.Drawing.Point(602, 0);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(57, 56);
            this.Close_button.TabIndex = 7;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_system_administrator_female_100;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(166, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 152);
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
            this.pictureBox1.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.admin_Male;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 152);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LibrarianLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 427);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.ShowPassword_ChckBox);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.AdminClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Admin_Login_btn);
            this.Controls.Add(this.AdminUsername_Input);
            this.Controls.Add(this.AdminLoginPassword_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrarianLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.CheckBox ShowPassword_ChckBox;
        private System.Windows.Forms.Button AdminClear;
        private System.Windows.Forms.Button Admin_Login_btn;
        private System.Windows.Forms.TextBox AdminLoginPassword_Input;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.TextBox AdminUsername_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MinimizeBtn;
    }
}