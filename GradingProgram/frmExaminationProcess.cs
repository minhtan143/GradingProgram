using System;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmExaminationProcess : Form
    {
        private string candidateName;
        private string questionName;
        private string testCaseName;

        public string CandidateName { set { candidateName = value; RefreshTest(); } }

        public string QuestionName { set { questionName = value; RefreshTest(); } }

        public string TestCaseName { set { testCaseName = value; RefreshTest(); } }

        public frmExaminationProcess()
        {
            InitializeComponent();
        }

        private void rtbNotifications_TextChanged(object sender, EventArgs e)
        {
            rtbNotifications.SelectionStart = rtbNotifications.Text.Length;
            rtbNotifications.ScrollToCaret();
            Refresh();
        }

        private void RefreshTest()
        {
            Text = "Đang chấm " + candidateName + " - " + questionName + " - " + testCaseName;
            Refresh();
        }
    }
}
