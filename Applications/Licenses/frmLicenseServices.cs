using _DVLD.Applications.Release_Detained_License;
using _DVLD.Applications.Renew_Application_License;
using _DVLD.Applications.ReplaceLostOrDamagedLicense;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DVLD
{
    public partial class frmLicenseServices : Form
    {
        public frmLicenseServices()
        {
            InitializeComponent();
        }

        void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlDrivingLicenseServices.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewDrivingLicense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNewLicense()); 
        }

        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frm = new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }
    }
}
