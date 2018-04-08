using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Car_Rental_CO._1
{
    public partial class UserLoginSignUpForm : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        UserControlForm userForm;
        UserSignUp_only signupForm;

        public UserLoginSignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            if (string.IsNullOrWhiteSpace(textBoxSSNLogIn.Text) || string.IsNullOrWhiteSpace(textBoxPasswordLogIn.Text))
            {
                MessageBox.Show("Please fill in missing information!", "Warning", MessageBoxButtons.OK);

                return;
            }

            int Exists = HelperFunctions.UserExist(textBoxSSNLogIn, textBoxPasswordLogIn);

            if (Exists == 0)
            {
                MessageBox.Show("There is no user with such information!", "Error", MessageBoxButtons.OK);

                return;
            }

            conn.Close();

            userForm = new UserControlForm();
            userForm.Show();

            this.Hide();
        }

        private void buttonSignup_fromLogInForm_Click(object sender, EventArgs e)
        {
            signupForm = new UserSignUp_only();
            signupForm.Show();

            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            userForm.Dispose();
            signupForm.Dispose();
        }

        private void UserLoginSignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void UserLoginSignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
