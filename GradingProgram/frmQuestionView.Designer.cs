namespace GradingProgram
{
    partial class frmQuestionView
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
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTestCase = new System.Windows.Forms.DataGridView();
            this.TestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã câu hỏi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mô tả:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(55, 59);
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(719, 61);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Testcase";
            // 
            // dgvTestCase
            // 
            this.dgvTestCase.AllowUserToAddRows = false;
            this.dgvTestCase.AllowUserToDeleteRows = false;
            this.dgvTestCase.AllowUserToResizeColumns = false;
            this.dgvTestCase.AllowUserToResizeRows = false;
            this.dgvTestCase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestCase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestID,
            this.Input,
            this.Output});
            this.dgvTestCase.Location = new System.Drawing.Point(15, 158);
            this.dgvTestCase.Name = "dgvTestCase";
            this.dgvTestCase.ReadOnly = true;
            this.dgvTestCase.RowHeadersVisible = false;
            this.dgvTestCase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestCase.Size = new System.Drawing.Size(759, 297);
            this.dgvTestCase.TabIndex = 4;
            this.dgvTestCase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestCase_CellDoubleClick);
            // 
            // TestID
            // 
            this.TestID.HeaderText = "Mã test";
            this.TestID.Name = "TestID";
            this.TestID.ReadOnly = true;
            // 
            // Input
            // 
            this.Input.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Input.HeaderText = "Đầu vào";
            this.Input.Name = "Input";
            this.Input.ReadOnly = true;
            // 
            // Output
            // 
            this.Output.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Output.HeaderText = "Đầu ra";
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(716, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Location = new System.Drawing.Point(81, 28);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.ReadOnly = true;
            this.txtQuestionID.Size = new System.Drawing.Size(143, 20);
            this.txtQuestionID.TabIndex = 6;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(716, 129);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(58, 23);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "Cài đặt";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 467);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.txtQuestionID);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvTestCase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuestionView";
            this.Text = "frmQuestionView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTestCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnSave;
    }
}