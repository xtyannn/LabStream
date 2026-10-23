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
            this.Hide();
            FrmLab1 frmLab1 = new FrmLab1();
            frmLab1.ShowDialog();
            this.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
            this.Show();
        }

        private void btnOpenTextFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOpenTextFile frmOpenTextFile = new FrmOpenTextFile();
            frmOpenTextFile.ShowDialog();
            this.Show();
        }
    }
}