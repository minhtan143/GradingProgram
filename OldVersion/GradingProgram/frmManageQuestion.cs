using System;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmManageQuestion : Form
    {
        public frmManageQuestion()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            dgvQuestions.DataSource = BusinessLogic.ToDataTable(BusinessLogic.Search(BLQuestion.GetQuestions(x => new { x.ID, x.Name, x.Detail }), txtSearch.Text));
            lblSum.Text = dgvQuestions.RowCount.ToString();
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvQuestions.Columns[e.ColumnIndex].Name;
            if (e.RowIndex >= 0 && columnName != "Delete")
            {
                frmQuestionView frmQuestionView = new frmQuestionView(int.Parse(dgvQuestions.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                if (!Initialize.CheckOpened(frmQuestionView))
                    frmQuestionView.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvQuestions.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa câu hỏi này?\nBạn không thể xem nội dung hay sửa câu hỏi này sau khi xóa." +
                    "\nThông tin kết quả của các bài kiểm tra liên quan đến câu hỏi vẫn được giữ lại!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    BLQuestion.Delete(int.Parse(dgvQuestions.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                    LoadData();
                }
            }
        }
    }
}
