using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text to save in the file.", "Text Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmFileName.SetFileName = string.Empty;

            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            if (string.IsNullOrEmpty(FrmFileName.SetFileName))
            {
                MessageBox.Show("File creation was cancelled because no filename was provided.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {
                    outputFile.WriteLine(getInput);
                }
                MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create the file. Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}