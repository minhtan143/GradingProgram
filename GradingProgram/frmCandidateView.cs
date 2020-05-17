using System;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmCandidateView : Form
    {
        private int candidateId;
        private bool modify;

        public frmCandidateView(int candidateId)
        {
            this.candidateId = candidateId;
            InitializeComponent();
            Initialize.SetUpForm(this);
            Text = BLCandidate.GetCandidate(candidateId).Code + " - Thí sinh";
            LoadData();
        }

        private void LoadData()
        {
            Candidate candidate = BLCandidate.GetCandidate(candidateId);

            lblCandidateCode.Text = candidate.Code;
            txtName.Text = candidate.Name;
            txtEmail.Text = candidate.Email;
            txtPhone.Text = candidate.Phone;

            dgvExam.DataSource = BusinessLogic.ToDataTable(BLCandidateDetail.GetExams(candidateId).Select(x => new { x.ID, x.Name, Mark = BLResult.SumMark(candidateId, x.ID) }));

            modify = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void dgvExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmResultDetail frmResultDetail = new frmResultDetail(int.Parse(dgvExam.Rows[e.RowIndex].Cells["ID"].Value.ToString()), candidateId);
            if (!Initialize.CheckOpened(frmResultDetail))
                frmResultDetail.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Candidate candidate = BLCandidate.GetCandidate(candidateId);
            candidate.Name = txtName.Text;
            candidate.Email = txtEmail.Text;
            candidate.Phone = txtPhone.Text;

            BLCandidate.Update(candidate);

            modify = false;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmCandidateView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modify)
            {
                DialogResult dialogResult = MessageBox.Show("Thay đổi của bạn chưa được lưu. Lưu lại?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    btnSave_Click(null, null);
                }
                else if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            modify = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }
    }
}
