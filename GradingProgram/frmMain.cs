using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

            settingCompareTSMI.Enabled = cbExamName.Items.Count > 0 ? true : false;
            gradingThisExamTSMI.Enabled = cbExamName.Items.Count > 0 ? true : false;
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
            frmAddExam frmAddExam = new frmAddExam();
            if (frmAddExam.ShowDialog() == DialogResult.OK)
                new frmExamView(frmAddExam.examID).Show();
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

                btnExportExcel.Enabled = dgvResults.RowCount > 0 ? true : false;
                Text = cbExamName.Text + " - Chấm thi tự động";
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Exam exam = BLExam.GetExam(examId);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Result_" + exam.Name;
            dialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel Macro-Enabled Workbook (*.xlsm)|*.xlsm|Excel 97-2003 Workbook (*.xls)|*.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.DisplayAlerts = false;

                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                Microsoft.Office.Interop.Excel.Range select = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dgvResults.Rows.Count + 4, dgvResults.Columns.Count - 1]];
                select.Font.Size = 13;
                select.Font.Name = "Arial";

                worksheet.Name = exam.Name;

                Microsoft.Office.Interop.Excel.Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgvResults.Columns.Count - 1]];
                range.Merge();
                range.Value = "Kỳ thi: " + exam.Name + "\n" + exam.CreateDate.ToString("\"Thời gian: \"dd/MM/yyyy");
                range.Font.Size = 14;
                range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                range.VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Rows[1].RowHeight = worksheet.Rows[1].RowHeight * 2;

                for (int i = 1; i < dgvResults.Columns.Count; i++)
                {
                    worksheet.Cells[3, i] = dgvResults.Columns[i].HeaderText;
                    worksheet.Columns[i].ColumnWidth = dgvResults.Columns[i].Width / 8;
                }
                worksheet.Columns[2].ColumnWidth = 30;

                for (int i = 0; i < dgvResults.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvResults.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 4, j] = dgvResults.Rows[i].Cells[j].Value.ToString();
                        if (j < 3)
                            worksheet.Cells[i + 4, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        else worksheet.Cells[i + 4, j].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }

                workbook.SaveAs(dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                app.Quit();

                DialogResult dialogResult = MessageBox.Show("Xuất file excel thành công. Mở ngay?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                    Process.Start(dialog.FileName);
            }
        }

        private void refreshTSMI_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void setupGradingTSMI_Click(object sender, EventArgs e)
        {
            new frmSettingGrading(examId).ShowDialog();
        }

        private void gradingThisExamTSMI_Click(object sender, EventArgs e)
        {
            Dictionary<string, Compare> settingGrading = new Dictionary<string, Compare>();
            try
            {
                settingGrading = Utility.ReadFromBinaryFile(BLExam.GetExam(examId).Folder + "\\Setting.txt");
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Không tìm thấy hoặc đọc lỗi từ tệp cài đặt 'Setting.txt'. Tạo mới?\nChọn No để chấm mặc định.", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    frmSettingGrading frmSettingGrading = new frmSettingGrading(examId);
                    frmSettingGrading.ShowDialog();
                    DialogResult dialog = MessageBox.Show("Tiếp tục chấm?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        gradingThisExamTSMI_Click(null, null);
                        return;
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                    return;
            }

            Utility.Grading(examId, settingGrading, 2000);
            LoadData();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            int examId = this.examId;
            LoadData();

            DataTable data = cbExamName.DataSource as DataTable;
            foreach (DataRow row in data.Rows)
            {
                if (row.ItemArray[0].ToString() == examId.ToString())
                {
                    cbExamName.SelectedIndex = data.Rows.IndexOf(row);
                    break;
                }
            }
        }

        private void settingCompilerTSMI_Click(object sender, EventArgs e)
        {
            new frmSettingCompiler().ShowDialog();
        }
    }
}
