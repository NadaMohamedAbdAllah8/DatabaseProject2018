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
    public partial class UserDeleteRentalcs : Form
    {
        UserControlForm ctrlForm_user;
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        string Date_and_RegNum = "", TheDate, RegNum;

        int SentSSN = HelperFunctions.GetSSN();

        public UserDeleteRentalcs()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ctrlForm_user.Show();
            this.Dispose();
        }

        private void UserDeleteRentalcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void UserDeleteRentalcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void UserDeleteRentalcs_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MMM-yy";

            //    conn = new OracleConnection(constr);
            //    conn.Open();

            //    OracleCommand cmd = new OracleCommand();

            //    cmd.Connection = conn;

            //    //cmd.CommandText = "select EXTRACT(day from starting_date),EXTRACT(month from starting_date),EXTRACT(YEAR from starting_date),car_reg_num from cusrent where cus_snn=:s";

            //    cmd.CommandText = "select  starting_date ,car_reg_num from cusrent where cus_snn=:s";
            //    cmd.Parameters.Add("s", SentSSN);

            //    cmd.CommandType = CommandType.Text;
            //    OracleDataReader dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //       // Date_and_RegNum = dr[0].ToString() + "-" + dr[1].ToString() + "-"+dr[2].ToString() + "," + dr[3].ToString() + ".";

            //        TheDate = dr[0].ToString();
            //        RegNum = dr[1].ToString();

            //        Date_and_RegNum = TheDate + "," + RegNum+".";


            //        comboBox1.Items.Add(Date_and_RegNum);
            //    }

            //    dr.Close();

            //    conn.Close();            
            //
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Wrong Date!\nYou can only delete upcoming renatls",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the registration number",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            cmd.CommandText = "DelrentUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("sentSSN", SentSSN);
            cmd.Parameters.Add("SentRegNum", textBox1.Text);
            cmd.Parameters.Add("SentDate", dateTimePicker1.Text);

            int EffectedRowsCounter = cmd.ExecuteNonQuery();

            if (EffectedRowsCounter == 0)
            {
                MessageBox.Show("Something went wrong!Cannnot delete\nPlease check your information and try again", "Error!");
            }

            else if (EffectedRowsCounter == 1)
            {
                MessageBox.Show("Car is deleted successfully");
            }

            else
            {
                MessageBox.Show("Something went wrong!Cannnot delete\nPlease check your information and try again", "Error!");
            }

            conn.Close();
        }
    }
}