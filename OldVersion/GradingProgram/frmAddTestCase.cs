using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmAddTestCase : Form
    {
        private int questionId;

        private int testCaseId = 0;

        public int TestCaseID { get => testCaseId; }

        public frmAddTestCase(int questionId)
        {
            this.questionId = questionId;
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            int count = 0;
            while (BLTestCase.Exists(questionId, "Test" + count)) count++;
            txtName.Text = "Test" + count;
        }

        private void frmAddTestCase_SizeChanged(object sender, EventArgs e)
        {
            rtbInput.Width = (Width - 16) / 2;
            lblOutput.Location = new Point((Width - 16) / 2, lblOutput.Location.Y);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(rtbInput.Text) && !String.IsNullOrEmpty(rtbOutput.Text))
            {
                TestCase testCase = new TestCase();
                testCase.Name = txtName.Text;
                testCase.Input = rtbInput.Text;
                testCase.Output = rtbOutput.Text;
                testCase.QuestionID = questionId;
                BLTestCase.AddOrUpdate(testCase);
                testCaseId = testCase.ID;
                Close();
            }
            else MessageBox.Show("Không được để trống nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
