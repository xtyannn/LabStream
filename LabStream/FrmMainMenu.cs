using System;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnLab1_Click(object sender, EventArgs e)
        {
            FrmLab1 frmLab1 = new FrmLab1();
            frmLab1.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Show();
        }
    }
}