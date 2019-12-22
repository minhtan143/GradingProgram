using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmItemQuestionsManagement_Click(object sender, EventArgs e)
        {
            frmQuestions frmQuestions = new frmQuestions();
            this.Hide();
            frmQuestions.ShowDialog();
            this.Show();
        }
    }
}
