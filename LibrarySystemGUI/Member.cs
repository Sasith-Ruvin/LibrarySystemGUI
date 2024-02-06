﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemGUI
{
    public class Member:Person
    {
        public string MemberID { get; }
        private string Username { get; }
        private string Password { get; }

        public double Overdue { get; set; }

        public List<Loan> PersonalLoans { get; set; } = new List<Loan>();

        public Member(string memberID, string username, string password, double overdue, string firstname, string lastName, string gender, string address, DateTime dateOfBirth) : base(firstname, lastName, gender, address, dateOfBirth)
        {
            MemberID = memberID;
            Username = username;
            Password = password;
            Overdue = overdue;
        }

        public string GetCredentials()
        {
            return Username;

        }

        public string GetPassword()
        {
            return Password;
        }
    }
}
