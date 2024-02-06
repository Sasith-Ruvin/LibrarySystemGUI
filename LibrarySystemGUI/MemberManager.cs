using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public class MemberManager
    {
        Library library;
        private string connectionString;

        public MemberManager(string connectionString)
        {
            this.connectionString = connectionString;
        }


        //Validating member Login according to username and password
        public bool ValidateMemberLogin(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Members WHERE MemberUsername COLLATE SQL_Latin1_General_CP1_CS_AS=@Username AND MemberPassword=@Password";
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
                MessageBox.Show("Failed to connect to server"+ex.Message,"Connection Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            
        }

        //getting member count from database to create a unique MemberID
        public int GetMembersCount()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TOP 1 MemberID FROM Members ORDER BY MemberID DESC";

                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    if( result != null && result != DBNull.Value )
                    {
                        string latestMemberID = result.ToString();
                        string numericPart = latestMemberID.Substring(3);
                        int latestMember = int.Parse(numericPart);

                        return latestMember;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        //generating an unique member ID
        public string GenerateMemberID()
        {
            int latestMember = GetMembersCount() + 1;
            while(MemberIDExistance("MEM" + latestMember.ToString("000")))
            {
                latestMember++;
            }
            return "MEM" + latestMember.ToString("000");
        }
        //checking for MemberID Existance
        private bool MemberIDExistance(string memberID)
        {
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Members WHERE MemberID = @MemberID";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //checking if entered username in signup process is takrn
        public bool CheckUserNameTaken(string username)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT (*) FROM Members WHERE  MemberUsername=@Username";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }

            }
        }
    }
}
