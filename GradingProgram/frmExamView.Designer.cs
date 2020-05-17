namespace GradingProgram
{
    partial class frmExamView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.QID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvQuestionBank = new System.Windows.Forms.DataGridView();
            this.QBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionBank)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kì thi:";
            // 
            // txtExamName
            // 
            this.txtExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamName.Location = new System.Drawing.Point(116, 16);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(297, 21);
            this.txtExamName.TabIndex = 2;
            this.txtExamName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFolder);
            this.panel1.Controls.Add(this.txtPathFolder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtExamName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 93);
            this.panel1.TabIndex = 16;
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(659, 56);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(36, 21);
            this.btnFolder.TabIndex = 11;
            this.btnFolder.Text = "•••";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Enabled = false;
            this.txtPathFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathFolder.Location = new System.Drawing.Point(116, 56);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(537, 21);
            this.txtPathFolder.TabIndex = 12;
            this.txtPathFolder.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thư mục bài làm:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(766, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(872, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 19);
            this.panel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngân hàng câu hỏi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thí sinh";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QID,
            this.QuestionName,
            this.FileName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 112);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(199, 349);
            this.dgvQuestions.TabIndex = 20;
            this.dgvQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellDoubleClick);
            // 
            // QID
            // 
            this.QID.DataPropertyName = "ID";
            this.QID.HeaderText = "ID";
            this.QID.Name = "QID";
            this.QID.ReadOnly = true;
            this.QID.Visible = false;
            this.QID.Width = 27;
            // 
            // QuestionName
            // 
            this.QuestionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuestionName.DataPropertyName = "Name";
            this.QuestionName.HeaderText = "Câu hỏi";
            this.QuestionName.Name = "QuestionName";
            this.QuestionName.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "Tên tệp khi chấm";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.AllowUserToAddRows = false;
            this.dgvCandidates.AllowUserToDeleteRows = false;
            this.dgvCandidates.AllowUserToResizeColumns = false;
            this.dgvCandidates.AllowUserToResizeRows = false;
            this.dgvCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.Code,
            this.CandidateName,
            this.Phone,
            this.Email,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidates.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidates.Location = new System.Drawing.Point(402, 112);
            this.dgvCandidates.MultiSelect = false;
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.ReadOnly = true;
            this.dgvCandidates.RowHeadersVisible = false;
            this.dgvCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidates.Size = new System.Drawing.Size(582, 349);
            this.dgvCandidates.TabIndex = 24;
            this.dgvCandidates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidates_CellClick);
            this.dgvCandidates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidates_CellDoubleClick);
            // 
            // CID
            // 
            this.CID.DataPropertyName = "ID";
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.ReadOnly = true;
            this.CID.Visible = false;
            this.CID.Width = 27;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Mã số thí sinh";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 113;
            // 
            // CandidateName
            // 
            this.CandidateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CandidateName.DataPropertyName = "Name";
            this.CandidateName.HeaderText = "Tên thí sinh";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 111;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Xóa";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(199, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(68, 349);
            this.panel6.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(6, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "<<";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvQuestionBank
            // 
            this.dgvQuestionBank.AllowUserToAddRows = false;
            this.dgvQuestionBank.AllowUserToDeleteRows = false;
            this.dgvQuestionBank.AllowUserToResizeColumns = false;
            this.dgvQuestionBank.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvQuestionBank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQuestionBank.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvQuestionBank.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestionBank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQuestionBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionBank.ColumnHeadersVisible = false;
            this.dgvQuestionBank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QBID,
            this.QuestionsName});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestionBank.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQuestionBank.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvQuestionBank.Location = new System.Drawing.Point(267, 112);
            this.dgvQuestionBank.Name = "dgvQuestionBank";
            this.dgvQuestionBank.ReadOnly = true;
            this.dgvQuestionBank.RowHeadersVisible = false;
            this.dgvQuestionBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestionBank.Size = new System.Drawing.Size(125, 349);
            this.dgvQuestionBank.TabIndex = 27;
            // 
            // QBID
            // 
            this.QBID.DataPropertyName = "ID";
            this.QBID.HeaderText = "ID";
            this.QBID.Name = "QBID";
            this.QBID.ReadOnly = true;
            this.QBID.Visible = false;
            this.QBID.Width = 46;
            // 
            // QuestionsName
            // 
            this.QuestionsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuestionsName.DataPropertyName = "Name";
            this.QuestionsName.HeaderText = "Câu hỏi";
            this.QuestionsName.Name = "QuestionsName";
            this.QuestionsName.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(392, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 349);
            this.panel4.TabIndex = 27;
            // 
            // frmExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgvCandidates);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvQuestionBank);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "frmExamView";
            this.Text = "frmExamView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExamView_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtPathFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvQuestionBank;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn QID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionsName;
    }
}