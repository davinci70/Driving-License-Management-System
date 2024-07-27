namespace _DVLD
{
    partial class frmManageApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageApplications));
            this.pnlManageApplications = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnInternationalLicenses = new System.Windows.Forms.Button();
            this.btnLocalLicenses = new System.Windows.Forms.Button();
            this.pnlManageApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageApplications
            // 
            this.pnlManageApplications.Controls.Add(this.lblMode);
            this.pnlManageApplications.Controls.Add(this.pbBack);
            this.pnlManageApplications.Controls.Add(this.btnInternationalLicenses);
            this.pnlManageApplications.Controls.Add(this.btnLocalLicenses);
            this.pnlManageApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageApplications.Location = new System.Drawing.Point(0, 0);
            this.pnlManageApplications.Name = "pnlManageApplications";
            this.pnlManageApplications.Size = new System.Drawing.Size(1062, 543);
            this.pnlManageApplications.TabIndex = 1;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
            this.lblMode.Location = new System.Drawing.Point(243, 52);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(576, 58);
            this.lblMode.TabIndex = 27;
            this.lblMode.Text = "Manage Applications";
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(36, 33);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 26;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnInternationalLicenses
            // 
            this.btnInternationalLicenses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternationalLicenses.Image = ((System.Drawing.Image)(resources.GetObject("btnInternationalLicenses.Image")));
            this.btnInternationalLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicenses.Location = new System.Drawing.Point(572, 228);
            this.btnInternationalLicenses.Name = "btnInternationalLicenses";
            this.btnInternationalLicenses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInternationalLicenses.Size = new System.Drawing.Size(260, 108);
            this.btnInternationalLicenses.TabIndex = 25;
            this.btnInternationalLicenses.Text = "              International License                Applications";
            this.btnInternationalLicenses.UseVisualStyleBackColor = true;
            this.btnInternationalLicenses.Click += new System.EventHandler(this.btnInternationalLicenses_Click);
            // 
            // btnLocalLicenses
            // 
            this.btnLocalLicenses.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalLicenses.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalLicenses.Image")));
            this.btnLocalLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalLicenses.Location = new System.Drawing.Point(237, 228);
            this.btnLocalLicenses.Name = "btnLocalLicenses";
            this.btnLocalLicenses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocalLicenses.Size = new System.Drawing.Size(260, 108);
            this.btnLocalLicenses.TabIndex = 24;
            this.btnLocalLicenses.Text = "          Local License            Applications";
            this.btnLocalLicenses.UseVisualStyleBackColor = true;
            this.btnLocalLicenses.Click += new System.EventHandler(this.btnLocalLicenses_Click);
            // 
            // frmManageApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 543);
            this.Controls.Add(this.pnlManageApplications);
            this.Name = "frmManageApplications";
            this.Text = "Manage Applications";
            this.pnlManageApplications.ResumeLayout(false);
            this.pnlManageApplications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageApplications;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnInternationalLicenses;
        private System.Windows.Forms.Button btnLocalLicenses;
    }
}