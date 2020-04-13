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
    public partial class frmManageExam : Form
    {
        public frmManageExam()
        {
            InitializeComponent();
            ExampleData();
            Initialize.SetUpForm(this);
        }

        private void ExampleData()
        {
            dgvExams.Rows.Add(new object[] { "KITHI01", "Thi cuối kì", "14/2/2020", "C\\kithi01" });
        }

        private void dgvExams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmExamView frmExamView = new frmExamView("");
            frmExamView.ShowDialog();
        }
    }
}
