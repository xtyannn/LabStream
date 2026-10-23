namespace LabStream
{
    partial class FrmOpenTextFile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lvShowText = new ListView();
            btnOpen = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(20, 20);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(440, 200);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(170, 240);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(140, 40);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            ClientSize = new Size(484, 301);
            Controls.Add(btnOpen);
            Controls.Add(lvShowText);
            Font = new Font("Microsoft Sans Serif", 12F);
            Name = "FrmOpenTextFile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmOpenTextFile";
            Load += FrmOpenTextFile_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}