namespace GradingProgram
{
    partial class frmSettingTestCase
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
            this.label4 = new System.Windows.Forms.Label();
            this.nudTimeOut = new System.Windows.Forms.NumericUpDown();
            this.nudMemoryLimit = new System.Windows.Forms.NumericUpDown();
            this.nupMark = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoryLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cài đặt được áp dụng cho tất cả các test!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới hạn thời gian (ms):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới hạn bộ nhớ (MB):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm:";
            // 
            // nudTimeOut
            // 
            this.nudTimeOut.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeOut.Location = new System.Drawing.Point(224, 39);
            this.nudTimeOut.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudTimeOut.Name = "nudTimeOut";
            this.nudTimeOut.Size = new System.Drawing.Size(91, 20);
            this.nudTimeOut.TabIndex = 5;
            this.nudTimeOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudMemoryLimit
            // 
            this.nudMemoryLimit.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMemoryLimit.Location = new System.Drawing.Point(224, 76);
            this.nudMemoryLimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMemoryLimit.Name = "nudMemoryLimit";
            this.nudMemoryLimit.Size = new System.Drawing.Size(91, 20);
            this.nudMemoryLimit.TabIndex = 6;
            this.nudMemoryLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nupMark
            // 
            this.nupMark.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupMark.Location = new System.Drawing.Point(224, 113);
            this.nupMark.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nupMark.Name = "nupMark";
            this.nupMark.Size = new System.Drawing.Size(91, 20);
            this.nupMark.TabIndex = 7;
            this.nupMark.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(224, 159);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 28);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(127, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Trở về";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btn_Click);
            // 
            // frmSetUpTestCase
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(334, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nupMark);
            this.Controls.Add(this.nudMemoryLimit);
            this.Controls.Add(this.nudTimeOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetUpTestCase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cài đặt";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoryLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.NumericUpDown nudTimeOut;
        public System.Windows.Forms.NumericUpDown nudMemoryLimit;
        public System.Windows.Forms.NumericUpDown nupMark;
    }
}