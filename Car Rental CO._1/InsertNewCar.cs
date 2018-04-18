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
    public partial class InsertNewCar : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;
        string address;

        public InsertNewCar()
        {
            InitializeComponent();
        }

        private void InsertNewCar_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "SELECT block_num, street, governorate from company_address";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                address = dr[0].ToString() + "," + dr[1].ToString() + "," + dr[2].ToString();
                comboBox_Branch.Items.Add(address);

                //to be able to perform split function on the address
                address += '*';
            }

            dr.Close();
            conn.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_Branch = new ComboBox();

            //Getting IsRented and NeedRepair values ready
            char IsRented = '0', needRepair = 'n';

            if (radioButton_YesRepair.Checked)
            {
                IsRented = 'y';
                needRepair = 'y';
            }

            if (radioButton_NoRepair.Checked)
            {
                IsRented = 'n';
                needRepair = 'n';
            }

            //splitting the address
            string street = "", bolkNo = "", Gov = "";
            //in case that the branch address was not provided by the admin
            if (!string.IsNullOrWhiteSpace(comboBox_Branch.Text))
            {
                HelperFunctions.ParseAddress(comboBox_Branch.SelectedItem.ToString(), ref Gov, ref street, ref bolkNo);
            }          

            //making sure that the year of production in the right format
            if (!string.IsNullOrWhiteSpace(txt_Production_Year.Text) &&
                !HelperFunctions.ValidYear(txt_Production_Year.Text))
            {
                MessageBox.Show("Wrong year!!\nPlease Renter the production year.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            //making sure that the registration number in the right format
            bool RegNumExist=false;
        
            if (!HelperFunctions.ValidRegNum(Convert.ToInt32(txt_Registration_Number.Text), ref RegNumExist))
            {
                MessageBox.Show("Wrong registration number!!\nBlank, already exists or too small!", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            //Preparing the stored procedure parameters
            conn = new OracleConnection(constr);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "InsertNewCar";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("CarregNum", txt_Registration_Number.Text);
            cmd.Parameters.Add("required_insu", txt_Paid_Insurance.Text);
            cmd.Parameters.Add("BlockNo", bolkNo);
            cmd.Parameters.Add("DPurch", dateTimePicker1.Text);
            cmd.Parameters.Add("BStreet", street);
            cmd.Parameters.Add("Bgovernorate", Gov);
            cmd.Parameters.Add("manu", txt_Manufacturer.Text);
            cmd.Parameters.Add("Carmodel", txt_Car_Model.Text);
            cmd.Parameters.Add("TheRentalcost", txt_Rental_Cost.Text);
            cmd.Parameters.Add("eSize", txt_Engine_Size.Text);
            cmd.Parameters.Add("PassNO", txt_PassNO.Text);
            cmd.Parameters.Add("ProducYear", txt_Production_Year.Text);
            cmd.Parameters.Add("CarIsRented", IsRented);
            cmd.Parameters.Add("purch_cost", txt_Purchase_Cost.Text);
            cmd.Parameters.Add("fType", txt_Fuel_Type.Text);
            cmd.Parameters.Add("BeRepaired", needRepair);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Car is added successfully");
        }

        private void txt_Fuel_Type_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void txt_Purchase_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ControlForm cForm = new ControlForm();

            this.Hide();
            cForm.Show();
            this.Close();
        }

        private void InsertNewCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void InsertNewCar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}