using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class LibrarianLogin : Form
    {
        public LibrarianLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void ShowPassword_ChckBox_CheckedChanged(object sender, EventArgs e)
        {
            AdminLoginPassword_Input.UseSystemPasswordChar = !ShowPassword_ChckBox.Checked;
        }

        private void Admin_Login_btn_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Login_btn_Click_1(object sender, EventArgs e)
        {
            if(AdminUsername_Input.Text =="" || AdminLoginPassword_Input.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string enteredUsername = AdminUsername_Input.Text;
                string enteredPassword = AdminLoginPassword_Input.Text;
                string connectionString = "Data Source=HP-PAVILLION-15\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Librarians WHERE AdminUsername = @Username AND AdminPassword = @Password";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", enteredUsername);
                        command.Parameters.AddWithValue("@Password", enteredPassword);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                           if(reader.Read())
                            {
                                LibrarianMenu librarianMenu = new LibrarianMenu();
                                this.Hide();
                                librarianMenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
            }

            
        }
    }
}
