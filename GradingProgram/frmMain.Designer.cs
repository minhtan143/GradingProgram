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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kỳThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createExamTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExamTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.câuHỏiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.manageQuestionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.thíSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCandidateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbExamId = new System.Windows.Forms.ComboBox();
            this.lblExamName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.kỳThiToolStripMenuItem,
            this.câuHỏiToolStripMenuItem,
            this.thíSinhToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // kỳThiToolStripMenuItem
            // 
            this.kỳThiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createExamTSMI,
            this.manageExamTSMI});
            this.kỳThiToolStripMenuItem.Name = "kỳThiToolStripMenuItem";
            this.kỳThiToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.kỳThiToolStripMenuItem.Text = "Kỳ thi";
            // 
            // createExamTSMI
            // 
            this.createExamTSMI.Name = "createExamTSMI";
            this.createExamTSMI.Size = new System.Drawing.Size(149, 22);
            this.createExamTSMI.Text = "Tạo kỳ thi mới";
            this.createExamTSMI.Click += new System.EventHandler(this.createExamTSMI_Click);
            // 
            // manageExamTSMI
            // 
            this.manageExamTSMI.Name = "manageExamTSMI";
            this.manageExamTSMI.Size = new System.Drawing.Size(149, 22);
            this.manageExamTSMI.Text = "Quản lý kỳ thi";
            this.manageExamTSMI.Click += new System.EventHandler(this.manageExamTSMI_Click);
            // 
            // câuHỏiToolStripMenuItem
            // 
            this.câuHỏiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createQuestionTSMI,
            this.manageQuestionTSMI});
            this.câuHỏiToolStripMenuItem.Name = "câuHỏiToolStripMenuItem";
            this.câuHỏiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.câuHỏiToolStripMenuItem.Text = "Câu hỏi";
            // 
            // createQuestionTSMI
            // 
            this.createQuestionTSMI.Name = "createQuestionTSMI";
            this.createQuestionTSMI.Size = new System.Drawing.Size(154, 22);
            this.createQuestionTSMI.Text = "Tạo câu hỏi";
            this.createQuestionTSMI.Click += new System.EventHandler(this.createQuestionTSMI_Click);
            // 
            // manageQuestionTSMI
            // 
            this.manageQuestionTSMI.Name = "manageQuestionTSMI";
            this.manageQuestionTSMI.Size = new System.Drawing.Size(154, 22);
            this.manageQuestionTSMI.Text = "Quản lí câu hỏi";
            this.manageQuestionTSMI.Click += new System.EventHandler(this.manageQuestionTSMI_Click);
            // 
            // thíSinhToolStripMenuItem
            // 
            this.thíSinhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCandidateTSMI});
            this.thíSinhToolStripMenuItem.Name = "thíSinhToolStripMenuItem";
            this.thíSinhToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.thíSinhToolStripMenuItem.Text = "Thí sinh";
            // 
            // manageCandidateTSMI
            // 
            this.manageCandidateTSMI.Name = "manageCandidateTSMI";
            this.manageCandidateTSMI.Size = new System.Drawing.Size(157, 22);
            this.manageCandidateTSMI.Text = "Quản lý thí sinh";
            this.manageCandidateTSMI.Click += new System.EventHandler(this.manageCandidateTSMI_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã kỳ thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên kỳ thi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày thi: ";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeColumns = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateID,
            this.CandidateName,
            this.Mark});
            this.dgvResult.Location = new System.Drawing.Point(12, 83);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(753, 357);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellDoubleClick);
            // 
            // CandidateID
            // 
            this.CandidateID.HeaderText = "MSSV";
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            // 
            // CandidateName
            // 
            this.CandidateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateName.HeaderText = "Tên sinh viên";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mark.HeaderText = "Điểm";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // cbExamId
            // 
            this.cbExamId.FormattingEnabled = true;
            this.cbExamId.Location = new System.Drawing.Point(82, 42);
            this.cbExamId.Name = "cbExamId";
            this.cbExamId.Size = new System.Drawing.Size(121, 21);
            this.cbExamId.TabIndex = 5;
            // 
            // lblExamName
            // 
            this.lblExamName.AutoSize = true;
            this.lblExamName.Location = new System.Drawing.Point(293, 49);
            this.lblExamName.Name = "lblExamName";
            this.lblExamName.Size = new System.Drawing.Size(0, 13);
            this.lblExamName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(608, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 452);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExamName);
            this.Controls.Add(this.cbExamId);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kỳThiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createExamTSMI;
        private System.Windows.Forms.ToolStripMenuItem câuHỏiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createQuestionTSMI;
        private System.Windows.Forms.ToolStripMenuItem manageQuestionTSMI;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.ToolStripMenuItem manageExamTSMI;
        private System.Windows.Forms.ComboBox cbExamId;
        private System.Windows.Forms.ToolStripMenuItem thíSinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCandidateTSMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.Label lblExamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
    }
}

