using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmManageExam : Form
    {
        public frmManageExam()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            Text = "Quản lý kì thi";
            LoadData();
        }

        private void LoadData()
        {
            dgvExams.DataSource = BusinessLogic.ToDataTable(BLExam.GetExams(x => new { x.ID, x.Name, x.Folder, x.CreateDate }));
            dgvExams.Columns["ID"].Visible = false;
        }

        private void dgvExams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmExamView frmExamView = new frmExamView(int.Parse(dgvExams.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                if (!Initialize.CheckOpened(frmExamView))
                    frmExamView.Show();
            }
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvExams.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa kì thi này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Exam exam = BLExam.GetExam(int.Parse(dgvExams.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                    BLExam.Delete(exam);
                    LoadData();
                }
            }
        }
    }
}
