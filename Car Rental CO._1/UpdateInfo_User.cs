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
    public partial class UpdateInfo_User : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        UserControlForm ctrlForm_user;
        User_ChangePasswordForm PasswordChangeForm;

        int selectedTelephone = 0, UpdatedTele = 0;

        public UpdateInfo_User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_info_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            //do not update address
            //if (string.IsNullOrEmpty(textBoxBlocknumber.Text) && string.IsNullOrEmpty(textBoxGovernorate.Text)
            //    && string.IsNullOrEmpty(textBoxBlocknumber.Text))
            //{
            //    UpdateTeleOnly(cmd, transaction);

            //}            

            if ( !(string.IsNullOrEmpty(textBoxBlocknumber.Text) && string.IsNullOrEmpty(textBoxGovernorate.Text)
                && string.IsNullOrEmpty(textBoxBlocknumber.Text)))
            {
                //UpdateTeleOnly(cmd, transaction);
                UpdateAddressOnly(cmd, transaction);
            }
            conn.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ctrlForm_user = new UserControlForm();
            ctrlForm_user.Show();
            this.Hide();
            this.Dispose();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChangeForm = new User_ChangePasswordForm();
            PasswordChangeForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void UpdateInfo_User_Load(object sender, EventArgs e)
        {
            ////load combo box with the telephones numbers
            //conn = new OracleConnection(constr);
            //conn.Open();

            //OracleCommand cmd = new OracleCommand();

            //cmd.Connection = conn;

            //cmd.CommandText = "select telephone_num from customer_tele where ssn=:s";
            //cmd.CommandType = CommandType.Text;

            //cmd.Parameters.Add("s", HelperFunctions.GetSSN());

            //OracleDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    comboBoxTele.Items.Add(dr[0]);
            //}

            //dr.Close();
            //conn.Close();
        }

        private void comboBoxTele_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //private void UpdateTeleOnly(OracleCommand cmd, OracleTransaction transaction)
        //{
        //    cmd.CommandText = "update customer_tele set telephone_num=:SentTele where ssn=:SentSSN and telephone_num=:SelectedTele";
            
        //    cmd.Parameters.Add("SentTele", comboBoxTele.Text);
        //    cmd.Parameters.Add("SentSSN", HelperFunctions.GetSSN());
        //    cmd.Parameters.Add("SelectedTele", selectedTelephone);

        //    try
        //    {
        //        int Done = cmd.ExecuteNonQuery();

        //        if (Done != -1)
        //        {
        //            transaction.Commit();

        //            MessageBox.Show("Telephone number is updated successfully", "Done", MessageBoxButtons.OK);

        //            selectedTelephone = Convert.ToInt32(comboBoxTele.Text);

        //            return;
        //        }

        //        else
        //        {
        //            MessageBox.Show("Cannot update telephone number");
        //            return;
        //        }
        //    }

        //    catch
        //    {
        //        MessageBox.Show("Please, Do not enter a new telephone number only update");
        //        return;
        //    }


        //}

        private void UpdateAddressOnly(OracleCommand cmd, OracleTransaction transaction)
        {
            cmd.CommandText = "update customer set block_num=:BlockNo, street=:TheStreet, GOVERNORATE=:Gov where ssn=:SentSSN";
           
            cmd.Parameters.Add("BlockNo", textBoxBlocknumber.Text);
            cmd.Parameters.Add("TheStreet", textBoxStreet.Text);
            cmd.Parameters.Add("Gov", textBoxGovernorate.Text);
            cmd.Parameters.Add("SentSSN", HelperFunctions.GetSSN());

            int Done = cmd.ExecuteNonQuery();

            if (Done != -1)
            {
                transaction.Commit();

                MessageBox.Show("Address is updated successfully", "Done", MessageBoxButtons.OK);
                return;
            }

            else
            {
                MessageBox.Show("Cannot update address");
                return;
            }
        }
    }
}