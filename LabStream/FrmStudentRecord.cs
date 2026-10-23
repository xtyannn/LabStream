using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Find Student Record";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;

            if (string.IsNullOrEmpty(path)) return;

            lvShowText.Items.Clear();

            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    lvShowText.Items.Add(_getText);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lvShowText.Items.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();
            this.Close();
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }
    }
}