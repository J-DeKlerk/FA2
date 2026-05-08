namespace ULMSWinFormsApp.Forms
{
    partial class FrmStudentRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtStudentId = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            cmbProgramme = new ComboBox();
            btnSaveStudent = new Button();
            btnClearStudent = new Button();
            btnBackToDashboard = new Button();
            txtStudentOutput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 69);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(150, 66);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(320, 27);
            txtStudentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 112);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(320, 27);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 167);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 27);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 220);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(154, 217);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(316, 27);
            txtAge.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 263);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 8;
            label5.Text = "Programme";
            // 
            // cmbProgramme
            // 
            cmbProgramme.FormattingEnabled = true;
            cmbProgramme.Items.AddRange(new object[] { "Software Development", "Software Engineering", "Data Science", "Cloud Computing", "Cyber Security" });
            cmbProgramme.Location = new Point(150, 260);
            cmbProgramme.Name = "cmbProgramme";
            cmbProgramme.Size = new Size(320, 28);
            cmbProgramme.TabIndex = 9;
            // 
            // btnSaveStudent
            // 
            btnSaveStudent.Location = new Point(53, 334);
            btnSaveStudent.Name = "btnSaveStudent";
            btnSaveStudent.Size = new Size(148, 49);
            btnSaveStudent.TabIndex = 10;
            btnSaveStudent.Text = "Save Student";
            btnSaveStudent.UseVisualStyleBackColor = true;
            btnSaveStudent.Click += btnSaveStudent_Click;
            // 
            // btnClearStudent
            // 
            btnClearStudent.Location = new Point(233, 334);
            btnClearStudent.Name = "btnClearStudent";
            btnClearStudent.Size = new Size(93, 49);
            btnClearStudent.TabIndex = 11;
            btnClearStudent.Text = "Clear";
            btnClearStudent.UseVisualStyleBackColor = true;
            btnClearStudent.Click += btnClearStudent_Click;
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.Location = new Point(374, 334);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(97, 49);
            btnBackToDashboard.TabIndex = 12;
            btnBackToDashboard.Text = "Back";
            btnBackToDashboard.UseVisualStyleBackColor = true;
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // txtStudentOutput
            // 
            txtStudentOutput.Location = new Point(537, 69);
            txtStudentOutput.Multiline = true;
            txtStudentOutput.Name = "txtStudentOutput";
            txtStudentOutput.ReadOnly = true;
            txtStudentOutput.Size = new Size(304, 259);
            txtStudentOutput.TabIndex = 13;
            // 
            // FrmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(txtStudentOutput);
            Controls.Add(btnBackToDashboard);
            Controls.Add(btnClearStudent);
            Controls.Add(btnSaveStudent);
            Controls.Add(cmbProgramme);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtStudentId);
            Controls.Add(label1);
            Name = "FrmStudentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Umoja Learning Management System - Student Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentId;
        private Label label2;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private ComboBox cmbProgramme;
        private Button btnSaveStudent;
        private Button btnClearStudent;
        private Button btnBackToDashboard;
        private TextBox txtStudentOutput;
    }
}