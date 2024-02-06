using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystemGUI
{
    public class Library
    {
        public List<Book> AvailableBooks { get; set; }
        public List<Member> Members { get; set; }
        public List<Librarian> Librarians { get; set; }

        public List<Loan> Loans { get; set; }

        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Library()
        {
            AvailableBooks = LoadBooksFromDatabase();
            Members = LoadMembersFromDB();
            Librarians = new List<Librarian>();
            Loans = LoadLoansFromDatabse();

        }
        //Method to get Member's Personal Loans
        public List<Loan>GetMemberLoans(string memberID)
        {
            return Loans.Where(ploan=>ploan.MemberID == memberID).ToList();
        }
        //Method to Load Book from database and set them in Book List
        public List<Book> LoadBooksFromDatabase()
        {
            List<Book> books = new List<Book>();
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Book", connect);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Book book = new Book(reader["BookID"].ToString(), reader["Title"].ToString(), reader["Author"].ToString(), Convert.ToInt64(reader["ISBN"].ToString()))
                        {
                            Availability = reader["BookStatus"].ToString()
                        };
                        books.Add(book);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Failed to Connect to Server"+ex.Message,"Connection Fail",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return books;
        }
        //Method to Load Loans from Database and set them in Loan List
        public List<Loan> LoadLoansFromDatabse()
        {
            List<Loan> loans = new List<Loan>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Loans";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Loan loan = new Loan(reader["LoanID"].ToString(), reader["MemberID"].ToString(), reader["Name"].ToString(), reader["BookID"].ToString(), reader["Title"].ToString(), Convert.ToDateTime(reader["IssuedDate"].ToString()), Convert.ToDateTime(reader["DueDate"].ToString()));
                            loans.Add(loan);
                        }
                    }

                }
            }
            catch( Exception ex )
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loans;
        }

        //Method to Load Members from Database and set them in Member List
        public List<Member> LoadMembersFromDB()
        {
            List<Member> members = new List<Member>();
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
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
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return members;
        }
        //Loading Loans to a Datatable
        public DataTable LoadLoansIntoTAble()
        {
            DataTable loans = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT LoanID, MemberID, Name, BookID, Title, IssuedDate, DueDate FROM Loans";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        loans.Load(reader);
                    }
                }
            }
            catch( Exception ex )
            {
              MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loans;
        }     
        //Loading Member's Personal Loans to  Datatable
        public DataTable LoadMemberLoansIntoTable(string memberID)
        {
            DataTable loansTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT LoanID, MemberID, Name, BookID, Title, IssuedDate, DueDate FROM Loans WHERE MemberID = @MemberID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        sqlCommand.Parameters.AddWithValue("@MemberID", memberID);
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        loansTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server: " + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loansTable;
        }
        //Method to load Member detail from database into a DataTable to be used in Display Members form
        public DataTable LoadMemberDetailsFromDatabaseToTable()
        {
            DataTable membersTable = new DataTable();
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT MemberID, Firstname, Lastname, Gender, MemAddress, DateofBirth FROM Members", connect);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    membersTable.Load(reader);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return membersTable;
        }
        //Loading Books from database into a Datatable
        public DataTable LoadBooksFromDatabaseToTable()
        {
            DataTable booksTable = new DataTable();
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    SqlCommand sqlCommand = new SqlCommand("SELECT BookID, Title, Author, ISBN, BookStatus FROM Book", connect);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    booksTable.Load(reader);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return booksTable;
        }
        //Method to remove a book from database when book is removed in Remove Book form
        public bool RemoveBookfromDatabasae(string bookID)
        {
            try
            {
                string deletequery = "DELETE FROM  Book WHERE BookID = @BookID";
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(deletequery, connect))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Server" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Method to remove member from database
        public bool RemoveMembersFromDB(string memberID)
        {
            string delquery = "DELETE FROM Members WHERE MemberID = @MemberID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(delquery, connection))
                {
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        //Updaating Book Availability status when Book is borrowed and returned
        public  void UpdateBookStatus(Book book)
        {
            string query = "UPDATE Book SET BookStatus = @BookStatus WHERE BookID = @BookID AND Title = @Title";
            using( SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open() ;
                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@BookID", book.BookID);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@BookStatus", book.Availability);
                    cmd.ExecuteNonQuery();
                }
            }
            Book updatedBook = AvailableBooks.Find(b => b.BookID == book.BookID);
            if (updatedBook != null)
            {
                updatedBook.Availability = book.Availability;
            }
        }
        //Adding Loan to  Database when a Book is borrowed
        public void AddLoanToDatabase(Loan loan)
        {
            string query = "INSERT INTO Loans (LoanID, MemberID, Name, BookID, Title, IssuedDate, DueDate)" +
                "VALUES (@LoanID, @MemberID, @Name, @BookID, @Title, @IssuedDate, @DueDate)";

            using( SqlConnection connection = new SqlConnection(connectionString) )
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanID", loan.LoanID);
                    command.Parameters.AddWithValue("@MemberID", loan.MemberID);
                    command.Parameters.AddWithValue("@Name", loan.Name);
                    command.Parameters.AddWithValue("@BookID", loan.BookID);
                    command.Parameters.AddWithValue("@Title", loan.Title);
                    command.Parameters.AddWithValue("@IssuedDate", loan.IsuueDate);
                    command.Parameters.AddWithValue("@DueDate", loan.DueDate);

                    command.ExecuteNonQuery();
                }
            }
        }
        //Removing Loan from Loan Table in Database when Book is returned
        public void RemoveLoansFromDatabase(string bookID)
        {
            string deletequery = "DELETE FROM Loans WHERE BookID = @BookID";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(deletequery, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.ExecuteNonQuery();
                }
            }
        }
        //Updating Member's overdue when a book returned and when Overdue is paid
        public void UpdateMemberOverdue(string memberID, double overdue)
        {
            string query = "UPDATE Members SET Overdue = @Overdue WHERE MemberID = @MemberID";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Overdue", overdue);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Getting members Overdue Amounts from database with respect to username to be used in Member Menu
        public double GetMemberOverdue(string username)
        {
            Member currentMember = Members.Find(m => m.GetCredentials() == username);

            if (currentMember != null)
            {
                return currentMember.Overdue;
            }
            return 0;
        }

        //Getting Mmmber Overdue according to memeber ID to used in Overdue Calculations
        public double GetMemberIDOverdue(string memberID)
        {
            Member currentMember = Members.FirstOrDefault(m => m.MemberID == memberID);

            if (currentMember != null)
            {
                return currentMember.Overdue;
            }
            return 0;
        }
        //reducing Member's overdue when amount is paid
        public bool ReduceMemberOverdue(string memberID, double payment)
        {
            double overdueAmount = GetMemberIDOverdue(memberID);
            if (overdueAmount >= payment)
            {
                double newOverdue = overdueAmount - payment;

                string updatequery = "UPDATE Members SET Overdue = @Overdue WHERE MemberID = @MemberID";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using(SqlCommand cmd = new SqlCommand(updatequery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Overdue", newOverdue);
                        cmd.Parameters.AddWithValue("@MemberId", memberID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        //Getting Loan count from Database
        public int GetLoanCount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 LoanID FROM Loans ORDER BY LoanID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string latestLoanID = result.ToString();
                        string numericPart = latestLoanID.Substring(3);
                        int latestLoan = int.Parse(numericPart);

                        return latestLoan;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        //Generating a unique Loan ID according loan count retrieved from database
        public string GenerateLoanID()
        {
            int latestLoan = GetLoanCount() + 1;
            while(LoanIDExistance("LID" + latestLoan.ToString("000")))
            {
                latestLoan++;
            }
            return "LID" + latestLoan.ToString("000");
        }
        //Checking for if LoanID already Exist
        public bool LoanIDExistance(string loanID)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT (*) FROM Loans WHERE LoanID = @LoanID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoanID", loanID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        //Checking if the Book is On Loan
        public bool IsBookOnLoan(string bookID)
        {
            return Loans.Any(loan=>loan.BookID == bookID);
        }
        //Checking if the Book exist in Library
        public bool BookExistance(string bookID)
        {
            return AvailableBooks.Any(b=>b.BookID == bookID);
        }
        //Renewing Member Book Loans
        public void RenewLoan(string loanID, DateTime newDueDate)
        {
            string query = "UPDATE Loans SET DueDate=@NewDueDate WHERE LoanID = @LoanID";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewDueDate", newDueDate);
                    command.Parameters.AddWithValue("@LoanID", loanID);
                    command.ExecuteNonQuery();
                }
            }

            Loan renewedLoan = Loans.Find(l=> l.LoanID == loanID);
            if(renewedLoan != null)
            {
                renewedLoan.DueDate = newDueDate;
            }
        }

        //checking if member exist in Database
        public bool CheckMemberExist(string memberID)
        {
            return Members.Any(m=>m.MemberID == memberID);
        }
        
        //Check if the member has active Loans
        public bool CheckForLoans(string memberID)
        {
            return Loans.Any(l=>l.MemberID == memberID);
        }
    }
}
