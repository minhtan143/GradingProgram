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
    public partial class frmCandidateView : Form
    {
        public frmCandidateView()
        {
            InitializeComponent();
            ExampleData();
        }

        private void ExampleData()
        {
            lblCandidateID.Text = "17110000";
            txtName.Text = "Nguyễn Văn A";
            txtEmail.Text = "17110000@student.hcmute.edu.vn";
            dgvExam.Rows.Add(new object[] { "KITHI01", "Thi cuối kì", 10 });
        }

        private void dgvExam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmResultDetail frmResultDetail = new frmResultDetail("", "");
            frmResultDetail.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            btnSave.Visible = true;
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            btnSave.Visible = false;
            btnEdit.Enabled = true;
        }
    }
}
