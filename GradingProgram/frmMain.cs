using System;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            BLExam.GetExam().ToList();
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmResultDetail frmResultDetail = new frmResultDetail("", ""/*gvResult.Rows[e.RowIndex].Cells["MSSV"].Value.ToString()*/);
            frmResultDetail.ShowDialog();
        }

        private void createQuestionTSMI_Click(object sender, EventArgs e)
        {
            frmQuestionView frmQuestionView = new frmQuestionView();
            frmQuestionView.ShowDialog();
        }

        private void manageQuestionTSMI_Click(object sender, EventArgs e)
        {
            frmManageQuestion frmManageQuestion = new frmManageQuestion();
            frmManageQuestion.ShowDialog();
        }

        private void manageExamTSMI_Click(object sender, EventArgs e)
        {
            frmManageExam frmManageExam = new frmManageExam();
            frmManageExam.ShowDialog();
        }

        private void createExamTSMI_Click(object sender, EventArgs e)
        {
            frmExamView frmExamView = new frmExamView();
            frmExamView.ShowDialog();
        }

        private void manageCandidateTSMI_Click(object sender, EventArgs e)
        {
            frmManageCandidate frmManageCandidate = new frmManageCandidate();
            frmManageCandidate.ShowDialog();
        }
    }
}
