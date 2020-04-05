namespace GradingProgram
{
    partial class frmManageCandidate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.AllowUserToAddRows = false;
            this.dgvCandidate.AllowUserToDeleteRows = false;
            this.dgvCandidate.AllowUserToResizeColumns = false;
            this.dgvCandidate.AllowUserToResizeRows = false;
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateID,
            this.CandidateName,
            this.Email});
            this.dgvCandidate.Location = new System.Drawing.Point(12, 71);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.ReadOnly = true;
            this.dgvCandidate.RowHeadersVisible = false;
            this.dgvCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidate.Size = new System.Drawing.Size(700, 359);
            this.dgvCandidate.TabIndex = 2;
            this.dgvCandidate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidate_CellDoubleClick);
            // 
            // CandidateID
            // 
            this.CandidateID.HeaderText = "Mã số sinh viên";
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Width = 150;
            // 
            // CandidateName
            // 
            this.CandidateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateName.HeaderText = "Tên";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // frmManageCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 442);
            this.Controls.Add(this.dgvCandidate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmManageCandidate";
            this.Text = "frmManageCandidate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}