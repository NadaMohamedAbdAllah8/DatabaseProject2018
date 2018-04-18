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
    public partial class ShowExpenditure : Form
    {
        ControlForm cForm;

        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        public ShowExpenditure()
        {
            InitializeComponent();
        }

        private void ShowExpenditure_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "MMM-yy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            cForm = new ControlForm();
            this.Hide();
            cForm.Show();
            this.Close();
        }

        private void ShowExpenditure_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value.Year>2018||dateTimePicker1.Value.Year<1800)
            {
                MessageBox.Show("Wrong year!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            double InsuranceCosts = 0.0, RepairCosts = 0.0, MaintenanceCosts = 0.0, PurchasingCarsCosts = 0.0, total = 0.0;

            conn = new OracleConnection(constr);
            conn.Open();

            //1-Purchasing Cost
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "GetPurchasingCost";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("SentYear", dateTimePicker1.Value.Year);
            cmd.Parameters.Add("SentMonth", dateTimePicker1.Value.Month);
            cmd.Parameters.Add("purCost", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            try
            {
                cmd.ExecuteNonQuery();
                textBoxPurchasingCarsCosts.SelectedText = cmd.Parameters["purCost"].Value.ToString();

                PurchasingCarsCosts = Convert.ToDouble(cmd.Parameters["purCost"].Value.ToString());
            }

            catch
            {
                MessageBox.Show("Cannot get Purchasing Cars Costs!!", "Error", MessageBoxButtons.OK);
            }

            conn.Close();


            //2-Repair Costs/////////////////////////////////////////////////////////////////////////
            conn.Open();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            cmd2.CommandText = "GetRepairCosts";
            cmd2.CommandType = CommandType.StoredProcedure;

            cmd2.Parameters.Add("SentYear", dateTimePicker1.Value.Year);
            cmd2.Parameters.Add("SentMonth", dateTimePicker1.Value.Month);
            cmd2.Parameters.Add("repairCost", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            try
            {
                cmd2.ExecuteNonQuery();

                textBoxRepairCosts.SelectedText = cmd2.Parameters["repairCost"].Value.ToString();

                RepairCosts = Convert.ToDouble(cmd2.Parameters["repairCost"].Value.ToString());
            }

            catch
            {
                MessageBox.Show("Cannot get Repair Cost!!", "Error", MessageBoxButtons.OK);
            }

            conn.Close();


            //3-InsuranceCosts//////////////////////////////////////////////////////////////////////////////////////

            conn.Open();

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            cmd3.CommandText = "GetInsuranceCosts";
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.Add("SentYear", dateTimePicker1.Value.Year);
            cmd3.Parameters.Add("SentMonth", dateTimePicker1.Value.Month);
            cmd3.Parameters.Add("IncCost", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            try
            {
                cmd3.ExecuteNonQuery();

                textBoxInsuranceCosts.SelectedText = cmd3.Parameters["IncCost"].Value.ToString();

                InsuranceCosts = Convert.ToDouble(cmd3.Parameters["IncCost"].Value.ToString());
            }

            catch
            {
                MessageBox.Show("Cannot get Insurance Costs!!", "Error", MessageBoxButtons.OK);
            }

            conn.Close();


            //4-MaintenanceCosts//////////////////////////////////////////////////////////////////////////////////////

            conn.Open();

            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = conn;

            cmd4.CommandText = "GetMaintenanceCosts";
            cmd4.CommandType = CommandType.StoredProcedure;

            cmd4.Parameters.Add("SentYear", dateTimePicker1.Value.Year);
            cmd4.Parameters.Add("SentMonth", dateTimePicker1.Value.Month);
            cmd4.Parameters.Add("MainCost", OracleDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            try
            {
                cmd4.ExecuteNonQuery();

                textBoxMaintenanceCosts.SelectedText = cmd4.Parameters["MainCost"].Value.ToString();

                MaintenanceCosts = Convert.ToDouble(cmd4.Parameters["MainCost"].Value.ToString());
               
                total = MaintenanceCosts + InsuranceCosts + RepairCosts + PurchasingCarsCosts;
                textBoxTotalCosts.Text = total.ToString();
            }

            catch
            {
                MessageBox.Show("Cannot get Maintenance Costs!!", "Error", MessageBoxButtons.OK);
            }

            conn.Close();

            //inserting or updating
            conn.Open();
            OracleCommand cmd5 = new OracleCommand();
            cmd5.Connection = conn;

            if(HelperFunctions.MonthYearExist(dateTimePicker1)==1)
            {
                cmd5.CommandText = "UpdateExpenditures";
                cmd5.CommandType = CommandType.StoredProcedure;

                cmd5.Parameters.Add("SentYear", dateTimePicker1.Value.Year);
                cmd5.Parameters.Add("SentMonth", dateTimePicker1.Value.Month);
                cmd5.Parameters.Add("ins", InsuranceCosts);
                cmd5.Parameters.Add("rCost", RepairCosts);
                cmd5.Parameters.Add("mCost", MaintenanceCosts);
                cmd5.Parameters.Add("pCost", PurchasingCarsCosts);

                cmd5.ExecuteNonQuery();
            }

            else
            {
                cmd5.CommandText = "Insertexpenditures";
                cmd5.CommandType = CommandType.StoredProcedure;

                cmd5.Parameters.Add("SentYear", dateTimePicker1.Value.Year);
                cmd5.Parameters.Add("SentMonth", dateTimePicker1.Value.Month);
                cmd5.Parameters.Add("ins", InsuranceCosts);
                cmd5.Parameters.Add("rCost", RepairCosts);
                cmd5.Parameters.Add("mCost", MaintenanceCosts);
                cmd5.Parameters.Add("pCost",PurchasingCarsCosts);

                cmd5.ExecuteNonQuery();
            }

            
        
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowExpenditure_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}