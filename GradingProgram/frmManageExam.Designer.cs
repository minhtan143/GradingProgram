namespace GradingProgram
{
    partial class frmManageExam
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
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AllowUserToResizeColumns = false;
            this.dgvExams.AllowUserToResizeRows = false;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamID,
            this.ExamName,
            this.CreateDate,
            this.Folder});
            this.dgvExams.Location = new System.Drawing.Point(12, 12);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            this.dgvExams.RowHeadersVisible = false;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(759, 422);
            this.dgvExams.TabIndex = 0;
            this.dgvExams.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellDoubleClick);
            // 
            // ExamID
            // 
            this.ExamID.HeaderText = "Mã kỳ thi";
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            // 
            // ExamName
            // 
            this.ExamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExamName.HeaderText = "Tên kỳ thi";
            this.ExamName.Name = "ExamName";
            this.ExamName.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "Ngày tạo";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // Folder
            // 
            this.Folder.HeaderText = "Thư mục thí sinh";
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            this.Folder.Width = 258;
            // 
            // frmManageExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 446);
            this.Controls.Add(this.dgvExams);
            this.Name = "frmManageExam";
            this.Text = "frmExamView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
    }
}