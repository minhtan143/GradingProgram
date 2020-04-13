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
    public partial class frmResultDetail : Form
    {
        private string examId;
        private string candidateId;

        public string ExamID { get => examId; set => examId = value; }
        public string CandidateID { get => candidateId; set => candidateId = value; }

        public frmResultDetail()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
        }

        public frmResultDetail(string examId, string candidateId)
        {
            ExamID = examId;
            CandidateID = candidateId;
            InitializeComponent();
            ExampleData();
        }

        private void ExampleData()
        {
            lblExamID.Text = "KITHI01";
            lblCandidateID.Text = "17110000";
            lblName.Text = "Nguyễn Văn A";
            lblSumMark.Text = "100";
            dgvQuestions.Rows.Add("Bai01");
            dgvQuestions.Rows.Add("Bai02");
            dgvQuestions.Rows.Add("Bai03");
            dgvQuestions.Rows.Add("Bai04");
            dgvTask.Rows.Add("Bai1.cpp");
            dgvTask.Rows.Add("Bai1.exe");
            dgvTask.Rows.Add("Bai2.cpp");
            dgvTask.Rows.Add("Bai2.exe");
            dgvTask.Rows.Add("Bai3.cpp");
            dgvTask.Rows.Add("Bai3.exe");
            dgvTask.Rows.Add("Bai4.cpp");
            dgvTask.Rows.Add("Bai4.exe");
            dgvQuestionsDetail.Rows.Add(new object[] { "TEST01", 10, "Correct"});
            dgvQuestionsDetail.Rows.Add(new object[] { "TEST02", 10, "Correct"});
            dgvQuestionsDetail.Rows.Add(new object[] { "TEST03", 10, "Correct"});
            dgvQuestionsDetail.Rows.Add(new object[] { "TEST04", 10, "Correct"});
            dgvQuestionsDetail.Rows.Add(new object[] { "TEST05", 10, "Correct"});
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {

        }

        private void btnRegrade_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmQuestionView frmQuestionView = new frmQuestionView(""/*lstTask.SelectedItems[0].SubItems[0].Text*/);
            frmQuestionView.ShowDialog();
        }

        private void dgvTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEditText frmEditText = new frmEditText(""/*path to file open*/);
            frmEditText.ShowDialog();
        }
    }
}
