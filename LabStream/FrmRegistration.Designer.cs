namespace LabStream
{
    partial class FrmRegistration : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtStudentNo = new TextBox();
            label2 = new Label();
            cbProgram = new ComboBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtMI = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            label7 = new Label();
            cbGender = new ComboBox();
            label8 = new Label();
            dtpBirthday = new DateTimePicker();
            label9 = new Label();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            btnRecords = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 18;
            label1.Text = "Student No.:";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(107, 18);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(172, 23);
            txtStudentNo.TabIndex = 17;
            // 
            // label2
            // 
            label2.Location = new Point(300, 20);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 16;
            label2.Text = "Program:";
            // 
            // cbProgram
            // 
            cbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science" });
            cbProgram.Location = new Point(379, 17);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(202, 24);
            cbProgram.TabIndex = 15;
            // 
            // label3
            // 
            label3.Location = new Point(20, 60);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 14;
            label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(172, 23);
            txtLastName.TabIndex = 13;
            // 
            // label4
            // 
            label4.Location = new Point(300, 60);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 12;
            label4.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(379, 57);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(120, 23);
            txtFirstName.TabIndex = 11;
            // 
            // label5
            // 
            label5.Location = new Point(515, 60);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 10;
            label5.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(551, 57);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(30, 23);
            txtMI.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(20, 100);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 8;
            label6.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(107, 97);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(60, 23);
            txtAge.TabIndex = 7;
            // 
            // label7
            // 
            label7.Location = new Point(300, 100);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(379, 100);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(120, 24);
            cbGender.TabIndex = 5;
            // 
            // label8
            // 
            label8.Location = new Point(20, 140);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 4;
            label8.Text = "Birthday:";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(90, 140);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(238, 23);
            dtpBirthday.TabIndex = 3;
            // 
            // label9
            // 
            label9.Location = new Point(360, 140);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 2;
            label9.Text = "Contact No.:";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(447, 137);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(134, 23);
            txtContactNo.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(243, 185);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 30);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(481, 185);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(100, 30);
            btnRecords.TabIndex = 20;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // FrmRegistration
            // 
            ClientSize = new Size(602, 240);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label9);
            Controls.Add(dtpBirthday);
            Controls.Add(label8);
            Controls.Add(cbGender);
            Controls.Add(label7);
            Controls.Add(txtAge);
            Controls.Add(label6);
            Controls.Add(txtMI);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(cbProgram);
            Controls.Add(label2);
            Controls.Add(txtStudentNo);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "FrmRegistration";
            Text = "Registration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8, label9;
        private System.Windows.Forms.TextBox txtStudentNo, txtLastName, txtFirstName, txtMI, txtAge, txtContactNo;
        private System.Windows.Forms.ComboBox cbProgram, cbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnRegister, btnRecords;
    }
}