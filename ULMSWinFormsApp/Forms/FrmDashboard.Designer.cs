namespace ULMSWinFormsApp.Forms
{
    partial class FrmDashboard
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
            lblTitle = new Label();
            btnStudentRegistration = new Button();
            btnCourseEnrollment = new Button();
            btnMarksCapture = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(96, 64);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ULMS Dashboard";
            // 
            // btnStudentRegistration
            // 
            btnStudentRegistration.Location = new Point(96, 162);
            btnStudentRegistration.Name = "btnStudentRegistration";
            btnStudentRegistration.Size = new Size(280, 72);
            btnStudentRegistration.TabIndex = 1;
            btnStudentRegistration.Text = "Student Registration";
            btnStudentRegistration.UseVisualStyleBackColor = true;
            btnStudentRegistration.Click += btnStudentRegistration_Click;
            // 
            // btnCourseEnrollment
            // 
            btnCourseEnrollment.Location = new Point(419, 165);
            btnCourseEnrollment.Name = "btnCourseEnrollment";
            btnCourseEnrollment.Size = new Size(264, 69);
            btnCourseEnrollment.TabIndex = 2;
            btnCourseEnrollment.Text = "Course Enrolment";
            btnCourseEnrollment.UseVisualStyleBackColor = true;
            btnCourseEnrollment.Click += btnCourseEnrollment_Click;
            // 
            // btnMarksCapture
            // 
            btnMarksCapture.Location = new Point(96, 259);
            btnMarksCapture.Name = "btnMarksCapture";
            btnMarksCapture.Size = new Size(280, 68);
            btnMarksCapture.TabIndex = 3;
            btnMarksCapture.Text = "Marks Capture";
            btnMarksCapture.UseVisualStyleBackColor = true;
            btnMarksCapture.Click += btnMarksCapture_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(419, 259);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(264, 66);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(542, 64);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(141, 54);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnMarksCapture);
            Controls.Add(btnCourseEnrollment);
            Controls.Add(btnStudentRegistration);
            Controls.Add(lblTitle);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Umoja Learning Management System - Dashboard";
            Click += btnStudentRegistration_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnStudentRegistration;
        private Button btnCourseEnrollment;
        private Button btnMarksCapture;
        private Button btnReports;
        private Button btnLogout;
    }
}