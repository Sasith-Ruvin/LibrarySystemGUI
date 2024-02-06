using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemGUI
{
    public class Library
    {
        public List<Book> AvailableBooks { get; set; }
        public List<Member> Members { get; set; }
        public List<Librarian> Librarians { get; set; }


        public Library()
        {
            AvailableBooks = LoadBooksFromDatabase();
            Members = LoadMembersFromDB();
            Librarians = new List<Librarian>();

        }

        public List<Book> LoadBooksFromDatabase()
        {
            List<Book> books = new List<Book>();
            string connectionString = "Data Source=HP-PAVILLION-15\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Book", connect);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int isbn;
                    if (int.TryParse(reader["ISBN"].ToString(), out isbn))
                    {
                        Book book = new Book(reader["BookID"].ToString(), reader["Title"].ToString(), reader["Author"].ToString(), isbn);
                        books.Add(book);
                    }
                }
            }
            return books;
        }

        public List<Member> LoadMembersFromDB()
        {
            List<Member> members = new List<Member>();
            string connectionString = "Data Source=HP-PAVILLION-15\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
            using(SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Members", connect);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Member member = new Member(reader["MemberID"].ToString(), reader["MemberUsername"].ToString(), reader["MemberPassword"].ToString(), Convert.ToDouble(reader["Overdue"].ToString()), reader["Firstname"].ToString(), reader["Lastname"].ToString(), reader["Gender"].ToString(), reader["MemAddress"].ToString(), Convert.ToDateTime(reader["DateofBirth"].ToString()));
                    members.Add(member);
                }
            }
            return members;

        }

        public DataTable LoadMemberDetailsFromDatabaseToTable()
        {
            DataTable membersTable = new DataTable();
            string connectionString = "Data Source=HP-PAVILLION-15\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT MemberID, Firstname, Lastname, Gender, MemAddress, DateofBirth FROM Members", connect);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                membersTable.Load(reader);
            }
            return membersTable;
        }


    }
}
