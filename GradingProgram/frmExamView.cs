using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
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
            Text = BLExam.GetExam(examId).Name + " - Kỳ thi";
            LoadData();
        }

        private void LoadData()
        {
            txtExamName.Text = BLExam.GetExam(examId).Name;
            txtPathFolder.Text = BLExam.GetExam(examId).Folder;

            RefreshQuestions();
            RefreshCandiates();

            modify = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void RefreshQuestions()
        {
            dgvQuestions.DataSource = BusinessLogic.ToDataTable(BLExamDetail.GetExamDetails(x => x.ExamID == examId, y => new { ID = y.QuestionID, BLQuestion.GetQuestion(y.QuestionID).Name, y.FileName }));
            dgvQuestionBank.DataSource = BusinessLogic.ToDataTable(BLQuestion.GetQuestions().Except(BLExamDetail.GetQuestions(examId)).Select(x => new { x.ID, x.Name }));
            
            btnAdd.Enabled = dgvQuestionBank.RowCount > 0;
            btnDelete.Enabled = dgvQuestions.RowCount > 0;
        }

        private void RefreshCandiates()
        {
            dgvCandidates.DataSource = BusinessLogic.ToDataTable(BLCandidateDetail.GetCandidates(examId).Select(x => new { x.ID, x.Code, x.Name, x.Phone, x.Email }));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Exam exam = BLExam.GetExam(examId);
                if (exam.Name != txtExamName.Text.Trim())
                {
                    if (BLExam.Exists(txtExamName.Text.Trim()))
                        throw new Exception("Tên câu hỏi đã tồn tại!");
                    exam.Name = txtExamName.Text.Trim();
                }
                exam.Folder = txtPathFolder.Text.Trim();
                BLExam.Update(exam);

                txtExamName.Text = BLExam.GetExam(examId).Name;
                txtPathFolder.Text = BLExam.GetExam(examId).Folder;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                modify = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExamView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modify)
            {
                DialogResult dialogResult = MessageBox.Show("Thay đổi của bạn chưa được lưu. Lưu lại?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    btnSave_Click(null, null);
                    if (modify)
                        e.Cancel = true;
                }
                else if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                txtPathFolder.Text = dialog.FileName;
            Focus();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            modify = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }

        private void dgvCandidates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCandidates.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (e.RowIndex < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Xóa tất cả thí sinh khỏi kỳ thi này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BLCandidateDetail.Delete(BLCandidateDetail.GetCandidateDetails(x => x.ExamID == examId));
                        RefreshCandiates();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa thí sinh này khỏi kỳ thi?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var candidateDetails = BLCandidateDetail.GetCandidateDetails(x => x.ExamID == examId && x.CandidateID == int.Parse(dgvCandidates.Rows[e.RowIndex].Cells["CID"].Value.ToString()));
                        BLCandidateDetail.Delete(candidateDetails.First());
                        RefreshCandiates();
                        if (e.RowIndex > 0)
                            dgvCandidates.Rows[e.RowIndex - 1].Selected = true;
                    }
                }
            }
        }

        private void dgvCandidates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCandidates.Columns[e.ColumnIndex].Name != "Delete")
            {
                frmCandidateView frmCandidateView = new frmCandidateView(int.Parse(dgvCandidates.Rows[e.RowIndex].Cells["CID"].Value.ToString()));
                if (!Initialize.CheckOpened(frmCandidateView))
                    frmCandidateView.Show();
            }
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvQuestions.Columns[e.ColumnIndex].Name == "FileName")
            {
                frmEditText frmEditText = new frmEditText(dgvQuestions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), dgvQuestions.Columns[e.ColumnIndex].HeaderText);
                frmEditText.ShowDialog();

                if (frmEditText.Modify)
                {
                    ExamDetail examDetail = new ExamDetail();
                    examDetail.ExamID = examId;
                    examDetail.QuestionID = int.Parse(dgvQuestions.Rows[e.RowIndex].Cells["QID"].Value.ToString());
                    examDetail.FileName = String.IsNullOrEmpty(frmEditText.Content) ? BLQuestion.GetQuestion(examDetail.QuestionID).Name : frmEditText.Content;

                    BLExamDetail.AddOrUpdate(examDetail);
                    RefreshQuestions();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExamDetail examDetail = new ExamDetail();
            examDetail.ExamID = examId;
            examDetail.QuestionID = int.Parse(dgvQuestionBank.CurrentRow.Cells["QBID"].Value.ToString());
            examDetail.FileName = BLQuestion.GetQuestion(examDetail.QuestionID).Name;

            BLExamDetail.AddOrUpdate(examDetail);
            RefreshQuestions();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa câu hỏi '" + dgvQuestions.CurrentRow.Cells["QuestionName"].Value + "' khỏi kỳ thi?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ExamDetail examDetail = BLExamDetail.GetExamDetail(x => x.ExamID == examId && x.QuestionID == int.Parse(dgvQuestions.CurrentRow.Cells["QID"].Value.ToString()), y => y);
                BLExamDetail.Delete(examDetail);
                RefreshQuestions();
            }
        }
    }
}
