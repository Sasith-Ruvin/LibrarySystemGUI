using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class PersonalLoans : Form
    {
        Library library;
        private string loggedInUser;
        public PersonalLoans(string username)
        {
            InitializeComponent();
            this.loggedInUser = username;
            library = new Library();
        }

        private void PersonalLoans_Load(object sender, EventArgs e)
        {
            Member loggedInMember = library.Members.Find(m=>m.GetCredentials() == loggedInUser);

            if (loggedInMember != null)
            {
                List<Loan> memberLoans = library.GetMemberLoans(loggedInMember.MemberID);

                dataGridViewPersonalLoans.DataSource = memberLoans;
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
            MemberMenu memberMenu = new MemberMenu(loggedInUser);
            this.Close();
            memberMenu.Show();
        }
    }
}
