using LibrarySystemGUI;
using System;
using System.Data.SqlClient;
using Xunit;
namespace GUI_TESTS
{
    public class UnitTest1
    {
        string connectionString = "Data Source=HP-PAVILLION-15\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";

        [Fact]
        public void Test_Validate_MemberLogin()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                InsertTestMember(conn, "testUsername", "testpassword");
            }
            MemberManager memberManager = new MemberManager(connectionString);

            bool isValidLogin = memberManager.ValidateMemberLogin("testUsername", "testpassword");

            Assert.True(isValidLogin);

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DeleteTestMember(connection, "testUsername");
            }
            
        }

        private void InsertTestMember(SqlConnection connection, string username, string password)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Members (MemberUsername, MemberPassword) VALUES (@Username, @Password)", connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteTestMember(SqlConnection connection, string username)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Members WHERE MemberUsername = @Username", connection))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
            }
        }
    }
}