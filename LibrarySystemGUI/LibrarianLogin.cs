using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrarySystemGUI
{
    public partial class LibrarianLogin : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public LibrarianLogin()
        {
            InitializeComponent();
            AdminUsername_Input.Click += AdminUsername_Input_Click;
            AdminLoginPassword_Input.Click += AdminLoginPassword_Input_Click;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }

        private void AdminClear_Click(object sender, EventArgs e)
        {
            AdminUsername_Input.Clear();
            AdminLoginPassword_Input.Clear();
            ResetLabelFontSizes();
            InvalidInputs.Visible=false;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void ShowPassword_ChckBox_CheckedChanged(object sender, EventArgs e)
        {
            AdminLoginPassword_Input.UseSystemPasswordChar = !ShowPassword_ChckBox.Checked;
        }
        private void Admin_Login_btn_Click_1(object sender, EventArgs e)
        {
            string username = AdminUsername_Input.Text;
            string password = AdminLoginPassword_Input.Text;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (username == "Admin01" && password == "admin01")
                {
                    LibrarianMenu librarianMenu = new LibrarianMenu(username);
                    this.Hide();
                    librarianMenu.Show();

                }
                else
                {
                    LibrarianManager librarianManager = new LibrarianManager(connectionString);
                    bool isValidLogin = librarianManager.ValidateAdminLogin(username, password);

                    if (isValidLogin)
                    {
                        LibrarianMenu librarianMenu = new LibrarianMenu(username);
                        this.Hide();
                        librarianMenu.Show();
                    }
                    else
                    {
                        InvalidInputs.Visible = true;
                    }
                    
                }
                
             
                
            }
            
        }

        private void AdminUsername_Input_Click(object sender, EventArgs e)
        {
            labelAdminUsername.Font = new System.Drawing.Font(labelAdminUsername.Font.FontFamily, 12, labelAdminUsername.Font.Style);
        }

        private void AdminLoginPassword_Input_Click(object sender, EventArgs e)
        {
            labelAdminPassword.Font = new System.Drawing.Font(labelAdminPassword.Font.FontFamily, 12, labelAdminPassword.Font.Style);
        }

        private void ResetLabelFontSizes()
        {
            labelAdminUsername.Font = new System.Drawing.Font(labelAdminUsername.Font.FontFamily, 20, labelAdminUsername.Font.Style);
            labelAdminPassword.Font = new System.Drawing.Font(labelAdminPassword.Font.FontFamily, 20, labelAdminPassword.Font.Style);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            AdminUsername_Input.Click -= AdminUsername_Input_Click;
            AdminLoginPassword_Input.Click -= AdminLoginPassword_Input_Click;
        }

        private void Admin_Login_btn_MouseEnter(object sender, EventArgs e)
        {
            Admin_Login_btn.BackColor = Color.MidnightBlue;
        }

        private void AdminClear_MouseEnter(object sender, EventArgs e)
        {
            AdminClear.BackColor = Color.MidnightBlue;
        }

        private void Admin_Login_btn_MouseLeave(object sender, EventArgs e)
        {
            Admin_Login_btn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void AdminClear_MouseLeave(object sender, EventArgs e)
        {
            AdminClear.BackColor = Color.FromArgb(42, 72, 88);
        }
    }
}
