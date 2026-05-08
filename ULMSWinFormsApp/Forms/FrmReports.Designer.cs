namespace ULMSWinFormsApp.Forms
{
    partial class FrmReports
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
            label2 = new Label();
            label3 = new Label();
            cmbReportType = new ComboBox();
            txtReportStudentId = new TextBox();
            btnGenerateReport = new Button();
            btnClearReport = new Button();
            btnBackReport = new Button();
            txtReportOutput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Report Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 56);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Student ID Filter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 37);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Report Output";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Student Summary Report", "Marks Report", "Enrollment Report" });
            cmbReportType.Location = new Point(43, 116);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(151, 28);
            cmbReportType.TabIndex = 3;
            // 
            // txtReportStudentId
            // 
            txtReportStudentId.Location = new Point(304, 116);
            txtReportStudentId.Name = "txtReportStudentId";
            txtReportStudentId.Size = new Size(125, 27);
            txtReportStudentId.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(12, 374);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(249, 31);
            btnGenerateReport.TabIndex = 5;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnClearReport
            // 
            btnClearReport.Location = new Point(304, 374);
            btnClearReport.Name = "btnClearReport";
            btnClearReport.Size = new Size(249, 31);
            btnClearReport.TabIndex = 6;
            btnClearReport.Text = "Clear";
            btnClearReport.UseVisualStyleBackColor = true;
            btnClearReport.Click += btnClearReport_Click;
            // 
            // btnBackReport
            // 
            btnBackReport.Location = new Point(605, 374);
            btnBackReport.Name = "btnBackReport";
            btnBackReport.Size = new Size(249, 31);
            btnBackReport.TabIndex = 7;
            btnBackReport.Text = "Back";
            btnBackReport.UseVisualStyleBackColor = true;
            btnBackReport.Click += btnBackReport_Click;
            // 
            // txtReportOutput
            // 
            txtReportOutput.Location = new Point(469, 88);
            txtReportOutput.Multiline = true;
            txtReportOutput.Name = "txtReportOutput";
            txtReportOutput.ReadOnly = true;
            txtReportOutput.ScrollBars = ScrollBars.Vertical;
            txtReportOutput.Size = new Size(477, 234);
            txtReportOutput.TabIndex = 8;
            // 
            // FrmReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 573);
            Controls.Add(txtReportOutput);
            Controls.Add(btnBackReport);
            Controls.Add(btnClearReport);
            Controls.Add(btnGenerateReport);
            Controls.Add(txtReportStudentId);
            Controls.Add(cmbReportType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Umoja Learning Management System - Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbReportType;
        private TextBox txtReportStudentId;
        private Button btnGenerateReport;
        private Button btnClearReport;
        private Button btnBackReport;
        private TextBox txtReportOutput;
    }
}