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
    public partial class frmSetUpTestCase : Form
    {
        public frmSetUpTestCase()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
