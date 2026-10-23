using System.Drawing;
using System.Windows.Forms;

namespace LabStream
{
    partial class FrmMainMenu : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLab1 = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnLab1
            this.btnLab1.Location = new System.Drawing.Point(50, 40);
            this.btnLab1.Name = "btnLab1";
            this.btnLab1.Size = new System.Drawing.Size(210, 40);
            this.btnLab1.TabIndex = 1;
            this.btnLab1.Text = "Basic Text File (FrmLab1)";
            this.btnLab1.Click += new System.EventHandler(this.btnLab1_Click);

            // btnRegistration
            this.btnRegistration.Location = new System.Drawing.Point(50, 100);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(210, 40);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Challenge (Registration)";
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);

            // btnOpenTextFile
            this.btnOpenTextFile.Location = new System.Drawing.Point(50, 160);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(210, 40);
            this.btnOpenTextFile.TabIndex = 2;
            this.btnOpenTextFile.Text = "Open Text File";
            this.btnOpenTextFile.Click += new System.EventHandler(this.btnOpenTextFile_Click);

            // FrmMainMenu
            this.ClientSize = new System.Drawing.Size(311, 240);
            this.Controls.Add(this.btnOpenTextFile);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLab1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnLab1;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnOpenTextFile;
    }
}