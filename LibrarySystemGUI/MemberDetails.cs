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
    public partial class MemberDetails : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string loggedInuser;
        public MemberDetails(string username)
        {
            InitializeComponent();
            this.loggedInuser = username;
            LoadMemberDetails();
        }

        private void MemberDetails_Load(object sender, EventArgs e)
        {

        }

        private void LoadMemberDetails()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Members WHERE MemberUsername = @Username";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", loggedInuser);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            MemberIDTxtBox.Text = reader["MemberID"].ToString();
                            UsernameTXTbox.Text = reader["MemberUsername"].ToString();
                            PasswordTXTBox.Text = reader["MemberPassword"].ToString();
                            fnameTxtBox.Text = reader["Firstname"].ToString();
                            LnameTXTBox.Text = reader["Lastname"].ToString() ;
                            GenderTXTBox.Text = reader["Gender"].ToString();
                            addressTXTbox.Text = reader["MemAddress"].ToString();
                            DOBTTXTBox.Text = reader["DateofBirth"].ToString();
                            OvedueTXTbox.Text = reader["Overdue"].ToString();

                        }
                    }

                }
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MemberMenu memberMenu = new MemberMenu(loggedInuser);
            memberMenu.Show();
            this.Close();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTXTBox.UseSystemPasswordChar = !showpass.Checked;
        }
    }
}
