using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmExamView : Form
    {
        private int examId;
        private bool modify;

        public frmExamView(int examId)
        {
            this.examId = examId;
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            txtExamName.Text = BLExam.GetExam(examId).Name;
            txtPathFolder.Text = BLExam.GetExam(examId).Folder;

            dgvSelected.DataSource = BusinessLogic.ToDataTable(BLExamDetail.GetQuestions(examId).Select(x => new { x.ID, x.Name }).OrderBy(x => x.Name));
            dgvSelected.Columns["ID"].Visible = false;

            dgvQuestions.DataSource = BusinessLogic.ToDataTable(BLQuestion.GetQuestions().Select(x => new { x.ID, x.Name }).OrderBy(x => x.Name));
            dgvQuestions.Columns["ID"].Visible = false;

            modify = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BLExamDetail.Add(new ExamDetail()
            {
                QuestionID = int.Parse(dgvQuestions.CurrentRow.Cells[0].Value.ToString()),
                ExamID = this.examId,
                FileName = "Bai" + (dgvSelected.Rows.Count+1).ToString()
            });

            LoadData();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            ExamDetail exD = new ExamDetail();
            exD.QuestionID = int.Parse(dgvSelected.CurrentRow.Cells[0].Value.ToString());
            exD.ExamID = this.examId;

            
            //BLExamDetail.Delete(exD);

            LoadData();
        }

        private void dgvSelected_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string questionId = (sender as ListView).SelectedItems[0].SubItems[0].Text;
            frmQuestionView frmQuestionView = new frmQuestionView(0/*questionId*/);
            frmQuestionView.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmExamView_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtPathFolder.Text = dialog.FileName;
            }
            Focus();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            modify = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }
    }
}
