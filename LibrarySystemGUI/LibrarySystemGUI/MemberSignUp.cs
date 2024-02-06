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
    public partial class MemberSignUp : Form
    {
        public MemberSignUp()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?","Exit Application",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();

            }
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MemberLogin memberlogin = new MemberLogin();
            this.Hide();
            memberlogin.Show();

        }

        private void SignUp_Clear_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are You sure You want to Clear Details?","Clear Details",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Firstname_Input.Clear();
                Lastname_Input.Clear();
                Address_Input.Clear();
                GenderMale_Radiobtn.Checked = false;
                GenderFemale_Radiobtn.Checked = false;
                SignUp_Username.Clear();
                SignUp_Password.Clear();
                BirthdatePicker.Value = DateTime.Today;

            }
           


        }

        private void MemberSignUp_Load(object sender, EventArgs e)
        {
            BirthdatePicker.Format = DateTimePickerFormat.Short;
            BirthdatePicker.MaxDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberLogin memberLogin = new MemberLogin();
            this.Hide();
            memberLogin.Show();
        }

        private void Member_Login_btn_Click(object sender, EventArgs e)
        {
            if(Firstname_Input.Text == "" || Lastname_Input.Text == "" || Address_Input.Text == "" || (!GenderMale_Radiobtn.Checked && !GenderFemale_Radiobtn.Checked) || SignUp_Username.Text== "" || SignUp_Password.Text == "")
            {
                MessageBox.Show("Please Fill All the Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BirthdatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
