using _DVLD.Applications.Release_Detained_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DVLD.Licenses.Detain_License
{
    public partial class frmManageDetainLicenses : Form
    {
        public frmManageDetainLicenses()
        {
            InitializeComponent();
        }

        void OpenChildForm(Form ChildForm)
        {

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlDetainLicenses.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }

        private void btnListDetainedLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListDetainedLicenses());
        }
    }
}
