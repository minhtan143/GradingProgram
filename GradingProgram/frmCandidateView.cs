using System;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmCandidateView : Form
    {
        private int candidateId;

        public frmCandidateView(int candidateId)
        {
            this.candidateId = candidateId;
            InitializeComponent();
            Initialize.SetUpForm(this);
            LoadData();
        }

        private void LoadData()
        {
            lblCandidateID.Text = BLCandidate.GetCandidate(candidateId).ID.ToString();
            txtName.Text = BLCandidate.GetCandidate(candidateId).Name;
            txtEmail.Text = BLCandidate.GetCandidate(candidateId).Email;
            dgvExam.Rows.Add(new object[] { "KITHI01", "Thi cuối kì", 10 });
        }

        private void dgvExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmResultDetail frmResultDetail = new frmResultDetail(0, 0);
            frmResultDetail.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            btnSave.Visible = false;
        }
    }
}
