namespace _DVLD.Licenses.Detain_License
{
    partial class frmManageDetainLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainLicenses));
            this.pnlDetainLicenses = new System.Windows.Forms.Panel();
            this.btnRelease = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnListDetainedLicenses = new System.Windows.Forms.Button();
            this.pnlDetainLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetainLicenses
            // 
            this.pnlDetainLicenses.Controls.Add(this.btnRelease);
            this.pnlDetainLicenses.Controls.Add(this.pbBack);
            this.pnlDetainLicenses.Controls.Add(this.btnDetain);
            this.pnlDetainLicenses.Controls.Add(this.btnListDetainedLicenses);
            this.pnlDetainLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetainLicenses.Location = new System.Drawing.Point(0, 0);
            this.pnlDetainLicenses.Name = "pnlDetainLicenses";
            this.pnlDetainLicenses.Size = new System.Drawing.Size(1078, 582);
            this.pnlDetainLicenses.TabIndex = 0;
            // 
            // btnRelease
            // 
            this.btnRelease.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.Image = global::_DVLD.Properties.Resources.driving_license;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(727, 224);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRelease.Size = new System.Drawing.Size(260, 108);
            this.btnRelease.TabIndex = 35;
            this.btnRelease.Text = "     Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(36, 33);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 34;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::_DVLD.Properties.Resources.restricted;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(408, 226);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetain.Size = new System.Drawing.Size(260, 108);
            this.btnDetain.TabIndex = 33;
            this.btnDetain.Text = "     Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnListDetainedLicenses
            // 
            this.btnListDetainedLicenses.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDetainedLicenses.Image = ((System.Drawing.Image)(resources.GetObject("btnListDetainedLicenses.Image")));
            this.btnListDetainedLicenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListDetainedLicenses.Location = new System.Drawing.Point(89, 226);
            this.btnListDetainedLicenses.Name = "btnListDetainedLicenses";
            this.btnListDetainedLicenses.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnListDetainedLicenses.Size = new System.Drawing.Size(260, 108);
            this.btnListDetainedLicenses.TabIndex = 32;
            this.btnListDetainedLicenses.Text = "        Manage Detained        Licenses";
            this.btnListDetainedLicenses.UseVisualStyleBackColor = true;
            this.btnListDetainedLicenses.Click += new System.EventHandler(this.btnListDetainedLicenses_Click);
            // 
            // frmManageDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 582);
            this.Controls.Add(this.pnlDetainLicenses);
            this.Name = "frmManageDetainLicenses";
            this.Text = "Manage Detain Licenses";
            this.pnlDetainLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetainLicenses;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnListDetainedLicenses;
    }
}