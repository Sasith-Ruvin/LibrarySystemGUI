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
    public partial class AdminDetails : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string loggedInUser;
        public AdminDetails(string username)
        {
            InitializeComponent();
            this.loggedInUser = username;
            LoadAdminDetails();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void LoadAdminDetails()
        {
            using(SqlConnection  conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Librarians WHERE AdminUsername = @Username";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", loggedInUser);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            StaffIDTxtBox.Text = reader["StaffID"].ToString();
                            fnameTxtBox.Text = reader["Firstname"].ToString();
                            LnameTXTBox.Text = reader["Lastname"].ToString();
                            UsernameTXTbox.Text = reader["AdminUsername"].ToString();
                            PasswordTXTBox.Text = reader["AdminPassword"].ToString();
                            GenderTXTBox.Text = reader["Gender"].ToString();
                            addressTXTbox.Text = reader["AdminAddress"].ToString();
                            DateTime dob = Convert.ToDateTime(reader["DateofBirth"]);
                            DOBTTXTBox.Text = dob.ToShortDateString();
                            SalaryTXTbox.Text = reader["Salary"].ToString();
                            DateTime dateJoined = Convert.ToDateTime(reader["DateJoined"]);
                            DateJoinedTXT.Text = dateJoined.ToShortDateString();
                        }
                    }
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            LibrarianMenu librarianMenu = new LibrarianMenu(loggedInUser);
            this.Close();
            librarianMenu.Show();
        }
    }
}
