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
            ExampleData();
            Initialize.SetUpForm(this);
        }

        private void ExampleData()
        {
            dgvCandidate.Rows.Add(new object[] { "17110300", "Nguyễn Văn A", "17110300@student.hcmute.edu.vn" });
        }

        private void dgvCandidate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCandidateView frmCandidateView = new frmCandidateView();
            frmCandidateView.ShowDialog();
        }
    }
}
