using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemGUI
{
    public class Loan
    {
        public string LoanID { get; set; }
        public string MemberID { get; set; } 
        public string Name { get; set; } 
        public string BookID { get; set; }
        public string Title { get; set; }
        public DateTime IsuueDate { get; set; }
        public DateTime DueDate { get; set; }

        public static List<Loan> AllLoans { get; set; } = new List<Loan>();
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Loan(string loanID, string memberID, string name, string bookID, string title, DateTime issueDate, DateTime dueDate)
        {
            LoanID = loanID;
            MemberID = memberID;
            Name = name;
            BookID = bookID;
            Title = title;
            IsuueDate = issueDate;
            DueDate = dueDate;
        }
       
    }
}
