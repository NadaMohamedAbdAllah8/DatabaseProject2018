namespace Car_Rental_CO._1
{
    partial class ControlForm
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete_car = new System.Windows.Forms.Button();
            this.buttonShowExpenditure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(21, 12);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(100, 35);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert car info.";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(21, 71);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update car info.";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(322, 302);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete_car
            // 
            this.buttonDelete_car.Location = new System.Drawing.Point(21, 134);
            this.buttonDelete_car.Name = "buttonDelete_car";
            this.buttonDelete_car.Size = new System.Drawing.Size(100, 35);
            this.buttonDelete_car.TabIndex = 3;
            this.buttonDelete_car.Text = "Delete car";
            this.buttonDelete_car.UseVisualStyleBackColor = true;
            this.buttonDelete_car.Click += new System.EventHandler(this.buttonDelete_car_Click);
            // 
            // buttonShowExpenditure
            // 
            this.buttonShowExpenditure.Location = new System.Drawing.Point(21, 189);
            this.buttonShowExpenditure.Name = "buttonShowExpenditure";
            this.buttonShowExpenditure.Size = new System.Drawing.Size(100, 35);
            this.buttonShowExpenditure.TabIndex = 4;
            this.buttonShowExpenditure.Text = "Show Expenditure";
            this.buttonShowExpenditure.UseVisualStyleBackColor = true;
            this.buttonShowExpenditure.Click += new System.EventHandler(this.buttonShowExpenditure_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonShowExpenditure);
            this.Controls.Add(this.buttonDelete_car);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete_car;
        private System.Windows.Forms.Button buttonShowExpenditure;
    }
}