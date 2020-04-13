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
    public partial class frmQuestionView : Form
    {
        private string questionId;

        public string QuestionID { get => questionId; set => questionId = value; }

        public frmQuestionView()
        {
            InitializeComponent();
            btnEdit_Click(null, null);
            Initialize.SetUpForm(this);
        }

        public frmQuestionView(string questionId)
        {
            InitializeComponent();
            ExampleData();
            QuestionID = questionId;
        }

        private void ExampleData()
        {
            txtQuestionID.Text = "CAUHOI01";
            txtContent.Text = "Tìm tổng a và b được nhập từ bàn phím. Xuất ra màn hình kết quả tìm được.";
            dgvTestCase.Rows.Add(new object[] { "TEST01", "2 5", 7 });
            dgvTestCase.Rows.Add(new object[] { "TEST02", "10 20", 30 });
            dgvTestCase.Rows.Add(new object[] { "TEST03", "1 2", 3 });
            dgvTestCase.Rows.Add(new object[] { "TEST04", "10 5", 15 });
            dgvTestCase.Rows.Add(new object[] { "TEST05", "15 15", 30 });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnSetup.Visible = true;
            txtContent.ReadOnly = false;
            txtQuestionID.ReadOnly = false;
            dgvTestCase.ReadOnly = false;

            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnSetup.Visible = false;
            txtContent.ReadOnly = true;
            txtQuestionID.ReadOnly = true;
            dgvTestCase.ReadOnly = true;

            btnEdit.Enabled = true;
        }

        private void dgvTestCase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvTestCase.ReadOnly)
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    frmEditText frmEditText = new frmEditText(dgvTestCase.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    frmEditText.ShowDialog();
                    if (frmEditText.Modify)
                    {
                        //save
                    }
                }
        }
    }
}
