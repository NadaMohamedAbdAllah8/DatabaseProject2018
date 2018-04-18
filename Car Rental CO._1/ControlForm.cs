using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_CO._1
{
    public partial class ControlForm : Form
    {
        UpdateCarInfoFrom UpdateCarInfo = new UpdateCarInfoFrom();
        InsertNewCar InsertForm = new InsertNewCar();
        DeleteCar dForm = new DeleteCar();
        ShowExpenditure ShoWEx;
        ShowRevenuesForm ShowRevForm;

        public ControlForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCarInfo.Show();
            this.Hide();
            //   this.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            InsertForm.Show();
            this.Hide();
            // this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // this.Close();
            this.Dispose();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_car_Click(object sender, EventArgs e)
        {
            dForm.Show();
            this.Hide();

        }

        private void buttonShowExpenditure_Click(object sender, EventArgs e)
        {
            ShoWEx = new ShowExpenditure();
            ShoWEx.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowRevForm = new ShowRevenuesForm();
            ShowRevForm.Show();
            this.Hide();
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void ControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}