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
        public frmManageCandidate()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            List<string> lstItems = new List<string>();
            lstItems.Add("All");
            lstItems.AddRange(BLExam.GetExams(x => x.Name).ToList());
            cbExamID.DataSource = lstItems;
            RefreshCandidates();
        }

        private void RefreshCandidates(int examId = -1)
        {
            if (examId == -1)
                dgvCandidates.DataSource = BusinessLogic.Search(BLCandidate.GetCandidates().Select(x => new { x.ID, x.Name, x.Phone, x.Email }), txtSearch.Text).ToList();
            else dgvCandidates.DataSource = BusinessLogic.Search(BLCandidateDetail.GetCandidates(examId).Select(x => new { x.ID, x.Name, x.Phone, x.Email }), txtSearch.Text).ToList();
        }

        private void dgvCandidate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCandidateView frmCandidateView = new frmCandidateView((int)dgvCandidates.Rows[e.RowIndex].Cells["ID"].Value);
            frmCandidateView.ShowDialog();
        }

        private void cbExamID_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshCandidates();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshCandidates();
        }
    }
}
