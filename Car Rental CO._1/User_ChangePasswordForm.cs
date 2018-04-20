using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Car_Rental_CO._1
{
    public partial class User_ChangePasswordForm : Form
    {
        UserControlForm UserCtrlForm;
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        public User_ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //User_updateinfoForm = new UpdateInfo_User();
            //User_updateinfoForm.Show();
            //this.Hide();
            //this.Dispose();

            //UserCtrlForm
            UserCtrlForm = new UserControlForm();
            UserCtrlForm.Show();
            this.Hide();
            this.Dispose();

        }

        private void User_ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void User_ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            int Valid = HelperFunctions.UserExist_UpdateHelper(textBoxOldPassword.Text);

            if (Valid == 0)
            {
                MessageBox.Show("Wrong password!!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            else 
            {
                cmd.CommandText = "update customer set cuspassword=:SentPassword where ssn=:SentSSN ";

                cmd.Parameters.Add("SentPassword", textBoxNewPassword.Text);
                cmd.Parameters.Add("SentSSN", HelperFunctions.GetSSN());
                

              //  try
                //{
                    int Done = cmd.ExecuteNonQuery();

                    if (Done != -1)
                    {
                        MessageBox.Show("Password is updated successfully", "Done", MessageBoxButtons.OK);

                        return;
                    }

                    else
                    {
                        MessageBox.Show("Cannot update the password");

                        return;
                    }
                //}

                //catch
                //{
                //    MessageBox.Show("Cannot perform the query ");
                //    return;
                //}
                    conn.Close();
            }
        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}