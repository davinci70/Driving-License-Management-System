using _DVLD.Licenses.Detain_License;
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
    public partial class frmApplications : Form
    {
        public frmApplications()
        {
            InitializeComponent();
        }

        void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlApplication.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageApplicationTypes());
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListTestTypes());
        }

        private void btnDrivingLicenseServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLicenseServices());
        }

        private void btnManageApplications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageApplications());
        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageDetainLicenses());
        }
    }
}
