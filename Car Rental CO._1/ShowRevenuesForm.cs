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
    public partial class ShowRevenuesForm : Form
    {
        ControlForm cForm;
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        public ShowRevenuesForm()
        {
            InitializeComponent();
        }

        private void ShowRevenuesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void ShowRevenuesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            cForm = new ControlForm();
            this.Hide();
            cForm.Show();
            this.Close();
        }

        private void ShowRevenuesForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.CustomFormat = "MMM-yy";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Value.Year > 2018 || dateTimePicker.Value.Year < 1800)
            {
                MessageBox.Show("Wrong year!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "GetCarHireCost";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SentYear", dateTimePicker.Value.Year);
            cmd.Parameters.Add("SentMonth", dateTimePicker.Value.Month);
            cmd.Parameters.Add("HireCost", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            double HireCosts = 0.0;

            try
            {
                cmd.ExecuteNonQuery();
                textBoxCarHire.SelectedText = cmd.Parameters["HireCost"].Value.ToString();

                HireCosts = Convert.ToDouble(cmd.Parameters["HireCost"].Value.ToString());
            }

            catch
            {
                MessageBox.Show("Cannot get Cars Hire Costs!!", "Error", MessageBoxButtons.OK);
            }

            conn.Close();

            //inserting or updating
            conn.Open();
            OracleCommand cmd5 = new OracleCommand();
            cmd5.Connection = conn;

            if (HelperFunctions.MonthYearExistRev(dateTimePicker) == 1)
            {
                cmd5.CommandText = "UpdateRevenues";
                cmd5.CommandType = CommandType.StoredProcedure;

                cmd5.Parameters.Add("SentYear", dateTimePicker.Value.Year);
                cmd5.Parameters.Add("SentMonth", dateTimePicker.Value.Month);
                cmd5.Parameters.Add("HCost", HireCosts);
           
                cmd5.ExecuteNonQuery();
            }

            else
            {
                cmd5.CommandText = "InsertRevenue";
                cmd5.CommandType = CommandType.StoredProcedure;

                cmd5.Parameters.Add("SentYear", dateTimePicker.Value.Year);
                cmd5.Parameters.Add("SentMonth", dateTimePicker.Value.Month);
                cmd5.Parameters.Add("Hcost", HireCosts);
                

                cmd5.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}
