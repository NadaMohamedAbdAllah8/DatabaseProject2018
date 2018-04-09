using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Car_Rental_CO._1
{
    public partial class ShowRentals : Form
    {
        User_ViewRental_Report RentalsReport;

        UserControlForm cform;

        public ShowRentals()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            cform = new UserControlForm();
            this.Hide();
            cform.Show();
            this.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowRentals_Load(object sender, EventArgs e)
        {
            RentalsReport = new User_ViewRental_Report();

            //int UserSSN=;

            RentalsReport.SetParameterValue(0, HelperFunctions.GetSSN());

            crystalReportViewer1.ReportSource = RentalsReport;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
