using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public enum MenuType
    {
        MemberMenu,
        LibrarianMenu
    }
    public partial class DisplayBooks : Form
    {
        Library library;
        private string loggedInUser;
        private MenuType openedMenu;
        public DisplayBooks(string username, MenuType openedFrom)
        {
            InitializeComponent();
            library = new Library();
            this.loggedInUser = username;
            this.openedMenu = openedFrom;    
        }
        private void DisplayBooks_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = library.AvailableBooks;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach(DataGridViewColumn column in dataGridViewBooks.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }
        private void BookCloseBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
        }
        private void BookMinBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }
        private void BookBackBtn_Click(object sender, EventArgs e)
        {
            switch (openedMenu)
            {
                case MenuType.MemberMenu:
                    MemberMenu memberMenu = new MemberMenu(loggedInUser);
                    memberMenu.Show();
                    this.Close();
                    break;
                case MenuType.LibrarianMenu:
                    LibrarianMenu librarianMenu = new LibrarianMenu(loggedInUser);
                    librarianMenu.Show();
                    this.Close();
                    break;
                default:
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Close();
                    break;
            }
            this.Close();
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            string searchedTerm = searchInput.Text;
            var  searchResults = library.AvailableBooks.Where(book=>
                                                              book.Title.IndexOf(searchedTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                              book.Author.IndexOf(searchedTerm, StringComparison.OrdinalIgnoreCase) >=0 ||
                                                              book.BookID.IndexOf(searchedTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            dataGridViewBooks.DataSource = null;
            if(searchResults.Count > 0)
            {
                dataGridViewBooks.DataSource = searchResults;
                dataGridViewBooks.Refresh();
            }
        }
    }
}
