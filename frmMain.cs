using _DVLD.Drivers;
using _DVLD.Properties;
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
    public partial class frmMain : Form
    {
        public frmMain(Form frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        Form _frmLogin;

        void OpenChildForm(Form ChildForm)
        {

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HandleUserImage();
            lblCurrentUsername.Text = clsGlobal.CurrentUser.UserName;
        }

        void HandleUserImage()
        {
            if (clsGlobal.CurrentUser.PersonInfo.ImagePath == "")
            {
                if (clsGlobal.CurrentUser.PersonInfo.Gendor == 0)
                    pbCurrentUserPic.Image = Resources.man;
                else
                    pbCurrentUserPic.Image = Resources.woman;
            }
            else
                pbCurrentUserPic.ImageLocation = clsGlobal.CurrentUser.PersonInfo.ImagePath;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListPeople());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListUsers());
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccountSettings());
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmApplications());
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListDrivers());
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Close();
            _frmLogin.Show();
        }
    }
}
