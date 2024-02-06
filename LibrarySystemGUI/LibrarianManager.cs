using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public class LibrarianManager
    {
        private string connectionString;

        public LibrarianManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Validating Login according to username and password
       public bool ValidateAdminLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Librarians WHERE AdminUsername COLLATE SQL_Latin1_General_CP1_CS_AS=@Username AND AdminPassword=@Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.Read();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message,"Connection Failed",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
    }
}
