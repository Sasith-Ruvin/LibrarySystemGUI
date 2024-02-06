namespace LibrarySystemGUI
{
    partial class DisplayBooks
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
            this.BookCloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookMinBtn = new System.Windows.Forms.Button();
            this.BookBackBtn = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 131);
            this.panel1.TabIndex = 0;
            // 
            // BookCloseBtn
            // 
            this.BookCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookCloseBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_close_window_100;
            this.BookCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookCloseBtn.FlatAppearance.BorderSize = 0;
            this.BookCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookCloseBtn.Location = new System.Drawing.Point(746, 0);
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
            this.label2.Location = new System.Drawing.Point(288, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.icons8_library_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(377, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 57);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(310, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Library Books";
            // 
            // BookMinBtn
            // 
            this.BookMinBtn.BackColor = System.Drawing.Color.Transparent;
            this.BookMinBtn.BackgroundImage = global::LibrarySystemGUI.Properties.Resources.Min;
            this.BookMinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BookMinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookMinBtn.FlatAppearance.BorderSize = 0;
            this.BookMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookMinBtn.Location = new System.Drawing.Point(700, 6);
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
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(17, 156);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(748, 233);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewBooks_CellFormatting);
            this.dataGridViewBooks.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewBooks_CellPainting);
            // 
            // DisplayBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayBooks";
            this.Load += new System.EventHandler(this.DisplayBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BookMinBtn;
        private System.Windows.Forms.Button BookBackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button BookCloseBtn;
    }
}