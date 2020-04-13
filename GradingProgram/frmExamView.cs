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
    public partial class frmExamView : Form
    {
        private string examId;

        public string ExamID { get => examId; set => examId = value; }

        public frmExamView()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
        }

        public frmExamView(string examId)
        {
            ExamID = examId;
            InitializeComponent();
            ExampleData();
        }

        private void ExampleData()
        {
            txtExamID.Text = "KITHI01";
            txtExamName.Text = "Thi cuối kì";
            txtPathFolder.Text = "C\\kithi01";
            dgvSelected.Rows.Add("Bai01");
            dgvSelected.Rows.Add("Bai02");
            dgvQuestions.Rows.Add("Bai03");
            dgvQuestions.Rows.Add("Bai04");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //messageBox
            Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //create
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*ListViewItem item = lstViewQuestion.SelectedItems[0];
            lstViewSelected.Items.Add(item);
            lstViewQuestion.Items.Remove(item);*/
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            /*ListViewItem item = lstViewSelected.SelectedItems[0];
            lstViewQuestion.Items.Add(item);
            lstViewSelected.Items.Remove(item);*/
        }

        private void dgvSelected_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string questionId = (sender as ListView).SelectedItems[0].SubItems[0].Text;
            frmQuestionView frmQuestionView = new frmQuestionView(""/*questionId*/);
            frmQuestionView.ShowDialog();
        }
    }
}
