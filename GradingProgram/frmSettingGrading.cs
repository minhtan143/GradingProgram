using System;
using System.IO;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmSettingGrading : Form
    {
        private string path;

        public frmSettingGrading(string path)
        {
            this.path = path + "\\SetUp.txt";
            InitializeComponent();
            if (!File.Exists(path))
                LoadData();
        }

        private void LoadData()
        {
            throw new NotImplementedException();
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in gbLanguageGrading.Controls)
            {
                if (control is CheckBox)
                    (control as CheckBox).Checked = (sender as CheckBox).Checked;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine();
            writer.Close();
        }
    }
}
