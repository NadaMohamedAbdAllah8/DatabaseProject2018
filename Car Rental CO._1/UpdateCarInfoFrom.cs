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
    public partial class UpdateCarInfoFrom : Form
    {

        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;
        string address = "";
        string street = " ", bolkNo = "", Gov = "", FirstATALLAddress;

        public UpdateCarInfoFrom()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ControlForm cForm = new ControlForm();

            this.Hide();
            cForm.Show();
            this.Close();
        }

        private void UpdateCarInfoFrom_Load(object sender, EventArgs e)
        {
                   }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboRegNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateCarInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(comboBoxBranch.Text))
            {
                HelperFunctions.ParseAddress(comboBoxBranch.Text, ref Gov, ref street, ref bolkNo);
            }

            //making sure that the year of production in the right format
            if (!string.IsNullOrWhiteSpace(textBoxProductionYear.Text) &&
                !HelperFunctions.ValidYear(textBoxProductionYear.Text))
            {
                MessageBox.Show("Wrong year!!\nPlease Re-enter the production year.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            char r = 'n', nr = 'n';
            if (radioButtonRepairNO.Checked)
                nr = 'n';
            else if (radioButtonRepairYES.Checked)
                nr = 'y';
            else
                MessageBox.Show("Something went wrong while filling need repair radio button!");

            if (radioButtonNoRented.Checked)
                r = 'n';
            else if (radioButtonYesRented.Checked)
                r = 'y';
            else
                MessageBox.Show("Something went wrong while filling need rented radio button!");

            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "updateTested";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("rCost", textBoxRentalCost.Text);

            if (string.IsNullOrWhiteSpace(comboBoxBranch.Text))
            {
                MessageBox.Show("comboBoxBranch.Text" + comboBoxBranch.Text);

                string NA = "not specified ";
                int none = 0000;
                cmd.Parameters.Add("BNum", none);
                cmd.Parameters.Add("Thstreet", NA);
                cmd.Parameters.Add("gov", NA);
            }
            else
            {
                cmd.Parameters.Add("BNum", bolkNo);
                cmd.Parameters.Add("Thstreet", street);
                cmd.Parameters.Add("gov", Gov);
            }
            cmd.Parameters.Add("Cmod", textBoxModel.Text);
            cmd.Parameters.Add("m", textBoxManufacturer.Text);
            cmd.Parameters.Add("ft", textBoxFuelType.Text);
            cmd.Parameters.Add("es", textBoxEngineSize.Text);
            cmd.Parameters.Add("Pyear", textBoxProductionYear.Text);
            cmd.Parameters.Add("inc", textBoxPaidInsurance.Text);

            if (dateTimePickerpDate.Value.Year>2018)
            {
                MessageBox.Show("Wrong year!!\nPlease reenter the purchase year.","Wrong year",MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);

                return;
            }
            cmd.Parameters.Add("pdate", Convert.ToDateTime(dateTimePickerpDate.Text));
            cmd.Parameters.Add("pcost", textBoxPurchaseCost.Text);
            cmd.Parameters.Add("regNum", textBoxRegNum.Text);
            cmd.Parameters.Add("passNO", textBoxPassengersNumber.Text);
            cmd.Parameters.Add("nr", nr);
            cmd.Parameters.Add("r", r);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Car is updated successfully!");
        
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void textBoxRegNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoadInfo_Click(object sender, EventArgs e)
        {
            //Checking that the reg. number is correct
            bool isRegNumExist = false;
            if (!HelperFunctions.ValidRegNum(Convert.ToInt32(textBoxRegNum.Text), ref isRegNumExist) && isRegNumExist == false)
            {
                MessageBox.Show("Wrong registration number!!\nBlank, already exists or too small!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = @"select rentalcost, block_num, street, governorate,
cmodel, maker, fule_type, engine_size
, is_rented, year_production, required_insurance,
purchase_date, needrepair, purchase_cost, number_passengers
from car where registration_number=:regNum ";

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("regNum", textBoxRegNum.Text);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBoxPaidInsurance.SelectedText = dr[10].ToString();
                textBoxPassengersNumber.SelectedText = dr[14].ToString();
                textBoxProductionYear.SelectedText = dr[9].ToString();
                textBoxPurchaseCost.SelectedText = dr[13].ToString();
                textBoxRentalCost.SelectedText = dr[0].ToString();
                textBoxModel.SelectedText = dr[4].ToString();
                textBoxManufacturer.SelectedText = dr[5].ToString();
                textBoxFuelType.SelectedText = dr[6].ToString();
                textBoxEngineSize.SelectedText = dr[7].ToString();

                dateTimePickerpDate.CustomFormat = "dd-MMM-yy";
                dateTimePickerpDate.Text = dr[11].ToString();
          
                //Address
                comboBoxBranch.SelectedText = dr[1].ToString() + "," + dr[2].ToString() + "," + dr[3].ToString();

                FirstATALLAddress = comboBoxBranch.SelectedText;

                street = dr[2].ToString();
                bolkNo = dr[1].ToString();
                Gov = dr[3].ToString();

                if (dr[12].ToString() == "N" || dr[12].ToString() == "n")
                {
                    radioButtonRepairNO.Checked = true;
                }
                else
                {
                    radioButtonRepairYES.Checked = true;
                }

                if (dr[8].ToString() == "Y" || dr[8].ToString() == "y")
                {
                    radioButtonYesRented.Checked = true;
                }
                else
                {
                    radioButtonNoRented.Checked = true;
                }
            }

            else
                MessageBox.Show("Something went wrong during loading the values!");

            //Putting all the addresses in the combo box
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            //cmd2.CommandText = "select block_num, street, governorate from company_address ";
            cmd2.CommandText = "select * from company_address ";

            cmd2.CommandType = CommandType.Text;
            OracleDataReader dr2 = cmd2.ExecuteReader();

            address = " ";

            while (dr2.Read())
            {
                address = dr2[1].ToString() + "," + dr2[2] + "," + dr2[3];
                comboBoxBranch.Items.Add(address);

                //to be able to perform split function on the address
                address += '*';

                      }

            dr2.Close();

            dr.Close();
         
            conn.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePickerpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}