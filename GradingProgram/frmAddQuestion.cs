using System;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmAddQuestion : Form
    {
        private int questionId = 0;

        public frmAddQuestion()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
        }

        public int QuestionID { get => questionId; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text.Trim()) && !String.IsNullOrEmpty(rtbDetail.Text.Trim()))
            {
                if (BLQuestion.Exists(txtName.Text.Trim()))
                    MessageBox.Show("Tên câu hỏi đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Question question = new Question();
                    question.Name = txtName.Text.Trim();
                    question.Detail = rtbDetail.Text.Trim();
                    BLQuestion.Add(question);
                    questionId = question.ID;
                    Hide();
                }
            }
            else MessageBox.Show("Không được để trống nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
