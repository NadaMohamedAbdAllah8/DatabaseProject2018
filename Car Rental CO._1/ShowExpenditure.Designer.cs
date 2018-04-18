namespace Car_Rental_CO._1
{
    partial class ShowExpenditure
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRepairCosts = new System.Windows.Forms.TextBox();
            this.textBoxMaintenanceCosts = new System.Windows.Forms.TextBox();
            this.textBoxInsuranceCosts = new System.Windows.Forms.TextBox();
            this.textBoxPurchasingCarsCosts = new System.Windows.Forms.TextBox();
            this.textBoxTotalCosts = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a month and a year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(577, 326);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repair Costs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maintenance Costs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Insurance Costs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Purchasing Cars Costs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Costs";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxRepairCosts
            // 
            this.textBoxRepairCosts.Location = new System.Drawing.Point(172, 81);
            this.textBoxRepairCosts.Name = "textBoxRepairCosts";
            this.textBoxRepairCosts.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepairCosts.TabIndex = 10;
            // 
            // textBoxMaintenanceCosts
            // 
            this.textBoxMaintenanceCosts.Location = new System.Drawing.Point(172, 136);
            this.textBoxMaintenanceCosts.Name = "textBoxMaintenanceCosts";
            this.textBoxMaintenanceCosts.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaintenanceCosts.TabIndex = 11;
            this.textBoxMaintenanceCosts.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxInsuranceCosts
            // 
            this.textBoxInsuranceCosts.Location = new System.Drawing.Point(172, 184);
            this.textBoxInsuranceCosts.Name = "textBoxInsuranceCosts";
            this.textBoxInsuranceCosts.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsuranceCosts.TabIndex = 12;
            // 
            // textBoxPurchasingCarsCosts
            // 
            this.textBoxPurchasingCarsCosts.Location = new System.Drawing.Point(172, 230);
            this.textBoxPurchasingCarsCosts.Name = "textBoxPurchasingCarsCosts";
            this.textBoxPurchasingCarsCosts.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchasingCarsCosts.TabIndex = 13;
            // 
            // textBoxTotalCosts
            // 
            this.textBoxTotalCosts.Location = new System.Drawing.Point(500, 237);
            this.textBoxTotalCosts.Name = "textBoxTotalCosts";
            this.textBoxTotalCosts.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalCosts.TabIndex = 14;
            this.textBoxTotalCosts.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(35, 326);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Text = "Back";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ShowExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTotalCosts);
            this.Controls.Add(this.textBoxPurchasingCarsCosts);
            this.Controls.Add(this.textBoxInsuranceCosts);
            this.Controls.Add(this.textBoxMaintenanceCosts);
            this.Controls.Add(this.textBoxRepairCosts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label1);
            this.Name = "ShowExpenditure";
            this.Text = "ShowExpenditure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowExpenditure_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowExpenditure_FormClosed);
            this.Load += new System.EventHandler(this.ShowExpenditure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRepairCosts;
        private System.Windows.Forms.TextBox textBoxMaintenanceCosts;
        private System.Windows.Forms.TextBox textBoxInsuranceCosts;
        private System.Windows.Forms.TextBox textBoxPurchasingCarsCosts;
        private System.Windows.Forms.TextBox textBoxTotalCosts;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonClose;
    }
}