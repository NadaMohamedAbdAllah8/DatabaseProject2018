namespace Car_Rental_CO._1
{
    partial class UserLoginSignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSignup_fromLogInForm = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxSSNLogIn = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLogIn = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SSN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New user?";
            // 
            // buttonSignup_fromLogInForm
            // 
            this.buttonSignup_fromLogInForm.Location = new System.Drawing.Point(570, 320);
            this.buttonSignup_fromLogInForm.Name = "buttonSignup_fromLogInForm";
            this.buttonSignup_fromLogInForm.Size = new System.Drawing.Size(75, 23);
            this.buttonSignup_fromLogInForm.TabIndex = 4;
            this.buttonSignup_fromLogInForm.Text = "Sign up!";
            this.buttonSignup_fromLogInForm.UseVisualStyleBackColor = true;
            this.buttonSignup_fromLogInForm.Click += new System.EventHandler(this.buttonSignup_fromLogInForm_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(379, 146);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxSSNLogIn
            // 
            this.textBoxSSNLogIn.Location = new System.Drawing.Point(278, 67);
            this.textBoxSSNLogIn.Name = "textBoxSSNLogIn";
            this.textBoxSSNLogIn.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSNLogIn.TabIndex = 6;
            // 
            // textBoxPasswordLogIn
            // 
            this.textBoxPasswordLogIn.Location = new System.Drawing.Point(278, 97);
            this.textBoxPasswordLogIn.Name = "textBoxPasswordLogIn";
            this.textBoxPasswordLogIn.PasswordChar = '*';
            this.textBoxPasswordLogIn.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordLogIn.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(25, 320);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // UserLoginSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxPasswordLogIn);
            this.Controls.Add(this.textBoxSSNLogIn);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSignup_fromLogInForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UserLoginSignUpForm";
            this.Text = "UserLoginSignUpForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserLoginSignUpForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLoginSignUpForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSignup_fromLogInForm;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxSSNLogIn;
        private System.Windows.Forms.TextBox textBoxPasswordLogIn;
        private System.Windows.Forms.Button buttonClose;
    }
}