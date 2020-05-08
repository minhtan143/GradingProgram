using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmMain : Form
    {
        private int examId;

        public frmMain()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            cbExamName.DisplayMember = "Name";
            cbExamName.DataSource = BusinessLogic.ToDataTable(BLExam.GetExams(x => new { x.ID, x.Name }));
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmResultDetail frmResultDetail = new frmResultDetail(examId, int.Parse(dgvResults.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                if (!Initialize.CheckOpened(frmResultDetail))
                    frmResultDetail.Show();
            }
        }

        private void createQuestionTSMI_Click(object sender, EventArgs e)
        {
            frmAddQuestion frmAddQuestion = new frmAddQuestion();
            frmAddQuestion.TopMost = true;
            if (frmAddQuestion.ShowDialog() == DialogResult.OK)
                new frmQuestionView(frmAddQuestion.QuestionID).Show();
        }

        private void manageQuestionTSMI_Click(object sender, EventArgs e)
        {
            frmManageQuestion frmManageQuestion = new frmManageQuestion();
            if (!Initialize.CheckOpened(frmManageQuestion))
                frmManageQuestion.Show();
        }

        private void manageExamTSMI_Click(object sender, EventArgs e)
        {
            frmManageExam frmManageExam = new frmManageExam();
            if (!Initialize.CheckOpened(frmManageExam))
                frmManageExam.Show();
        }

        private void createExamTSMI_Click(object sender, EventArgs e)
        {
            //frmExamView frmExamView = new frmExamView(1);

            //frmExamView.ShowDialog();
        }

        private void manageCandidateTSMI_Click(object sender, EventArgs e)
        {
            frmManageCandidate frmManageCandidate = new frmManageCandidate();
            if (!Initialize.CheckOpened(frmManageCandidate))
                frmManageCandidate.Show();
        }

        private void cbExamName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbExamName.SelectedIndex >= 0)
            {
                examId = int.Parse((cbExamName.DataSource as DataTable).Rows[cbExamName.SelectedIndex].ItemArray[0].ToString());
                lblExamName.Text = BLExam.GetExam(examId).Name;
                lblDate.Text = BLExam.GetExam(examId).CreateDate.ToString();

                while (dgvResults.ColumnCount > 3)
                    dgvResults.Columns.RemoveAt(3);
                dgvResults.DataSource = BLCandidate.GetCandidateWithMark(examId);
                dgvResults.Columns["ID"].Visible = false;

                Text = cbExamName.Text + " - Chấm thi tự động";
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void refreshTSMI_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void setupGradingTSMI_Click(object sender, EventArgs e)
        {
            new frmSettingGrading(BLExam.GetExam(examId).Folder).ShowDialog();
        }

        private void gradingThisExamTSMI_Click(object sender, EventArgs e)
        {
            Task.Run(() => Utility.Grading(examId));
            LoadData();
        }
    }
}
