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
    public partial class User_AddTelephones : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        UserControlForm ctrlForm_user;

        public User_AddTelephones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            OracleTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                InsertTeleOnly(cmd, transaction);
            }

            else
            {
                MessageBox.Show("Please enter your telephone number.");
            }


            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrlForm_user = new UserControlForm();
            ctrlForm_user.Show();
            this.Hide();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InsertTeleOnly(OracleCommand cmd, OracleTransaction transaction)
        {
            cmd.CommandText = "insert into customer_tele values(:SentSSN,:SentTele)";

            cmd.Parameters.Add("SentSSN", HelperFunctions.GetSSN());
            cmd.Parameters.Add("SentTele", textBox1.Text);

            try
            {
                int Done = cmd.ExecuteNonQuery();

                if (Done != -1)
                {
                     transaction.Commit();

                    MessageBox.Show("Telephone number is added successfully", "Done", MessageBoxButtons.OK);

                    return;
                }

                else
                {
                    MessageBox.Show("Cannot add telephone number");

                    return;
                }
            }

            catch
            {
                MessageBox.Show("Cannot perform the query ");
                return;
            }
        }

        private void User_AddTelephones_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void User_AddTelephones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void User_AddTelephones_Load(object sender, EventArgs e)
        {

        }
    }
}