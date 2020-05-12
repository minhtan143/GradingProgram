using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmAddExam : Form
    {
        public int examID;
        public frmAddExam()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPath.Text = dialog.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtExamName.Text.Trim()) && !String.IsNullOrEmpty(txtPath.Text.Trim()))
            {
                if (BLExam.Exists(txtExamName.Text.Trim()))
                    MessageBox.Show("Kì thi tên '" + txtExamName.Text + "' đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Exam exam = new Exam();
                    exam.Name = txtExamName.Text.Trim();
                    exam.Folder = txtPath.Text.Trim();
                    exam.CreateDate = DateTime.Now.Date;
                    exam.Status = true;

                    BLExam.Add(exam);
                    examID = exam.ID;
                    Hide();
                }
            }
            else MessageBox.Show("Không được để trống nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
