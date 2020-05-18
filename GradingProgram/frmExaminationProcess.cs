using System;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmExaminationProcess : Form
    {
        private string candidateName;
        private string questionName;
        private string testCaseName;

        public bool HasCanceled { get; set; }

        public string CandidateName { set { candidateName = value; RefreshTest(); } }

        public string QuestionName { set { questionName = value; RefreshTest(); } }

        public string TestCaseName { set { testCaseName = value; RefreshTest(); } }

        public frmExaminationProcess()
        {
            HasCanceled = false;
            InitializeComponent();
            Show();
        }

        private void rtbNotifications_TextChanged(object sender, EventArgs e)
        {
            rtbNotifications.SelectionStart = rtbNotifications.Text.Length;
            rtbNotifications.ScrollToCaret();
        }

        private void RefreshTest()
        {
            Text = "Đang chấm " + candidateName + " - " + questionName + " - " + testCaseName;
        }

        private void frmExaminationProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult dialogResult = MessageBox.Show("Dừng chấm?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HasCanceled = true;
                }
                else e.Cancel = true;
            }
        }

        public new void Close()
        {
            FormClosing -= frmExaminationProcess_FormClosing;
            base.Close();
        }
    }
}
