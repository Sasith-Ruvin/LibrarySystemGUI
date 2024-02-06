namespace LibrarySystemGUI
{
    partial class AddBookForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBookID_Input = new System.Windows.Forms.TextBox();
            this.AddBookTitle_Input = new System.Windows.Forms.TextBox();
            this.AddBookAuthor_Input = new System.Windows.Forms.TextBox();
            this.AddBookISBN_Input = new System.Windows.Forms.TextBox();
            this.BookAddClear = new System.Windows.Forms.Button();
            this.AddBook_Btn = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(341, 450);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(94, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Books";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_add_1001;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(197, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
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
            this.pictureBox1.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.book;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(100, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 152);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 74);
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
            this.MinimizeBtn.Location = new System.Drawing.Point(600, 10);
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
            this.Close_button.Location = new System.Drawing.Point(645, -2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(57, 56);
            this.Close_button.TabIndex = 20;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "BookID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "ISBN";
            // 
            // AddBookID_Input
            // 
            this.AddBookID_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddBookID_Input.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookID_Input.Location = new System.Drawing.Point(445, 114);
            this.AddBookID_Input.Name = "AddBookID_Input";
            this.AddBookID_Input.Size = new System.Drawing.Size(221, 27);
            this.AddBookID_Input.TabIndex = 26;
            // 
            // AddBookTitle_Input
            // 
            this.AddBookTitle_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddBookTitle_Input.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookTitle_Input.Location = new System.Drawing.Point(446, 177);
            this.AddBookTitle_Input.Name = "AddBookTitle_Input";
            this.AddBookTitle_Input.Size = new System.Drawing.Size(221, 27);
            this.AddBookTitle_Input.TabIndex = 27;
            // 
            // AddBookAuthor_Input
            // 
            this.AddBookAuthor_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddBookAuthor_Input.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookAuthor_Input.Location = new System.Drawing.Point(445, 238);
            this.AddBookAuthor_Input.Name = "AddBookAuthor_Input";
            this.AddBookAuthor_Input.Size = new System.Drawing.Size(221, 27);
            this.AddBookAuthor_Input.TabIndex = 28;
            // 
            // AddBookISBN_Input
            // 
            this.AddBookISBN_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddBookISBN_Input.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookISBN_Input.Location = new System.Drawing.Point(446, 291);
            this.AddBookISBN_Input.Name = "AddBookISBN_Input";
            this.AddBookISBN_Input.Size = new System.Drawing.Size(221, 27);
            this.AddBookISBN_Input.TabIndex = 29;
            // 
            // BookAddClear
            // 
            this.BookAddClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.BookAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookAddClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.BookAddClear.FlatAppearance.BorderSize = 0;
            this.BookAddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookAddClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAddClear.ForeColor = System.Drawing.Color.White;
            this.BookAddClear.Location = new System.Drawing.Point(561, 345);
            this.BookAddClear.Name = "BookAddClear";
            this.BookAddClear.Size = new System.Drawing.Size(106, 39);
            this.BookAddClear.TabIndex = 31;
            this.BookAddClear.Text = "Clear";
            this.BookAddClear.UseVisualStyleBackColor = false;
            this.BookAddClear.Click += new System.EventHandler(this.BookAddClear_Click);
            this.BookAddClear.MouseEnter += new System.EventHandler(this.BookAddClear_MouseEnter);
            this.BookAddClear.MouseLeave += new System.EventHandler(this.BookAddClear_MouseLeave);
            // 
            // AddBook_Btn
            // 
            this.AddBook_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AddBook_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBook_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.AddBook_Btn.FlatAppearance.BorderSize = 0;
            this.AddBook_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook_Btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_Btn.ForeColor = System.Drawing.Color.White;
            this.AddBook_Btn.Location = new System.Drawing.Point(376, 345);
            this.AddBook_Btn.Name = "AddBook_Btn";
            this.AddBook_Btn.Size = new System.Drawing.Size(106, 39);
            this.AddBook_Btn.TabIndex = 30;
            this.AddBook_Btn.Text = "Add";
            this.AddBook_Btn.UseVisualStyleBackColor = false;
            this.AddBook_Btn.Click += new System.EventHandler(this.AddBook_Btn_Click);
            this.AddBook_Btn.MouseEnter += new System.EventHandler(this.AddBook_Btn_MouseEnter);
            this.AddBook_Btn.MouseLeave += new System.EventHandler(this.AddBook_Btn_MouseLeave);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.BookAddClear);
            this.Controls.Add(this.AddBook_Btn);
            this.Controls.Add(this.AddBookISBN_Input);
            this.Controls.Add(this.AddBookAuthor_Input);
            this.Controls.Add(this.AddBookTitle_Input);
            this.Controls.Add(this.AddBookID_Input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddBookID_Input;
        private System.Windows.Forms.TextBox AddBookTitle_Input;
        private System.Windows.Forms.TextBox AddBookAuthor_Input;
        private System.Windows.Forms.TextBox AddBookISBN_Input;
        private System.Windows.Forms.Button BookAddClear;
        private System.Windows.Forms.Button AddBook_Btn;
    }
}