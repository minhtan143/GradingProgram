namespace GradingProgram
{
    partial class frmResultDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvQuestionsDetail = new System.Windows.Forms.DataGridView();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegrade = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExamID = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSumMark = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng điểm:";
            // 
            // dgvQuestionsDetail
            // 
            this.dgvQuestionsDetail.AllowUserToAddRows = false;
            this.dgvQuestionsDetail.AllowUserToDeleteRows = false;
            this.dgvQuestionsDetail.AllowUserToResizeColumns = false;
            this.dgvQuestionsDetail.AllowUserToResizeRows = false;
            this.dgvQuestionsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Test,
            this.Mark,
            this.Info});
            this.dgvQuestionsDetail.Location = new System.Drawing.Point(108, 67);
            this.dgvQuestionsDetail.MultiSelect = false;
            this.dgvQuestionsDetail.Name = "dgvQuestionsDetail";
            this.dgvQuestionsDetail.ReadOnly = true;
            this.dgvQuestionsDetail.RowHeadersVisible = false;
            this.dgvQuestionsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestionsDetail.Size = new System.Drawing.Size(584, 385);
            this.dgvQuestionsDetail.TabIndex = 4;
            // 
            // Test
            // 
            this.Test.HeaderText = "Mã test";
            this.Test.Name = "Test";
            this.Test.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mark.HeaderText = "Điểm";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Info.HeaderText = "Thông tin";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // btnRegrade
            // 
            this.btnRegrade.Location = new System.Drawing.Point(12, 413);
            this.btnRegrade.Name = "btnRegrade";
            this.btnRegrade.Size = new System.Drawing.Size(90, 39);
            this.btnRegrade.TabIndex = 5;
            this.btnRegrade.Text = "Chấm lại";
            this.btnRegrade.UseVisualStyleBackColor = true;
            this.btnRegrade.Click += new System.EventHandler(this.btnRegrade_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(12, 368);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(90, 39);
            this.btnOpenFolder.TabIndex = 6;
            this.btnOpenFolder.Text = "Mở thư mục bài làm";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã kì thi:";
            // 
            // lblExamID
            // 
            this.lblExamID.AutoSize = true;
            this.lblExamID.Location = new System.Drawing.Point(68, 26);
            this.lblExamID.Name = "lblExamID";
            this.lblExamID.Size = new System.Drawing.Size(0, 13);
            this.lblExamID.TabIndex = 9;
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(211, 26);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(0, 13);
            this.lblCandidateID.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(359, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 11;
            // 
            // lblSumMark
            // 
            this.lblSumMark.AutoSize = true;
            this.lblSumMark.Location = new System.Drawing.Point(651, 26);
            this.lblSumMark.Name = "lblSumMark";
            this.lblSumMark.Size = new System.Drawing.Size(0, 13);
            this.lblSumMark.TabIndex = 12;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.ColumnHeadersVisible = false;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionID});
            this.dgvQuestions.Location = new System.Drawing.Point(12, 67);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(90, 113);
            this.dgvQuestions.TabIndex = 13;
            this.dgvQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellDoubleClick);
            // 
            // QuestionID
            // 
            this.QuestionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuestionID.HeaderText = "Mã câu hỏi";
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.ReadOnly = true;
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.AllowUserToDeleteRows = false;
            this.dgvTask.AllowUserToResizeColumns = false;
            this.dgvTask.AllowUserToResizeRows = false;
            this.dgvTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.ColumnHeadersVisible = false;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task});
            this.dgvTask.Location = new System.Drawing.Point(12, 186);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.ReadOnly = true;
            this.dgvTask.RowHeadersVisible = false;
            this.dgvTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTask.Size = new System.Drawing.Size(90, 176);
            this.dgvTask.TabIndex = 14;
            this.dgvTask.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellDoubleClick);
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.HeaderText = "Tên";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // frmResultDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 464);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.lblSumMark);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCandidateID);
            this.Controls.Add(this.lblExamID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnRegrade);
            this.Controls.Add(this.dgvQuestionsDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmResultDetail";
            this.Text = "frmResultDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvQuestionsDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.Button btnRegrade;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExamID;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSumMark;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
    }
}