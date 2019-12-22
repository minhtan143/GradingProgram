namespace GradingProject
{
    partial class frmQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestions));
            this.panel20 = new System.Windows.Forms.Panel();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvSetupTest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxQuestionContent = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rtxQuestionInput = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.rtxQuestionOutput = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuestionName = new System.Windows.Forms.TextBox();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetupTest)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.dgvQuestions);
            this.panel20.Controls.Add(this.button1);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(300, 591);
            this.panel20.TabIndex = 2;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 23);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.Size = new System.Drawing.Size(300, 568);
            this.dgvQuestions.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 47;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên câu hỏi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ngân hàng câu hỏi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvSetupTest);
            this.panel6.Controls.Add(this.rtxQuestionContent);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(369, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(385, 541);
            this.panel6.TabIndex = 20;
            // 
            // dgvSetupTest
            // 
            this.dgvSetupTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSetupTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.Column10,
            this.Column11});
            this.dgvSetupTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSetupTest.Enabled = false;
            this.dgvSetupTest.Location = new System.Drawing.Point(0, 134);
            this.dgvSetupTest.Name = "dgvSetupTest";
            this.dgvSetupTest.RowHeadersVisible = false;
            this.dgvSetupTest.Size = new System.Drawing.Size(385, 407);
            this.dgvSetupTest.TabIndex = 12;
            this.dgvSetupTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSetupTest_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã test";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 67;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tên test";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Điểm test";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "Thời gian(s)";
            this.Column10.Name = "Column10";
            this.Column10.Width = 87;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Bộ nhớ";
            this.Column11.Name = "Column11";
            this.Column11.Width = 66;
            // 
            // rtxQuestionContent
            // 
            this.rtxQuestionContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxQuestionContent.Enabled = false;
            this.rtxQuestionContent.Location = new System.Drawing.Point(0, 26);
            this.rtxQuestionContent.Name = "rtxQuestionContent";
            this.rtxQuestionContent.Size = new System.Drawing.Size(385, 108);
            this.rtxQuestionContent.TabIndex = 11;
            this.rtxQuestionContent.Text = "";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(385, 26);
            this.button6.TabIndex = 9;
            this.button6.Text = "Nội dung câu hỏi";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(354, 50);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(15, 541);
            this.panel19.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rtxQuestionInput);
            this.panel8.Controls.Add(this.button5);
            this.panel8.Controls.Add(this.rtxQuestionOutput);
            this.panel8.Controls.Add(this.button7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(754, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(350, 541);
            this.panel8.TabIndex = 18;
            // 
            // rtxQuestionInput
            // 
            this.rtxQuestionInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxQuestionInput.Enabled = false;
            this.rtxQuestionInput.Location = new System.Drawing.Point(0, 26);
            this.rtxQuestionInput.Name = "rtxQuestionInput";
            this.rtxQuestionInput.Size = new System.Drawing.Size(350, 239);
            this.rtxQuestionInput.TabIndex = 28;
            this.rtxQuestionInput.Text = "";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 26);
            this.button5.TabIndex = 27;
            this.button5.Text = "Output";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // rtxQuestionOutput
            // 
            this.rtxQuestionOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxQuestionOutput.Enabled = false;
            this.rtxQuestionOutput.Location = new System.Drawing.Point(0, 291);
            this.rtxQuestionOutput.Name = "rtxQuestionOutput";
            this.rtxQuestionOutput.Size = new System.Drawing.Size(350, 250);
            this.rtxQuestionOutput.TabIndex = 26;
            this.rtxQuestionOutput.Text = "";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(350, 26);
            this.button7.TabIndex = 25;
            this.button7.Text = "Input";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnReload);
            this.panel4.Controls.Add(this.btnEditQuestion);
            this.panel4.Controls.Add(this.btnAddQuestion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(300, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 541);
            this.panel4.TabIndex = 17;
            // 
            // btnReload
            // 
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReload.Location = new System.Drawing.Point(0, 487);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(54, 54);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditQuestion.Location = new System.Drawing.Point(0, 54);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(54, 54);
            this.btnEditQuestion.TabIndex = 2;
            this.btnEditQuestion.Text = "EDIT";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Visible = false;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddQuestion.Location = new System.Drawing.Point(0, 0);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(54, 54);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "ADD";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveQuestion);
            this.panel3.Controls.Add(this.txtQuestionName);
            this.panel3.Controls.Add(this.txtQuestionID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 50);
            this.panel3.TabIndex = 16;
            // 
            // txtQuestionName
            // 
            this.txtQuestionName.Enabled = false;
            this.txtQuestionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionName.Location = new System.Drawing.Point(285, 14);
            this.txtQuestionName.Name = "txtQuestionName";
            this.txtQuestionName.Size = new System.Drawing.Size(374, 23);
            this.txtQuestionName.TabIndex = 3;
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Enabled = false;
            this.txtQuestionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionID.Location = new System.Drawing.Point(102, 14);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.Size = new System.Drawing.Size(88, 23);
            this.txtQuestionID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên câu hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã câu hỏi";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveQuestion.Location = new System.Drawing.Point(729, 0);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(75, 50);
            this.btnSaveQuestion.TabIndex = 4;
            this.btnSaveQuestion.Text = "LƯU";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Visible = false;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý câu hỏi";
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSetupTest)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvSetupTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.RichTextBox rtxQuestionContent;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RichTextBox rtxQuestionInput;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox rtxQuestionOutput;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.TextBox txtQuestionName;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}