using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemGUI
{
    public partial class MemberSignUp : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public MemberSignUp()
        {
            InitializeComponent();
            initializeTextboxes();

        }

        private void initializeTextboxes()
        {
            AddPlaceHolders(Firstname_Input, "Enter your Firstname");
            AddPlaceHolders(Lastname_Input, "Enter your Lastname");
            AddPlaceHolders(Address_Input, "Enter your Address");
            AddPlaceHolders(SignUp_Username, "Enter a Username");
            AddPlaceHolders(SignUp_Password, "Enter a Password");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddPlaceHolders(TextBox textBox, string placeHolders)
        {
            textBox.Text = placeHolders;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += (sender, e) => RemovePlaceholder(textBox, placeHolders);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }


        private void Close_button_Click(object sender, EventArgs e)
        {
            ButtonClicks.CloseButton_Click(sender, e, this);
            
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
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
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

        private void MemberSignUp_Load(object sender, EventArgs e)
        {
            BirthdatePicker.Format = DateTimePickerFormat.Short;
            BirthdatePicker.MaxDate = DateTime.Today;
            BirthdatePicker.Value = DateTime.Today;
           
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
            else
            {
                MemberManager memberManager = new MemberManager(connectionString);

                string memberUsername = SignUp_Username.Text;
                string memberPassword = SignUp_Password.Text;
                string firstname = Firstname_Input.Text;
                string lastname = Lastname_Input.Text;
                string gender = (GenderMale_Radiobtn.Checked) ? "Male" : "Female";
                string memAddress = Address_Input.Text;
                DateTime dateofBirth = BirthdatePicker.Value;

                string memberID = memberManager.GenerateMemberID();
                float overdue = 0;

                string insertQuery = "INSERT INTO Members (MemberID, MemberUsername, MemberPassword, Overdue, Firstname, Lastname, Gender, MemAddress, DateofBirth)" +
                    "VALUES (@MemberID, @MemberUsername, @MemberPassword, @Overdue, @Firstname, @Lastname, @Gender, @MemAddress, @DateofBirth)";

                bool SignUpProcess = false;
                try
                {
                    using(SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using(SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@MemberID", memberID);
                            cmd.Parameters.AddWithValue("@MemberUsername", memberUsername);
                            cmd.Parameters.AddWithValue("@MemberPassword", memberPassword);
                            cmd.Parameters.AddWithValue("@Overdue", overdue);
                            cmd.Parameters.AddWithValue("@Firstname", firstname);
                            cmd.Parameters.AddWithValue("@Lastname", lastname);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@MemAddress", memAddress);
                            cmd.Parameters.AddWithValue("@DateofBirth", dateofBirth);
                            if (memberManager.CheckUserNameTaken(memberUsername))
                            {
                                MessageBox.Show("Username is already taken. Please Choose another","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                SignUpProcess = false;
                            }
                            else
                            {
                              cmd.ExecuteNonQuery();
                              SignUpProcess = true;
                            }
                            
                        }
                        if (SignUpProcess)
                        {
                            MessageBox.Show("You have Successfully Signed Up. Use the Username and Password in Login page to Login", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to Connect to Server","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            ButtonClicks.MinimizeBtn_Click(sender, e, this);
        }

        private void MemberLoginMenu_Btn_MouseEnter(object sender, EventArgs e)
        {
            MemberLoginMenu_Btn.BackColor = Color.White;
            MemberLoginMenu_Btn.ForeColor = Color.Black;
        }

        private void MemberLoginMenu_Btn_MouseLeave(object sender, EventArgs e)
        {
            MemberLoginMenu_Btn.BackColor = Color.FromArgb(0, 150, 149);
            MemberLoginMenu_Btn.ForeColor = Color.White;
        }
    }
}
