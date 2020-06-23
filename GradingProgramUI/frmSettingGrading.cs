using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmSettingGrading : Form
    {
        private string path;
        private Dictionary<string, Compare> setting = null;
        private List<ExamDetail> questions;

        public Dictionary<string, Compare> Setting { get => setting; }

        public frmSettingGrading(int examId)
        {
            path = BLExam.GetExam(examId).Folder + "\\Setting.txt";
            questions = BLExamDetail.GetExamDetails(x => x.ExamID == examId);
            InitializeComponent();
            gbSetting.Text = BLExam.GetExam(examId).Name;
            LoadData();
        }

        private void LoadData()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                ViewSetting(questions[i].FileName, new Point(30, 40 + i * 40), gbSetting);
            }
            Height = (questions.Count + 3) * 40 + panel1.Height;
            Initialize.SetUpForm(this);
            if (File.Exists(path))
            {
                try
                {
                    setting = Utility.ReadFromBinaryFile(path);
                    foreach (ExamDetail question in questions)
                    {
                        ComboBox comboBox = (ComboBox)gbSetting.Controls.Find("cb" + question.FileName, true).First();
                        comboBox.SelectedItem = Setting[question.FileName].ToString();
                    }
                }
                catch 
                {
                    MessageBox.Show("Tệp cài đặt không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, Compare> setting = new Dictionary<string, Compare>();

            foreach (ExamDetail question in questions)
            {
                ComboBox comboBox = (ComboBox)gbSetting.Controls.Find("cb" + question.FileName, true).First();
                Compare temp = Compare.CStringCase;
                Enum.TryParse(comboBox.SelectedItem.ToString(), out temp);
                setting[question.FileName] = temp;
            }

            Utility.WriteToBinaryFile(path, setting);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ViewSetting(string name, Point location, Control control)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(location.X, location.Y);
            label.Name = "lbl" + name;
            label.Text = name;

            ComboBox comboBox = new ComboBox();
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(location.X + 70, location.Y);
            comboBox.Name = "cb" + name;
            comboBox.Size = new Size(220, 25);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.AddRange(Enum.GetNames(typeof(Compare)));
            comboBox.SelectedItem = Compare.CStringCase.ToString();

            control.Controls.Add(label);
            control.Controls.Add(comboBox);
        }
    }
}
