using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ULMSWinFormsApp.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void btnStudentRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening registration form...");

            FrmStudentRegistration registrationForm = new FrmStudentRegistration();
            registrationForm.ShowDialog();
        }

        private void btnCourseEnrollment_Click(object sender, EventArgs e)
        {
            FrmCourseEnrollment enrollmentForm = new FrmCourseEnrollment();
            enrollmentForm.ShowDialog();
        }

        private void btnMarksCapture_Click(object sender, EventArgs e)
        {
            FrmMarksCapture marksForm = new FrmMarksCapture();
            marksForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmReports reportsForm = new FrmReports();
            reportsForm.ShowDialog();
        }
    }
}
