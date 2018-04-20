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
    public partial class AddorUpdateTelephones_User : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        UserControlForm ctrlForm_user;
        int selectedTelephone = 0;

        public AddorUpdateTelephones_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrlForm_user = new UserControlForm();
            ctrlForm_user.Show();
            this.Hide();
            this.Dispose();
        }

        private void UpdateTeleOnly(OracleCommand cmd, OracleTransaction transaction)
        {
            cmd.CommandText = "update customer_tele set telephone_num=:SentTele where ssn=:SentSSN and telephone_num=:SelectedTele";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("SentTele", Convert.ToInt32( comboBox1.Text));
            cmd.Parameters.Add("SentSSN", HelperFunctions.GetSSN());
            cmd.Parameters.Add("SelectedTele", selectedTelephone);

            try
            {
                int Done = cmd.ExecuteNonQuery();

                if (Done != -1)
                {
                    transaction.Commit();

                    MessageBox.Show("Telephone number is updated successfully", "Done", MessageBoxButtons.OK);

                    selectedTelephone = Convert.ToInt32(comboBox1.Text);

                    return;
                }

                else
                {
                    MessageBox.Show("Cannot update telephone number");
                    return;
                }
            }

            catch
            {
                MessageBox.Show("Cannot perform the query ");
                return;
            }
        }


       
        private void AddorUpdateTelephones_User_Load(object sender, EventArgs e)
        {
            //load combo box with the telephones numbers
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "select telephone_num from customer_tele where ssn=:s";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("s", HelperFunctions.GetSSN());

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }

            dr.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            //do not update address
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                UpdateTeleOnly(cmd, transaction);
            }

            else
            {
                MessageBox.Show("Please enter or update your telephone number.");
            }
           
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTelephone = Convert.ToInt32(comboBox1.Text);
        }

        private void AddorUpdateTelephones_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void AddorUpdateTelephones_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("Combo box text changed");
        }
    }
}