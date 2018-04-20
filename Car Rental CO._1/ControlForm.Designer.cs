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
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageGraggesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRevenuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAnExistsingCarInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(581, 326);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCarsToolStripMenuItem,
            this.updateAnExistsingCarInfoToolStripMenuItem,
            this.deleteCarToolStripMenuItem,
            this.showToolStripMenuItem,
            this.showRevenuesToolStripMenuItem,
            this.manageGraggesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 361);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuAdmin";
            // 
            // manageGraggesToolStripMenuItem
            // 
            this.manageGraggesToolStripMenuItem.AutoSize = false;
            this.manageGraggesToolStripMenuItem.Name = "manageGraggesToolStripMenuItem";
            this.manageGraggesToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.manageGraggesToolStripMenuItem.Text = "Manage Garages";
            this.manageGraggesToolStripMenuItem.Click += new System.EventHandler(this.manageGraggesToolStripMenuItem_Click);
            // 
            // manageCarsToolStripMenuItem
            // 
            this.manageCarsToolStripMenuItem.AutoSize = false;
            this.manageCarsToolStripMenuItem.Name = "manageCarsToolStripMenuItem";
            this.manageCarsToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.manageCarsToolStripMenuItem.Text = "Insert a new car info.";
            this.manageCarsToolStripMenuItem.Click += new System.EventHandler(this.manageCarsToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.AutoSize = false;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.showToolStripMenuItem.Text = "Show Expenditure";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // showRevenuesToolStripMenuItem
            // 
            this.showRevenuesToolStripMenuItem.AutoSize = false;
            this.showRevenuesToolStripMenuItem.Name = "showRevenuesToolStripMenuItem";
            this.showRevenuesToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.showRevenuesToolStripMenuItem.Text = "Show Revenues";
            this.showRevenuesToolStripMenuItem.Click += new System.EventHandler(this.showRevenuesToolStripMenuItem_Click);
            // 
            // updateAnExistsingCarInfoToolStripMenuItem
            // 
            this.updateAnExistsingCarInfoToolStripMenuItem.AutoSize = false;
            this.updateAnExistsingCarInfoToolStripMenuItem.Name = "updateAnExistsingCarInfoToolStripMenuItem";
            this.updateAnExistsingCarInfoToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.updateAnExistsingCarInfoToolStripMenuItem.Text = "Update an existing car info.";
            this.updateAnExistsingCarInfoToolStripMenuItem.Click += new System.EventHandler(this.updateAnExistsingCarInfoToolStripMenuItem_Click);
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.AutoSize = false;
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteCarToolStripMenuItem.Text = "Delete car";
            this.deleteCarToolStripMenuItem.Click += new System.EventHandler(this.deleteCarToolStripMenuItem_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlForm_FormClosed);
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageGraggesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRevenuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAnExistsingCarInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCarToolStripMenuItem;
    }
}