using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmResultDetail : Form
    {
        private int examId;
        private int candidateId;
        private string pathDirectory;

        public frmResultDetail(int examId, int candidateId)
        {
            this.examId = examId;
            this.candidateId = candidateId;
            pathDirectory = BLExam.GetExam(examId).Folder + "\\" + BLCandidate.GetCandidate(candidateId).Code;
            InitializeComponent();
            Text = BLCandidate.GetCandidate(candidateId).Code + " - Thí sinh";
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                lblExamName.Text = BLExam.GetExam(examId).Name;
                lblCandidateCode.Text = BLCandidate.GetCandidate(candidateId).Code;
                lblName.Text = BLCandidate.GetCandidate(candidateId).Name;
                lblSumMark.Text = BLResult.SumMark(candidateId, examId) + "/" + BLExam.SumMark(examId);
                dgvQuestions.DataSource = BLExamDetail.GetExamDetails(x => x.ExamID == examId, y => new { y.FileName, y.QuestionID, QuestionName = BLQuestion.GetQuestion(y.QuestionID).Name }).OrderBy(x => x.FileName).ToList();
                dgvQuestions.Columns["QuestionID"].Visible = false;
                dgvQuestions_CellClick(null, new DataGridViewCellEventArgs(0, 0));
                dgvTasks.DataSource = new DirectoryInfo(pathDirectory).GetFiles().Select(x => new { Task = x.Name }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pathDirectory))
            {
                Process.Start("explorer.exe", pathDirectory);
            }
            else MessageBox.Show("Không tồn tại thư mục thí sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegrade_Click(object sender, EventArgs e)
        {
            List<string> fileNames = new List<string>();
            foreach (DataGridViewRow row in dgvTasks.SelectedRows)
                fileNames.Add(row.Cells["Task"].Value.ToString());
            FileInfo[] files = new DirectoryInfo(pathDirectory).GetFiles().Where(x => fileNames.Contains(x.Name)).ToArray();
            Utility.Grading(examId, candidateId, files, new Dictionary<string, Compare>(), 2000);
            LoadData();
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int questionId = int.Parse(dgvQuestions.Rows[e.RowIndex].Cells["QuestionID"].Value.ToString());
            if (BLQuestion.GetQuestion(questionId) != null)
            {
                frmQuestionView frmQuestionView = new frmQuestionView(questionId);
                if (!Initialize.CheckOpened(frmQuestionView))
                    frmQuestionView.Show();
            }
            else MessageBox.Show("Nội dung không tồn tại hoặc đã bị xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string task = dgvTasks.Rows[e.RowIndex].Cells["Task"].Value.ToString();
                StreamReader reader = new StreamReader(pathDirectory + "\\" + task);
                frmEditText frmEditText = new frmEditText(reader.ReadToEnd(), task + " - File");
                reader.Close();
                frmEditText.ShowDialog();
                if (frmEditText.Modify)
                {
                    StreamWriter writer = new StreamWriter(pathDirectory + "\\" + task);
                    writer.Write(frmEditText.Content);
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int questionId = int.Parse(dgvQuestions.Rows[e.RowIndex].Cells["QuestionID"].Value.ToString());
            var testcaseIds = BLTestCase.GetTestCases(x => x.QuestionID == questionId, y => y.ID);

            dgvTestCases.DataSource = BLResult.GetResults(x => x.ExamID == examId && x.CandidateID == candidateId && testcaseIds.Contains(x.TestCaseID), y => new
            {
                TestCaseName = BLTestCase.GetTestCase(y.TestCaseID).Name,
                Input = BLTestCase.GetPropertyValue(a => a.ID == y.TestCaseID, b => b.Input),
                CandidateOutput = y.Output,
                Output = BLTestCase.GetPropertyValue(a => a.ID == y.TestCaseID, b => b.Output),
                RateTime = y.RunTime + "/" + BLTestCase.GetPropertyValue(a => a.ID == y.TestCaseID, b => b.TimeLimit),
                RateMemory = y.UsedMemory + "/" + BLTestCase.GetPropertyValue(a => a.ID == y.TestCaseID, b => b.MemoryLimit),
                y.Mark,
                y.Notification
            }).OrderBy(x => x.TestCaseName).ToList();

            lblMark.Text = BLResult.SumMark(candidateId, examId, questionId) + "/" + BLQuestion.SumMark(questionId);
        }

        private void frmResultDetail_SizeChanged(object sender, EventArgs e)
        {
            dgvQuestions.Height = (panel2.Height - (panel5.Height + btnRegrade.Height + btnOpenFolder.Height)) / 2;
        }

        private void dgvTestCases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new frmEditText(dgvTestCases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), dgvTestCases.Columns[e.ColumnIndex].HeaderText, true).Show();
            }
        }

        private void frmResultDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                LoadData();
        }
    }
}
