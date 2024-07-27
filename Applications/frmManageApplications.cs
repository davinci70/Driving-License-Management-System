using _DVLD.Applications.International_License;
using _DVLD.Applications.Local_Driving_License;
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
    public partial class frmManageApplications : Form
    {
        public frmManageApplications()
        {
            InitializeComponent();
        }

        void OpenChildForm(Form ChildForm)
        {

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlManageApplications.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void btnLocalLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListLocalDrivingLicesnseApplications());
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInternationalLicenses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListInternationalLicesnseApplications());
        }
    }
}
