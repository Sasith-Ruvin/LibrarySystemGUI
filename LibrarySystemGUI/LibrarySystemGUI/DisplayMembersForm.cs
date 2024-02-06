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
    public partial class DisplayMembersForm : Form
    {
        Library library;
        public DisplayMembersForm()
        {
            InitializeComponent();
            library = new Library();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayMembersForm_Load(object sender, EventArgs e)
        {
            LoadMembersTable();

        }
        private void LoadMembersTable()
        {
            dataGridViewMembers.DataSource = library.LoadMemberDetailsFromDatabaseToTable();
        }
    }
}
