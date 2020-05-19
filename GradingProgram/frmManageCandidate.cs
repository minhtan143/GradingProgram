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
    public partial class frmManageCandidate : Form
    {
        private int examId = 0;

        public frmManageCandidate()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            var data = BLExam.GetExams(x => new { x.ID, x.Name });
            data.Add(new { ID = 0, Name = "All" });

            cbExamName.DisplayMember = "Name";
            cbExamName.ValueMember = "ID";
            cbExamName.DataSource = BusinessLogic.ToDataTable(data.OrderBy(x => x.ID));
            RefreshCandidates(examId);
        }

        private void RefreshCandidates(int examId)
        {
            if (examId == 0)
                dgvCandidates.DataSource = BusinessLogic.Search(BLCandidate.GetCandidates().Select(x => new { x.ID, x.Code, x.Name, x.Phone, x.Email }).ToList(), txtSearch.Text).ToList();
            else dgvCandidates.DataSource = BusinessLogic.Search(BLCandidateDetail.GetCandidates(examId).Select(x => new { x.ID, x.Code, x.Name, x.Phone, x.Email }).ToList(), txtSearch.Text).ToList();
        }

        private void dgvCandidate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmCandidateView frmCandidateView = new frmCandidateView(int.Parse(dgvCandidates.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                if (!Initialize.CheckOpened(frmCandidateView))
                    frmCandidateView.Show();
            }
        }

        private void cbExamID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbExamName.SelectedIndex >= 0)
            {
                examId = int.Parse(cbExamName.SelectedValue.ToString());
                RefreshCandidates(examId);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshCandidates(examId);
        }

        private void frmManageCandidate_Activated(object sender, EventArgs e)
        {
            RefreshCandidates(examId);
        }
    }
}
