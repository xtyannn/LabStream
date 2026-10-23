using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
            {
                MessageBox.Show("Please enter the Student Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the First Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMI.Text))
            {
                MessageBox.Show("Please enter the Middle Initial.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbProgram.Text))
            {
                MessageBox.Show("Please select a Program.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbGender.Text))
            {
                MessageBox.Show("Please select a Gender.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please enter the Age.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Please enter the Contact Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentNo = txtStudentNo.Text;
            string fileName = studentNo + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] registrationDetails = new string[]
            {
                "Student No.: " + studentNo,
                $"Full Name: {txtLastName.Text}, {txtFirstName.Text}, {txtMI.Text}.",
                "Program: " + cbProgram.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No. " + txtContactNo.Text
            };

            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
                {
                    foreach (string detail in registrationDetails)
                    {
                        outputFile.WriteLine(detail);
                    }
                }

                MessageBox.Show("Registration file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save registration data. Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.ShowDialog();
            this.Close();
        }
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
        }
    }
}