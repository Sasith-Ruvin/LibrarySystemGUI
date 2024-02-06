using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemGUI
{
    public class Loan
    {
        public string LoanID { get; set; }
        public Member BorrowedMember { get; set; }
        public Book BorrowedBook { get; set; }
        public DateTime DueDate { get; set; }

        public static List<Loan> AllLoans { get; set; } = new List<Loan>();

        public Loan(Member borrowedMember, Book borrowedBook, DateTime dueDate)
        {
            this.LoanID = "LOAN" + (AllLoans.Count + 1).ToString("D3");
            BorrowedMember = borrowedMember;
            BorrowedBook = borrowedBook;
            DueDate = dueDate;
        }

        public static void AddLoan(Loan loan)
        {
            AllLoans.Add(loan);
        }

    }
}
