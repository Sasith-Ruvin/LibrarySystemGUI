namespace LibrarySystemGUI
{
    partial class MemberMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MemberLogoutBtn = new System.Windows.Forms.Button();
            this.CheckOverdueBtn = new System.Windows.Forms.Button();
            this.BorrowBookBtn = new System.Windows.Forms.Button();
            this.MemDisplayLoanBtn = new System.Windows.Forms.Button();
            this.MemDisplayBooksBtn = new System.Windows.Forms.Button();
            this.MemberDetailsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.back_button);
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 139);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(179, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_library_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(266, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 57);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(191, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Member Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_button
            // 
            this.back_button.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.back_icon;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(0, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(47, 46);
            this.back_button.TabIndex = 19;
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.Min;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(506, 13);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(48, 36);
            this.MinimizeBtn.TabIndex = 21;
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
            this.Close_button.Location = new System.Drawing.Point(550, -2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(57, 56);
            this.Close_button.TabIndex = 20;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Your Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(223, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Display Books";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(408, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Personal Loans";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Borrow Book";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(210, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Check Overdue";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(438, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Log Out";
            // 
            // MemberLogoutBtn
            // 
            this.MemberLogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.MemberLogoutBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_log_out_100;
            this.MemberLogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MemberLogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemberLogoutBtn.FlatAppearance.BorderSize = 0;
            this.MemberLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberLogoutBtn.Location = new System.Drawing.Point(428, 299);
            this.MemberLogoutBtn.Name = "MemberLogoutBtn";
            this.MemberLogoutBtn.Size = new System.Drawing.Size(112, 113);
            this.MemberLogoutBtn.TabIndex = 6;
            this.MemberLogoutBtn.UseVisualStyleBackColor = false;
            this.MemberLogoutBtn.Click += new System.EventHandler(this.MemberLogoutBtn_Click);
            // 
            // CheckOverdueBtn
            // 
            this.CheckOverdueBtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckOverdueBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_payment_100;
            this.CheckOverdueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckOverdueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOverdueBtn.FlatAppearance.BorderSize = 0;
            this.CheckOverdueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOverdueBtn.Location = new System.Drawing.Point(239, 299);
            this.CheckOverdueBtn.Name = "CheckOverdueBtn";
            this.CheckOverdueBtn.Size = new System.Drawing.Size(112, 113);
            this.CheckOverdueBtn.TabIndex = 5;
            this.CheckOverdueBtn.UseVisualStyleBackColor = false;
            // 
            // BorrowBookBtn
            // 
            this.BorrowBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.BorrowBookBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_books_100;
            this.BorrowBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorrowBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrowBookBtn.FlatAppearance.BorderSize = 0;
            this.BorrowBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowBookBtn.Location = new System.Drawing.Point(41, 299);
            this.BorrowBookBtn.Name = "BorrowBookBtn";
            this.BorrowBookBtn.Size = new System.Drawing.Size(112, 113);
            this.BorrowBookBtn.TabIndex = 4;
            this.BorrowBookBtn.UseVisualStyleBackColor = false;
            // 
            // MemDisplayLoanBtn
            // 
            this.MemDisplayLoanBtn.BackColor = System.Drawing.Color.Transparent;
            this.MemDisplayLoanBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_bookmark_100;
            this.MemDisplayLoanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MemDisplayLoanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemDisplayLoanBtn.FlatAppearance.BorderSize = 0;
            this.MemDisplayLoanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemDisplayLoanBtn.Location = new System.Drawing.Point(428, 145);
            this.MemDisplayLoanBtn.Name = "MemDisplayLoanBtn";
            this.MemDisplayLoanBtn.Size = new System.Drawing.Size(112, 113);
            this.MemDisplayLoanBtn.TabIndex = 3;
            this.MemDisplayLoanBtn.UseVisualStyleBackColor = false;
            // 
            // MemDisplayBooksBtn
            // 
            this.MemDisplayBooksBtn.BackColor = System.Drawing.Color.Transparent;
            this.MemDisplayBooksBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.library_books;
            this.MemDisplayBooksBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MemDisplayBooksBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemDisplayBooksBtn.FlatAppearance.BorderSize = 0;
            this.MemDisplayBooksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemDisplayBooksBtn.Location = new System.Drawing.Point(239, 145);
            this.MemDisplayBooksBtn.Name = "MemDisplayBooksBtn";
            this.MemDisplayBooksBtn.Size = new System.Drawing.Size(112, 113);
            this.MemDisplayBooksBtn.TabIndex = 2;
            this.MemDisplayBooksBtn.UseVisualStyleBackColor = false;
            this.MemDisplayBooksBtn.Click += new System.EventHandler(this.MemDisplayBooksBtn_Click);
            // 
            // MemberDetailsBtn
            // 
            this.MemberDetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.MemberDetailsBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_info_100;
            this.MemberDetailsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MemberDetailsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemberDetailsBtn.FlatAppearance.BorderSize = 0;
            this.MemberDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberDetailsBtn.Location = new System.Drawing.Point(41, 145);
            this.MemberDetailsBtn.Name = "MemberDetailsBtn";
            this.MemberDetailsBtn.Size = new System.Drawing.Size(112, 113);
            this.MemberDetailsBtn.TabIndex = 1;
            this.MemberDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // MemberMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MemberLogoutBtn);
            this.Controls.Add(this.CheckOverdueBtn);
            this.Controls.Add(this.BorrowBookBtn);
            this.Controls.Add(this.MemDisplayLoanBtn);
            this.Controls.Add(this.MemDisplayBooksBtn);
            this.Controls.Add(this.MemberDetailsBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberMenu";
            this.Load += new System.EventHandler(this.MemberMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MemberDetailsBtn;
        private System.Windows.Forms.Button MemDisplayBooksBtn;
        private System.Windows.Forms.Button MemDisplayLoanBtn;
        private System.Windows.Forms.Button BorrowBookBtn;
        private System.Windows.Forms.Button CheckOverdueBtn;
        private System.Windows.Forms.Button MemberLogoutBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}