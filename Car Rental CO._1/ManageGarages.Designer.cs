namespace proj_db2
{
    partial class ManageGarages
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
            this.save_button = new System.Windows.Forms.Button();
            this.dgv_garage = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_garage)).BeginInit();
            this.SuspendLayout();
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(580, 313);
            this.save_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(82, 37);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "Save All";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // dgv_garage
            // 
            this.dgv_garage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_garage.Location = new System.Drawing.Point(25, 11);
            this.dgv_garage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_garage.Name = "dgv_garage";
            this.dgv_garage.RowTemplate.Height = 26;
            this.dgv_garage.Size = new System.Drawing.Size(600, 280);
            this.dgv_garage.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(35, 313);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 37);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ManageGarages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dgv_garage);
            this.Controls.Add(this.save_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageGarages";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageGarages_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageGarages_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_garage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView dgv_garage;
        private System.Windows.Forms.Button buttonBack;
    }
}

