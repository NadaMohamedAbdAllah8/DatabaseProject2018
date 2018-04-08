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
    public partial class DeleteCar : Form
    {
        string constr = "Data Source=orcl;User ID=scott;Password=tiger;";
        OracleConnection conn;

        public DeleteCar()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ControlForm cForm = new ControlForm();

            this.Hide();
            cForm.Show();
            this.Dispose();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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

            cmd.CommandText = "delete car where registration_number=:regNO";

            cmd.Parameters.Add("regNO", textBoxRegNum.Text);

            int o = cmd.ExecuteNonQuery();

            MessageBox.Show("Car is deleted successfully");

            conn.Close();
        }

        private void textBoxRegNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}