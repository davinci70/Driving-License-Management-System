namespace _DVLD
{
    partial class frmNewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewLicense));
            this.btnInternationalLicense = new System.Windows.Forms.Button();
            this.btnLocalLicense = new System.Windows.Forms.Button();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInternationalLicense
            // 
            this.btnInternationalLicense.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternationalLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnInternationalLicense.Image")));
            this.btnInternationalLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternationalLicense.Location = new System.Drawing.Point(567, 228);
            this.btnInternationalLicense.Name = "btnInternationalLicense";
            this.btnInternationalLicense.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInternationalLicense.Size = new System.Drawing.Size(260, 108);
            this.btnInternationalLicense.TabIndex = 31;
            this.btnInternationalLicense.Text = "           International             License";
            this.btnInternationalLicense.UseVisualStyleBackColor = true;
            this.btnInternationalLicense.Click += new System.EventHandler(this.btnInternationalLicense_Click);
            // 
            // btnLocalLicense
            // 
            this.btnLocalLicense.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalLicense.Image")));
            this.btnLocalLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalLicense.Location = new System.Drawing.Point(232, 228);
            this.btnLocalLicense.Name = "btnLocalLicense";
            this.btnLocalLicense.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLocalLicense.Size = new System.Drawing.Size(260, 108);
            this.btnLocalLicense.TabIndex = 30;
            this.btnLocalLicense.Text = "         Local License";
            this.btnLocalLicense.UseVisualStyleBackColor = true;
            this.btnLocalLicense.Click += new System.EventHandler(this.btnLocalLicense_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 12);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(36, 33);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 29;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(125)))), ((int)(((byte)(157)))));
            this.lblMode.Location = new System.Drawing.Point(273, 52);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(518, 58);
            this.lblMode.TabIndex = 28;
            this.lblMode.Text = "Choose a license?";
            // 
            // frmNewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 504);
            this.Controls.Add(this.btnInternationalLicense);
            this.Controls.Add(this.btnLocalLicense);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblMode);
            this.Name = "frmNewLicense";
            this.Text = "New License";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInternationalLicense;
        private System.Windows.Forms.Button btnLocalLicense;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lblMode;
    }
}