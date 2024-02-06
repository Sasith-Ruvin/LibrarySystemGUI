using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class MemberLogin : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        Library library;
        public MemberLogin()
        {
            InitializeComponent();
            Username_Input.Click += Username_Input_Click;
            LoginPassword_Input.Click += LoginPassword_Input_Click;
        } 
        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MemberLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberSignUp memberSignUp = new MemberSignUp();
            this.Hide();
            memberSignUp.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void ShowPassword_ChckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginPassword_Input.UseSystemPasswordChar = !ShowPassword_ChckBox.Checked;
        }
        private void Member_Login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username_Input.Text) || string.IsNullOrEmpty(LoginPassword_Input.Text))
            {
                MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = Username_Input.Text;
                string password = LoginPassword_Input.Text;
              
                MemberManager memberManager = new MemberManager(connectionString);
                bool isValidLogin = memberManager.ValidateMemberLogin(username, password);

                if (isValidLogin)
                {
                    MemberMenu memberMenu = new MemberMenu(username);
                    memberMenu.Show();
                    this.Hide();
                }
                else
                {
                    invalidInput.Visible = true;
                }
            }

        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void MemLoginClearBtn_Click(object sender, EventArgs e)
        {
            Username_Input.Clear();
            LoginPassword_Input.Clear();
            invalidInput.Visible = false;
            ResetLabelFontsSize();
        }

        private void Username_Input_Click(object sender, EventArgs e)
        {
            labelusername.Font = new System.Drawing.Font(labelusername.Font.FontFamily, 15, labelusername.Font.Style);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Username_Input.Click -= Username_Input_Click;
            LoginPassword_Input.Click -= LoginPassword_Input_Click;
        }

        private void LoginPassword_Input_Click(object sender, EventArgs e)
        {
            UserPassword.Font = new System.Drawing.Font(UserPassword.Font.FontFamily, 15, UserPassword.Font.Style);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 150, 149);
            button1.ForeColor = Color.White;
        }

        private void MemLoginClearBtn_MouseEnter(object sender, EventArgs e)
        {
            MemLoginClearBtn.BackColor = Color.FromArgb(14, 27, 143);
        }

        private void MemLoginClearBtn_MouseLeave(object sender, EventArgs e)
        {
            MemLoginClearBtn.BackColor = Color.FromArgb(42, 72, 88);
        }

        private void ResetLabelFontsSize()
        {
            labelusername.Font = new System.Drawing.Font(labelusername.Font.FontFamily,20, labelusername.Font.Style);
            UserPassword.Font = new System.Drawing.Font(UserPassword.Font.FontFamily,20, UserPassword.Font.Style);
        }

        private void ShowPassword_ChckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            LoginPassword_Input.UseSystemPasswordChar = !ShowPassword_ChckBox.Checked;
        }
    }
}
