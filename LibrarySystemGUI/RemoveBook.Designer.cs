namespace LibrarySystemGUI
{
    partial class RemoveBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookCloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookMinBtn = new System.Windows.Forms.Button();
            this.BookBackBtn = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RemoveBookBtn = new System.Windows.Forms.Button();
            this.removeBookID_Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emptyInput = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(278, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Remove Books";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.BookCloseBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BookMinBtn);
            this.panel1.Controls.Add(this.BookBackBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 131);
            this.panel1.TabIndex = 1;
            // 
            // BookCloseBtn
            // 
            this.BookCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookCloseBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_close_window_100;
            this.BookCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookCloseBtn.FlatAppearance.BorderSize = 0;
            this.BookCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookCloseBtn.Location = new System.Drawing.Point(683, 3);
            this.BookCloseBtn.Name = "BookCloseBtn";
            this.BookCloseBtn.Size = new System.Drawing.Size(54, 51);
            this.BookCloseBtn.TabIndex = 27;
            this.BookCloseBtn.UseVisualStyleBackColor = false;
            this.BookCloseBtn.Click += new System.EventHandler(this.BookCloseBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(256, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_remove_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(345, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 57);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // BookMinBtn
            // 
            this.BookMinBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookMinBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.Min;
            this.BookMinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookMinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookMinBtn.FlatAppearance.BorderSize = 0;
            this.BookMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookMinBtn.Location = new System.Drawing.Point(637, 9);
            this.BookMinBtn.Name = "BookMinBtn";
            this.BookMinBtn.Size = new System.Drawing.Size(50, 44);
            this.BookMinBtn.TabIndex = 2;
            this.BookMinBtn.UseVisualStyleBackColor = false;
            this.BookMinBtn.Click += new System.EventHandler(this.BookMinBtn_Click);
            // 
            // BookBackBtn
            // 
            this.BookBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookBackBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.back_icon;
            this.BookBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookBackBtn.FlatAppearance.BorderSize = 0;
            this.BookBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookBackBtn.Location = new System.Drawing.Point(3, 0);
            this.BookBackBtn.Name = "BookBackBtn";
            this.BookBackBtn.Size = new System.Drawing.Size(50, 44);
            this.BookBackBtn.TabIndex = 1;
            this.BookBackBtn.UseVisualStyleBackColor = false;
            this.BookBackBtn.Click += new System.EventHandler(this.BookBackBtn_Click);
            // 
            // dataGridViewBooks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBooks.Location = new System.Drawing.Point(33, 192);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(666, 181);
            this.dataGridViewBooks.TabIndex = 2;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            this.dataGridViewBooks.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewBooks_DataBindingComplete);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(443, 433);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(106, 39);
            this.ClearBtn.TabIndex = 30;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            this.ClearBtn.MouseEnter += new System.EventHandler(this.ClearBtn_MouseEnter);
            this.ClearBtn.MouseLeave += new System.EventHandler(this.ClearBtn_MouseLeave);
            // 
            // RemoveBookBtn
            // 
            this.RemoveBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.RemoveBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.RemoveBookBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBookBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBookBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBookBtn.Location = new System.Drawing.Point(260, 433);
            this.RemoveBookBtn.Name = "RemoveBookBtn";
            this.RemoveBookBtn.Size = new System.Drawing.Size(106, 39);
            this.RemoveBookBtn.TabIndex = 29;
            this.RemoveBookBtn.Text = "Remove";
            this.RemoveBookBtn.UseVisualStyleBackColor = false;
            this.RemoveBookBtn.Click += new System.EventHandler(this.RemoveBookBtn_Click);
            this.RemoveBookBtn.MouseEnter += new System.EventHandler(this.RemoveBookBtn_MouseEnter);
            this.RemoveBookBtn.MouseLeave += new System.EventHandler(this.RemoveBookBtn_MouseLeave);
            // 
            // removeBookID_Input
            // 
            this.removeBookID_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeBookID_Input.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookID_Input.Location = new System.Drawing.Point(323, 379);
            this.removeBookID_Input.Name = "removeBookID_Input";
            this.removeBookID_Input.Size = new System.Drawing.Size(208, 30);
            this.removeBookID_Input.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Enter BookID";
            // 
            // emptyInput
            // 
            this.emptyInput.AutoSize = true;
            this.emptyInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyInput.ForeColor = System.Drawing.Color.Red;
            this.emptyInput.Location = new System.Drawing.Point(298, 173);
            this.emptyInput.Name = "emptyInput";
            this.emptyInput.Size = new System.Drawing.Size(195, 16);
            this.emptyInput.TabIndex = 35;
            this.emptyInput.Text = "Enter Book a Title to Search";
            this.emptyInput.Visible = false;
            // 
            // titleInput
            // 
            this.titleInput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleInput.Location = new System.Drawing.Point(301, 140);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(208, 30);
            this.titleInput.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Book Title Serach";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_refresh_100;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(677, 133);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(48, 49);
            this.refreshBtn.TabIndex = 36;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_search_100;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(515, 130);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(55, 52);
            this.SearchBtn.TabIndex = 34;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 501);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.emptyInput);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RemoveBookBtn);
            this.Controls.Add(this.removeBookID_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveBook";
            this.Load += new System.EventHandler(this.RemoveBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BookCloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BookMinBtn;
        private System.Windows.Forms.Button BookBackBtn;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RemoveBookBtn;
        private System.Windows.Forms.TextBox removeBookID_Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emptyInput;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshBtn;
    }
}