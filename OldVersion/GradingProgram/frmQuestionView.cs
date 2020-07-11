using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmQuestionView : Form
    {
        private int questionId;
        private bool modify;

        public frmQuestionView(int questionId)
        {
            this.questionId = questionId;
            InitializeComponent();
            Initialize.SetUpForm(this);
            Text = BLQuestion.GetQuestion(questionId).Name + " - Câu hỏi";
            LoadData();
        }

        private void LoadData()
        {
            txtQuestionName.Text = BLQuestion.GetPropertyValue(x => x.ID == questionId, y => y.Name);
            txtContent.Text = BLQuestion.GetPropertyValue(x => x.ID == questionId, y => y.Detail);

            TestCaseRefresh();

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnOK.Visible = true;
            modify = false;
        }

        private void TestCaseRefresh()
        {
            dgvTestCases.DataSource = BusinessLogic.ToDataTable(BLTestCase.GetTestCases(x => x.QuestionID == questionId, x => new { x.ID, x.Name, x.Input, x.Output, x.TimeLimit, x.MemoryLimit, x.Mark }).OrderBy(x => x.Name));
        }

        private void dgvTestCases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvTestCases.Columns[e.ColumnIndex].Name != "Delete")
                {
                    DataGridViewRow row = dgvTestCases.Rows[e.RowIndex];
                    DataGridViewColumn column = dgvTestCases.Columns[e.ColumnIndex];

                    frmEditText frmEditText = new frmEditText(row.Cells[e.ColumnIndex].Value.ToString(), column.HeaderText);
                    frmEditText.ShowDialog();

                    if (frmEditText.Modify)
                    {
                        int testcaseId = int.Parse(row.Cells["ID"].Value.ToString());
                        TestCase testCase = BLTestCase.GetTestCase(testcaseId);
                        switch (column.Name)
                        {
                            case "TestCaseName": testCase.Name = frmEditText.Content; break;
                            case "Input": testCase.Input = frmEditText.Content; break;
                            case "Output": testCase.Output = frmEditText.Content; break;
                            case "TimeLimit": testCase.TimeLimit = int.Parse(frmEditText.Content); break;
                            case "MemoryLimit": testCase.MemoryLimit = int.Parse(frmEditText.Content); break;
                            case "Mark": testCase.Mark = int.Parse(frmEditText.Content); break;
                        }
                        BLTestCase.AddOrUpdate(testCase);
                        TestCaseRefresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            frmSettingTestCase frmSetUpTestCase = new frmSettingTestCase();
            if (frmSetUpTestCase.ShowDialog() == DialogResult.OK)
            {
                List<TestCase> testCases = BLTestCase.GetTestCases(questionId);
                testCases.ForEach(x =>
                {
                    x.TimeLimit = (int)frmSetUpTestCase.nudTimeOut.Value;
                    x.MemoryLimit = (int)frmSetUpTestCase.nudMemoryLimit.Value;
                    x.Mark = (int)frmSetUpTestCase.nupMark.Value;
                });
                BLTestCase.AddOrUpdate(testCases);
                TestCaseRefresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Question question = BLQuestion.GetQuestion(questionId);
                if (question.Name != txtQuestionName.Text.Trim())
                {
                    if (BLQuestion.Exists(txtQuestionName.Text.Trim()))
                        throw new Exception("Tên câu hỏi đã tồn tại!");
                    question.Name = txtQuestionName.Text.Trim();
                }
                question.Detail = txtContent.Text.Trim();
                BLQuestion.Update(question);
                btnSave.Visible = false;
                btnOK.Visible = true;
                btnCancel.Visible = false;
                modify = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            modify = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnOK.Visible = false;
        }

        private void frmQuestionView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddTestCase frmAddTestCase = new frmAddTestCase(questionId);
            frmAddTestCase.ShowDialog();
            if (frmAddTestCase.TestCaseID != 0)
            {
                TestCaseRefresh();
                foreach (DataGridViewRow row in dgvTestCases.Rows)
                    if (row.Cells["ID"].Value.ToString() == frmAddTestCase.TestCaseID.ToString())
                    {
                        row.Selected = true;
                        break;
                    }
            }
        }

        private void dgvTestCases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTestCases.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (e.RowIndex < 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Xóa tất cả testcase?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        List<TestCase> testCases = BLTestCase.GetTestCases(questionId);
                        BLTestCase.Delete(testCases);
                        TestCaseRefresh();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa testcase này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        TestCase testCases = BLTestCase.GetTestCase(int.Parse(dgvTestCases.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                        BLTestCase.Delete(testCases);
                        TestCaseRefresh();
                        if (e.RowIndex > 0)
                            dgvTestCases.Rows[e.RowIndex - 1].Selected = true;
                    }
                }
            }
        }

        private void btnAddFromFile_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<TestCase> testCases = Utility.ScanTestCases(dialog.FileName);
                testCases.ForEach(x => x.QuestionID = questionId);
                BLTestCase.AddOrUpdate(testCases);
                TestCaseRefresh();
                Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
