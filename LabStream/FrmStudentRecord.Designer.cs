namespace LabStream
{
    partial class FrmStudentRecord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            lvShowText = new ListView();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "View Record";
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(20, 50);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(380, 240);
            lvShowText.TabIndex = 1;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(420, 50);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 40);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(420, 100);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(110, 40);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(420, 150);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(110, 40);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            ClientSize = new Size(550, 320);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStudentRecord";
            Load += FrmStudentRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}