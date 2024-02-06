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
    public partial class DisplayLoans : Form
    {
        private string loggedInUser;
        Library library;
        public DisplayLoans(string username)
        {
            InitializeComponent();
            library = new Library();
            this.loggedInUser = username;
        }

        private void LoadLoansTable()
        {
            dataGridViewLoans.DataSource = library.LoadLoansFromDatabse();
        }

        private void DisplayLoans_Load(object sender, EventArgs e)
        {
            LoadLoansTable();
            dataGridViewLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach(DataGridViewColumn column in dataGridViewLoans.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
            LibrarianMenu librarianMenu = new LibrarianMenu(loggedInUser);
            this.Close();
            librarianMenu.Show();
        }
    }
}
