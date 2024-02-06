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
    public partial class MemberLogin : Form
    {
        public MemberLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Username_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
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
            if(string.IsNullOrEmpty(Username_Input.Text) || string.IsNullOrEmpty(LoginPassword_Input.Text))
            {
                MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = Username_Input.Text;
                string password = LoginPassword_Input.Text;
                string connectionString = "Data Source=HP-PAVILLION-15\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Members WHERE MemberUsername = @Username AND MemberPassword = @Password";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MemberMenu memberMenu = new MemberMenu();
                                this.Hide();
                                memberMenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password. Please Try Again","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MemLoginClearBtn_Click(object sender, EventArgs e)
        {
            Username_Input.Clear();
            LoginPassword_Input.Clear();
        }
    }
}
