namespace ULMSWinFormsApp.Forms
{
    partial class FrmMarksCapture
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
            txtMarkStudentId = new TextBox();
            label2 = new Label();
            txtMarkStudentName = new TextBox();
            label3 = new Label();
            txtSubject1 = new TextBox();
            label4 = new Label();
            txtSubject2 = new TextBox();
            label5 = new Label();
            txtSubject3 = new TextBox();
            btnCalculateResults = new Button();
            btnClearMarks = new Button();
            btnBackMarks = new Button();
            txtMarksOutput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // txtMarkStudentId
            // 
            txtMarkStudentId.Location = new Point(181, 34);
            txtMarkStudentId.Name = "txtMarkStudentId";
            txtMarkStudentId.Size = new Size(256, 27);
            txtMarkStudentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 75);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // txtMarkStudentName
            // 
            txtMarkStudentName.Location = new Point(181, 75);
            txtMarkStudentName.Name = "txtMarkStudentName";
            txtMarkStudentName.Size = new Size(256, 27);
            txtMarkStudentName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 131);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 4;
            label3.Text = "Subject 1 Mark";
            // 
            // txtSubject1
            // 
            txtSubject1.Location = new Point(181, 131);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(256, 27);
            txtSubject1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 188);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 6;
            label4.Text = "Subject 2 Mark";
            // 
            // txtSubject2
            // 
            txtSubject2.Location = new Point(181, 188);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(256, 27);
            txtSubject2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 240);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "Subject 3 Mark";
            // 
            // txtSubject3
            // 
            txtSubject3.Location = new Point(181, 240);
            txtSubject3.Name = "txtSubject3";
            txtSubject3.Size = new Size(256, 27);
            txtSubject3.TabIndex = 9;
            // 
            // btnCalculateResults
            // 
            btnCalculateResults.Location = new Point(49, 310);
            btnCalculateResults.Name = "btnCalculateResults";
            btnCalculateResults.Size = new Size(139, 45);
            btnCalculateResults.TabIndex = 10;
            btnCalculateResults.Text = "Calculate Results";
            btnCalculateResults.UseVisualStyleBackColor = true;
            btnCalculateResults.Click += btnCalculateResults_Click;
            // 
            // btnClearMarks
            // 
            btnClearMarks.Location = new Point(213, 310);
            btnClearMarks.Name = "btnClearMarks";
            btnClearMarks.Size = new Size(139, 45);
            btnClearMarks.TabIndex = 11;
            btnClearMarks.Text = "Clear";
            btnClearMarks.UseVisualStyleBackColor = true;
            btnClearMarks.Click += btnClearMarks_Click;
            // 
            // btnBackMarks
            // 
            btnBackMarks.Location = new Point(373, 310);
            btnBackMarks.Name = "btnBackMarks";
            btnBackMarks.Size = new Size(139, 45);
            btnBackMarks.TabIndex = 12;
            btnBackMarks.Text = "Back";
            btnBackMarks.UseVisualStyleBackColor = true;
            btnBackMarks.Click += btnBackMarks_Click;
            // 
            // txtMarksOutput
            // 
            txtMarksOutput.Location = new Point(486, 37);
            txtMarksOutput.Multiline = true;
            txtMarksOutput.Name = "txtMarksOutput";
            txtMarksOutput.ReadOnly = true;
            txtMarksOutput.Size = new Size(339, 212);
            txtMarksOutput.TabIndex = 13;
            // 
            // FrmMarksCapture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(txtMarksOutput);
            Controls.Add(btnBackMarks);
            Controls.Add(btnClearMarks);
            Controls.Add(btnCalculateResults);
            Controls.Add(txtSubject3);
            Controls.Add(label5);
            Controls.Add(txtSubject2);
            Controls.Add(label4);
            Controls.Add(txtSubject1);
            Controls.Add(label3);
            Controls.Add(txtMarkStudentName);
            Controls.Add(label2);
            Controls.Add(txtMarkStudentId);
            Controls.Add(label1);
            Name = "FrmMarksCapture";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Umoja Learning Management System - Marks Capture";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMarkStudentId;
        private Label label2;
        private TextBox txtMarkStudentName;
        private Label label3;
        private TextBox txtSubject1;
        private Label label4;
        private TextBox txtSubject2;
        private Label label5;
        private TextBox txtSubject3;
        private Button btnCalculateResults;
        private Button btnClearMarks;
        private Button btnBackMarks;
        private TextBox txtMarksOutput;
    }
}