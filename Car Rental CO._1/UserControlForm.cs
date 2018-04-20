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
        private Button button1;
        ShowRentals ShowRentalsForm;
        private Button buttonUpdate_info;
        UserDeleteRentalcs DelRental_User;
        private Button button2;
        private Button button3;
        UpdateInfo_User UpdateInfo;
        AddorUpdateTelephones_User AddUpdateTeleForm;
        private Button button4;
        User_ChangePasswordForm PasswordForm;
        private Button button5;
        User_AddTelephones AddPhonesForm;
        UserLoginSignUpForm lsForm;


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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate_info = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Rental";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdate_info
            // 
            this.buttonUpdate_info.Location = new System.Drawing.Point(33, 157);
            this.buttonUpdate_info.Name = "buttonUpdate_info";
            this.buttonUpdate_info.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdate_info.TabIndex = 3;
            this.buttonUpdate_info.Text = "Update your Address";
            this.buttonUpdate_info.UseVisualStyleBackColor = true;
            this.buttonUpdate_info.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update your telephones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update your password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Add another telephone number";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(580, 326);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Sign out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserControlForm
            // 
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonUpdate_info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonShowRentals);
            this.Controls.Add(this.buttonClose);
            this.Name = "UserControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserControlForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserControlForm_FormClosed);
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
            this.Dispose();
        }

        private void UserControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelRental_User = new UserDeleteRentalcs();
            DelRental_User.Show();
            this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateInfo = new UpdateInfo_User();
            UpdateInfo.Show();
            this.Hide();
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddUpdateTeleForm = new AddorUpdateTelephones_User();
            AddUpdateTeleForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordForm = new User_ChangePasswordForm();
            PasswordForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPhonesForm = new User_AddTelephones();
            AddPhonesForm.Show();
            this.Hide();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HelperFunctions.SetSSN(0000000000);
            lsForm = new UserLoginSignUpForm();
            lsForm.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
