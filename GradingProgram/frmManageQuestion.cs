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
    public partial class frmManageQuestion : Form
    {
        public frmManageQuestion()
        {
            InitializeComponent();
            ExampleData();
            Event evt = new Event();
            evt.SetUpForm(this);
        }

        private void ExampleData()
        {
            lblSum.Text = "1";
            dgvQuestions.Rows.Add(new object[] { "CAUHOI01", "Tìm tổng a và b...", 10 });
        }

        private void dgvQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmQuestionView frmQuestionView = new frmQuestionView(""/*questionId*/);
            frmQuestionView.ShowDialog();
        }
    }
}
