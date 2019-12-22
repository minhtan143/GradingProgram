using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProject
{
    public partial class frmQuestions : Form
    {
        List<TestCase> lstTestCase;
        int previousRow = -1;
        public frmQuestions()
        {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            /// Interface
            txtQuestionName.Enabled = true;
            rtxQuestionInput.Enabled = true;
            rtxQuestionOutput.Enabled = true;
            rtxQuestionContent.Enabled = true;
            dgvSetupTest.Enabled = true;
            btnSaveQuestion.Visible = true;

            btnAddQuestion.Visible = false;
            dgvQuestions.Enabled = false;
            ///
            lstTestCase = new List<TestCase>();
        }

        private void dgvSetupTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgvSetupTest.CurrentRow.Index;
            if (previousRow != -1)
                if (previousRow != currentRow)// click new row , save previous row
                {
                    try
                    {
                        if (lstTestCase.Count < dgvSetupTest.Rows.Count - 1)
                            lstTestCase.Add(new TestCase());
                        lstTestCase[previousRow] = new TestCase()
                        {
                            Name = dgvSetupTest.Rows[previousRow].Cells[1].Value.ToString(),
                            Mark = int.Parse(dgvSetupTest.Rows[previousRow].Cells[2].Value.ToString()),
                            MemoryLimit = int.Parse(dgvSetupTest.Rows[previousRow].Cells[3].Value.ToString()),
                            TimeOut = int.Parse(dgvSetupTest.Rows[previousRow].Cells[4].EditedFormattedValue.ToString()),
                            Input = rtxQuestionInput.Text,
                            Output = rtxQuestionOutput.Text,
                            QuestionID = 1
                        };
                    }
                    catch { }
                }
            // in current row, show input output
            try
            {
                rtxQuestionInput.ResetText();
                rtxQuestionOutput.ResetText();
                rtxQuestionInput.Text = lstTestCase[currentRow].Input;
                rtxQuestionOutput.Text = lstTestCase[currentRow].Output;
            }
            catch { }
            previousRow = currentRow;
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            Question qtn = new Question() // question for add to DB
            {
                Name = txtQuestionName.Text,
                Detail = rtxQuestionContent.Text,
                CreateDate = DateTime.Now.Date,
                Status = true
            };
            /// Add qtn to DB here

            /// 
            // reset questionID for testcase
            foreach (TestCase tc in lstTestCase)
                tc.QuestionID = qtn.ID;
            /// Add testcase to DB here

            /// 
        }
    }
}
