namespace GradingProgram
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.guideTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.gradingTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.gradingThisExamTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.settingCompareTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.settingCompilerTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.examTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createExamTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExamTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRusultTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.questionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageQuestionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCandidateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.infomationTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExamName = new System.Windows.Forms.Label();
            this.cbExamName = new System.Windows.Forms.ComboBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageTSMI,
            this.gradingTSMI,
            this.examTSMI,
            this.questionTSMI,
            this.candidateTSMI,
            this.infomationTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageTSMI
            // 
            this.homePageTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guideTSMI,
            this.refreshTSMI,
            this.exitTSMI});
            this.homePageTSMI.Name = "homePageTSMI";
            this.homePageTSMI.Size = new System.Drawing.Size(71, 20);
            this.homePageTSMI.Text = "Trang chủ";
            // 
            // guideTSMI
            // 
            this.guideTSMI.Name = "guideTSMI";
            this.guideTSMI.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.guideTSMI.Size = new System.Drawing.Size(180, 22);
            this.guideTSMI.Text = "Hướng dẫn";
            // 
            // refreshTSMI
            // 
            this.refreshTSMI.Name = "refreshTSMI";
            this.refreshTSMI.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshTSMI.Size = new System.Drawing.Size(180, 22);
            this.refreshTSMI.Text = "Cập nhật lại";
            this.refreshTSMI.Click += new System.EventHandler(this.refreshTSMI_Click);
            // 
            // gradingTSMI
            // 
            this.gradingTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradingThisExamTSMI,
            this.settingCompareTSMI,
            this.settingCompilerTSMI});
            this.gradingTSMI.Name = "gradingTSMI";
            this.gradingTSMI.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.gradingTSMI.Size = new System.Drawing.Size(81, 20);
            this.gradingTSMI.Text = "Chấm điểm";
            // 
            // gradingThisExamTSMI
            // 
            this.gradingThisExamTSMI.Name = "gradingThisExamTSMI";
            this.gradingThisExamTSMI.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.gradingThisExamTSMI.Size = new System.Drawing.Size(192, 22);
            this.gradingThisExamTSMI.Text = "Chấm kì thi này";
            this.gradingThisExamTSMI.Click += new System.EventHandler(this.gradingThisExamTSMI_Click);
            // 
            // settingCompareTSMI
            // 
            this.settingCompareTSMI.Name = "settingCompareTSMI";
            this.settingCompareTSMI.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.settingCompareTSMI.Size = new System.Drawing.Size(192, 22);
            this.settingCompareTSMI.Text = "Cài đặt chấm kì thi";
            this.settingCompareTSMI.Click += new System.EventHandler(this.setupGradingTSMI_Click);
            // 
            // settingCompilerTSMI
            // 
            this.settingCompilerTSMI.Name = "settingCompilerTSMI";
            this.settingCompilerTSMI.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.settingCompilerTSMI.Size = new System.Drawing.Size(192, 22);
            this.settingCompilerTSMI.Text = "Cài đặt bộ dịch";
            this.settingCompilerTSMI.Click += new System.EventHandler(this.settingCompilerTSMI_Click);
            // 
            // examTSMI
            // 
            this.examTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createExamTSMI,
            this.manageExamTSMI,
            this.deleteRusultTSMI});
            this.examTSMI.Name = "examTSMI";
            this.examTSMI.Size = new System.Drawing.Size(48, 20);
            this.examTSMI.Text = "Kỳ thi";
            // 
            // createExamTSMI
            // 
            this.createExamTSMI.Name = "createExamTSMI";
            this.createExamTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createExamTSMI.Size = new System.Drawing.Size(270, 22);
            this.createExamTSMI.Text = "Tạo kỳ thi mới";
            this.createExamTSMI.Click += new System.EventHandler(this.createExamTSMI_Click);
            // 
            // manageExamTSMI
            // 
            this.manageExamTSMI.Name = "manageExamTSMI";
            this.manageExamTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.manageExamTSMI.Size = new System.Drawing.Size(270, 22);
            this.manageExamTSMI.Text = "Quản lý kỳ thi";
            this.manageExamTSMI.Click += new System.EventHandler(this.manageExamTSMI_Click);
            // 
            // deleteRusultTSMI
            // 
            this.deleteRusultTSMI.Name = "deleteRusultTSMI";
            this.deleteRusultTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteRusultTSMI.Size = new System.Drawing.Size(270, 22);
            this.deleteRusultTSMI.Text = "Xóa kết quả kỳ thì đang mở";
            this.deleteRusultTSMI.Click += new System.EventHandler(this.deleteRusultTSMI_Click);
            // 
            // questionTSMI
            // 
            this.questionTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuestionTSMI,
            this.manageQuestionTSMI});
            this.questionTSMI.Name = "questionTSMI";
            this.questionTSMI.Size = new System.Drawing.Size(60, 20);
            this.questionTSMI.Text = "Câu hỏi";
            // 
            // createQuestionTSMI
            // 
            this.createQuestionTSMI.Name = "createQuestionTSMI";
            this.createQuestionTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.createQuestionTSMI.Size = new System.Drawing.Size(210, 22);
            this.createQuestionTSMI.Text = "Tạo câu hỏi";
            this.createQuestionTSMI.Click += new System.EventHandler(this.createQuestionTSMI_Click);
            // 
            // manageQuestionTSMI
            // 
            this.manageQuestionTSMI.Name = "manageQuestionTSMI";
            this.manageQuestionTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.manageQuestionTSMI.Size = new System.Drawing.Size(210, 22);
            this.manageQuestionTSMI.Text = "Quản lí câu hỏi";
            this.manageQuestionTSMI.Click += new System.EventHandler(this.manageQuestionTSMI_Click);
            // 
            // candidateTSMI
            // 
            this.candidateTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCandidateTSMI});
            this.candidateTSMI.Name = "candidateTSMI";
            this.candidateTSMI.Size = new System.Drawing.Size(60, 20);
            this.candidateTSMI.Text = "Thí sinh";
            // 
            // manageCandidateTSMI
            // 
            this.manageCandidateTSMI.Name = "manageCandidateTSMI";
            this.manageCandidateTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.manageCandidateTSMI.Size = new System.Drawing.Size(197, 22);
            this.manageCandidateTSMI.Text = "Quản lý thí sinh";
            this.manageCandidateTSMI.Click += new System.EventHandler(this.manageCandidateTSMI_Click);
            // 
            // infomationTSMI
            // 
            this.infomationTSMI.Name = "infomationTSMI";
            this.infomationTSMI.Size = new System.Drawing.Size(70, 20);
            this.infomationTSMI.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblExamName);
            this.panel1.Controls.Add(this.cbExamName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 43);
            this.panel1.TabIndex = 9;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Enabled = false;
            this.btnExportExcel.Location = new System.Drawing.Point(882, 7);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(90, 30);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Xuất file Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã kỳ thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên kỳ thi: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(598, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày thi: ";
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(381, 15);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(0, 13);
            this.lblExamName.TabIndex = 6;
            // 
            // cbExamName
            // 
            this.cbExamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExamName.FormattingEnabled = true;
            this.cbExamName.Location = new System.Drawing.Point(79, 9);
            this.cbExamName.Name = "cbExamName";
            this.cbExamName.Size = new System.Drawing.Size(173, 23);
            this.cbExamName.TabIndex = 5;
            this.cbExamName.SelectedValueChanged += new System.EventHandler(this.cbExamName_SelectedValueChanged);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AllowUserToResizeColumns = false;
            this.dgvResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Code,
            this.CandidateName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.GridColor = System.Drawing.Color.Gray;
            this.dgvResults.Location = new System.Drawing.Point(0, 67);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(984, 394);
            this.dgvResults.TabIndex = 10;
            this.dgvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 32;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Mã thí sinh";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 110;
            // 
            // CandidateName
            // 
            this.CandidateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateName.DataPropertyName = "Name";
            this.CandidateName.HeaderText = "Tên sinh viên";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitTSMI.Size = new System.Drawing.Size(180, 22);
            this.exitTSMI.Text = "Thoát";
            this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmMain";
            this.Text = "Chấm thi tự động";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageTSMI;
        private System.Windows.Forms.ToolStripMenuItem examTSMI;
        private System.Windows.Forms.ToolStripMenuItem createExamTSMI;
        private System.Windows.Forms.ToolStripMenuItem questionTSMI;
        private System.Windows.Forms.ToolStripMenuItem createQuestionTSMI;
        private System.Windows.Forms.ToolStripMenuItem manageQuestionTSMI;
        private System.Windows.Forms.ToolStripMenuItem infomationTSMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem manageExamTSMI;
        private System.Windows.Forms.ComboBox cbExamName;
        private System.Windows.Forms.ToolStripMenuItem candidateTSMI;
        private System.Windows.Forms.ToolStripMenuItem manageCandidateTSMI;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ToolStripMenuItem gradingTSMI;
        private System.Windows.Forms.ToolStripMenuItem gradingThisExamTSMI;
        private System.Windows.Forms.ToolStripMenuItem settingCompareTSMI;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.ToolStripMenuItem guideTSMI;
        private System.Windows.Forms.ToolStripMenuItem refreshTSMI;
        private System.Windows.Forms.ToolStripMenuItem settingCompilerTSMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.ToolStripMenuItem deleteRusultTSMI;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
    }
}

