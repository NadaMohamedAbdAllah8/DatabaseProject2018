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
    public partial class UserSignUp_only : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        UserLoginSignUpForm LoginSignUpForm;
        UserControlForm userConForm;

        public UserSignUp_only()
        {
            InitializeComponentSignUp();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginSignUpForm = new UserLoginSignUpForm();
            LoginSignUpForm.Show();

            this.Hide();
        }

        private void UserSignUp_only_Load(object sender, EventArgs e)
        {
            label9.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddtelephoneNum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTeleNum.Text))
            {
                MessageBox.Show("Please enter your telephone number", "Warning", MessageBoxButtons.OK);

                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSSN_signup.Text) || string.IsNullOrWhiteSpace(textBoxPassword_Signup.Text))
            {
                MessageBox.Show("You have to fill SSN and password fields", "Warning", MessageBoxButtons.OK);

                return;
            }

            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            //To avoid errors the user info will be checked if it is in the database already or not
            if (HelperFunctions.UserExist(textBoxSSN_signup, textBoxPassword_Signup) == 0)
            {
                cmd.Parameters.Add("UserSSN", textBoxSSN_signup.Text);
                cmd.Parameters.Add("UserPassword", textBoxPassword_Signup.Text);

                cmd.CommandText = "inserSSNandPassword";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
             }

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            //insert telephones
            cmd2.Parameters.Add("UserSSN", textBoxSSN_signup.Text);
            cmd2.Parameters.Add("Tele", textBoxTeleNum.Text);

            cmd2.CommandText = "InserTelePhoneNum";
            cmd2.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("The entered telephone number already exist!", "Error", MessageBoxButtons.OK);
            }

            conn.Close();

            textBoxTeleNum.Clear();
        }

        private void UserSignUp_only_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDrivingLicenceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //1-Insert ssn and password
            if (string.IsNullOrWhiteSpace(textBoxSSN_signup.Text) || string.IsNullOrWhiteSpace(textBoxPassword_Signup.Text))
            {
                MessageBox.Show("You have to fill SSN and password fields", "Warning", MessageBoxButtons.OK);

                return;
            }

            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            //The user might add more phones, so his ssn and password have been added already 
            if (HelperFunctions.UserExist(textBoxSSN_signup, textBoxPassword_Signup) == 0)
            {
                cmd.Parameters.Add("UserSSN", textBoxSSN_signup.Text);
                cmd.Parameters.Add("UserPassword", textBoxPassword_Signup.Text);

                cmd.CommandText = "inserSSNandPassword";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }


            //2-insert address and driving licence
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.Parameters.Add("CusblockNum", textBoxBlockNum.Text);
            cmd2.Parameters.Add("CusStreet", textBoxStreet.Text);
            cmd2.Parameters.Add("gov", textBoxGov.Text);
            cmd2.Parameters.Add("drivingLic", textBoxDrivingLicenceNumber.Text);
            cmd2.Parameters.Add("UserSSN", textBoxSSN_signup.Text);

            cmd2.CommandText = "InserCus_AddandDrivingLicence";
            cmd2.CommandType = CommandType.StoredProcedure;

            cmd2.ExecuteNonQuery();

           
            //3-Insert telephones
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            cmd3.Parameters.Add("UserSSN", textBoxSSN_signup.Text);
            cmd3.Parameters.Add("Tele", textBoxTeleNum.Text);

            cmd3.CommandText = "InserTelePhoneNum";
            cmd3.CommandType = CommandType.StoredProcedure;

            //try and catch because the telephone might have been added already
            try
            {
                cmd3.ExecuteNonQuery();
            }

            catch
            {

            }

            conn.Close();

            //Done
            MessageBox.Show("Sign up scussefully", "Sucess", MessageBoxButtons.OK);
           
            //Keep userSSN
            HelperFunctions.SetSSN(Convert.ToInt32(textBoxSSN_signup.Text));

            userConForm = new UserControlForm();
            userConForm.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserSignUp_only
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "UserSignUp_only";
            this.Load += new System.EventHandler(this.UserSignUp_only_Load_1);
            this.ResumeLayout(false);

        }

        private void UserSignUp_only_Load_1(object sender, EventArgs e)
        {

        }
    }
}
