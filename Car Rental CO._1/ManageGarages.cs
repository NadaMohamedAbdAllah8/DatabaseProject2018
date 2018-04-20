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


namespace proj_db2
{

    public partial class ManageGarages : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ManageGarages()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger";
            string cmdstr = "select * from Garage ";
            // adapter.SelectCommand.Parameters.Add("n", comboBox1.SelectedItem.ToString());
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_garage.DataSource = ds.Tables[0];

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("inserted and updated an deleted completed");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Car_Rental_CO._1.ControlForm cForm = new Car_Rental_CO._1.ControlForm();

            this.Hide();
            cForm.Show();
            this.Dispose();
        }

        private void ManageGarages_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void ManageGarages_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
