namespace GradingProgram
{
    partial class frmSetUpGrading
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
            this.gbLanguageGrading = new System.Windows.Forms.GroupBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbPython = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.cbPascal = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.gbExamSetUp = new System.Windows.Forms.GroupBox();
            this.cbAutomaticCandidateMirroring = new System.Windows.Forms.CheckBox();
            this.cbGradingNoBuilt = new System.Windows.Forms.CheckBox();
            this.gbQuestionSetUp = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbLanguageGrading.SuspendLayout();
            this.gbExamSetUp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguageGrading
            // 
            this.gbLanguageGrading.Controls.Add(this.cbAll);
            this.gbLanguageGrading.Controls.Add(this.cbPython);
            this.gbLanguageGrading.Controls.Add(this.cbJava);
            this.gbLanguageGrading.Controls.Add(this.cbPascal);
            this.gbLanguageGrading.Controls.Add(this.cbC);
            this.gbLanguageGrading.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLanguageGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLanguageGrading.Location = new System.Drawing.Point(0, 0);
            this.gbLanguageGrading.Name = "gbLanguageGrading";
            this.gbLanguageGrading.Size = new System.Drawing.Size(467, 172);
            this.gbLanguageGrading.TabIndex = 1;
            this.gbLanguageGrading.TabStop = false;
            this.gbLanguageGrading.Text = "Ngôn ngữ chấm";
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(68, 129);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(59, 19);
            this.cbAll.TabIndex = 4;
            this.cbAll.Text = "Tất cả";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbPython
            // 
            this.cbPython.AutoSize = true;
            this.cbPython.Location = new System.Drawing.Point(68, 104);
            this.cbPython.Name = "cbPython";
            this.cbPython.Size = new System.Drawing.Size(99, 19);
            this.cbPython.TabIndex = 3;
            this.cbPython.Text = "Python 3 (.py)";
            this.cbPython.UseVisualStyleBackColor = true;
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(68, 79);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(87, 19);
            this.cbJava.TabIndex = 2;
            this.cbJava.Text = "Java (.java)";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // cbPascal
            // 
            this.cbPascal.AutoSize = true;
            this.cbPascal.Location = new System.Drawing.Point(68, 54);
            this.cbPascal.Name = "cbPascal";
            this.cbPascal.Size = new System.Drawing.Size(97, 19);
            this.cbPascal.TabIndex = 1;
            this.cbPascal.Text = "Pascal (.pas)";
            this.cbPascal.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(68, 29);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(93, 19);
            this.cbC.TabIndex = 0;
            this.cbC.Text = "C/C++ (.cpp)";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // gbExamSetUp
            // 
            this.gbExamSetUp.Controls.Add(this.cbAutomaticCandidateMirroring);
            this.gbExamSetUp.Controls.Add(this.cbGradingNoBuilt);
            this.gbExamSetUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbExamSetUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExamSetUp.Location = new System.Drawing.Point(0, 172);
            this.gbExamSetUp.Name = "gbExamSetUp";
            this.gbExamSetUp.Size = new System.Drawing.Size(467, 85);
            this.gbExamSetUp.TabIndex = 2;
            this.gbExamSetUp.TabStop = false;
            this.gbExamSetUp.Text = "Kì thi";
            // 
            // cbAutomaticCandidateMirroring
            // 
            this.cbAutomaticCandidateMirroring.AutoSize = true;
            this.cbAutomaticCandidateMirroring.Location = new System.Drawing.Point(68, 45);
            this.cbAutomaticCandidateMirroring.Name = "cbAutomaticCandidateMirroring";
            this.cbAutomaticCandidateMirroring.Size = new System.Drawing.Size(370, 19);
            this.cbAutomaticCandidateMirroring.TabIndex = 2;
            this.cbAutomaticCandidateMirroring.Text = "Chỉ chấm sinh viên thuộc kì thi (không thêm sinh viên khi chấm)";
            this.cbAutomaticCandidateMirroring.UseVisualStyleBackColor = true;
            // 
            // cbGradingNoBuilt
            // 
            this.cbGradingNoBuilt.AutoSize = true;
            this.cbGradingNoBuilt.Location = new System.Drawing.Point(68, 20);
            this.cbGradingNoBuilt.Name = "cbGradingNoBuilt";
            this.cbGradingNoBuilt.Size = new System.Drawing.Size(246, 19);
            this.cbGradingNoBuilt.TabIndex = 1;
            this.cbGradingNoBuilt.Text = "Chấm không built (chấm file .exe, .class)";
            this.cbGradingNoBuilt.UseVisualStyleBackColor = true;
            // 
            // gbQuestionSetUp
            // 
            this.gbQuestionSetUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuestionSetUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestionSetUp.Location = new System.Drawing.Point(0, 257);
            this.gbQuestionSetUp.Name = "gbQuestionSetUp";
            this.gbQuestionSetUp.Size = new System.Drawing.Size(467, 253);
            this.gbQuestionSetUp.TabIndex = 3;
            this.gbQuestionSetUp.TabStop = false;
            this.gbQuestionSetUp.Text = "Bài thi";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(369, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 50);
            this.panel1.TabIndex = 5;
            // 
            // frmSetUpGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbQuestionSetUp);
            this.Controls.Add(this.gbExamSetUp);
            this.Controls.Add(this.gbLanguageGrading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetUpGrading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt chấm điểm";
            this.gbLanguageGrading.ResumeLayout(false);
            this.gbLanguageGrading.PerformLayout();
            this.gbExamSetUp.ResumeLayout(false);
            this.gbExamSetUp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbLanguageGrading;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.CheckBox cbPython;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.CheckBox cbPascal;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.GroupBox gbExamSetUp;
        private System.Windows.Forms.CheckBox cbGradingNoBuilt;
        private System.Windows.Forms.CheckBox cbAutomaticCandidateMirroring;
        private System.Windows.Forms.GroupBox gbQuestionSetUp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}