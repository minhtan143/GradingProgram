using GradingProgram.Data.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmMain : Form
    {
        private BLCandidate bLCandidate;
        private Initialize initialize;
        public frmMain()
        {
            bLCandidate = new BLCandidate();
            initialize = new Initialize();
            InitializeComponent();
            initialize.SetUpForm(this);
            _ = LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var data = await bLCandidate.GetCandidateOfExamAsync(1);
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
