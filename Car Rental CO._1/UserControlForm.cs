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
    public partial class UserControlForm : Form
    {
        private Button buttonClose;
        private Button buttonShowRentals;
        UserLoginSignUpForm loginSignupForm;
        ShowRentals ShowRentalsForm;

        public UserControlForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            loginSignupForm = new UserLoginSignUpForm();

            loginSignupForm.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShowRentals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(33, 323);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // buttonShowRentals
            // 
            this.buttonShowRentals.Location = new System.Drawing.Point(33, 32);
            this.buttonShowRentals.Name = "buttonShowRentals";
            this.buttonShowRentals.Size = new System.Drawing.Size(100, 35);
            this.buttonShowRentals.TabIndex = 1;
            this.buttonShowRentals.Text = "Show rentals";
            this.buttonShowRentals.UseVisualStyleBackColor = true;
            this.buttonShowRentals.Click += new System.EventHandler(this.buttonShowRentals_Click);
            // 
            // UserControlForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonShowRentals);
            this.Controls.Add(this.buttonClose);
            this.Name = "UserControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserControlForm_FormClosing);
            this.ResumeLayout(false);

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UserControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void buttonShowRentals_Click(object sender, EventArgs e)
        {
            ShowRentalsForm = new ShowRentals();
            ShowRentalsForm.Show();
            this.Hide();
        }
    }
}
