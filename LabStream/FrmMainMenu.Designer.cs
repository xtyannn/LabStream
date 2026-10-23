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
            btnLab1 = new Button();
            btnRegistration = new Button();
            SuspendLayout();
            // 
            // btnLab1
            // 
            btnLab1.Location = new Point(50, 40);
            btnLab1.Name = "btnLab1";
            btnLab1.Size = new Size(210, 40);
            btnLab1.TabIndex = 1;
            btnLab1.Text = "Basic Text File (FrmLab1)";
            btnLab1.Click += btnLab1_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(50, 100);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(210, 40);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Challenge (Registration)";
            btnRegistration.Click += btnRegistration_Click;
            // 
            // FrmMainMenu
            // 
            ClientSize = new Size(311, 181);
            Controls.Add(btnRegistration);
            Controls.Add(btnLab1);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "FrmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnLab1;
        private System.Windows.Forms.Button btnRegistration;
    }
}