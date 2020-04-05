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
    public partial class frmEditText : Form
    {
        private string content;
        private bool modify = false;

        public string Content { get => content; set => content = value; }
        public bool Modify { get => modify; }

        public frmEditText(string content)
        {
            Content = content;
            InitializeComponent();
            txtContent.Text = content;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Content.Equals(txtContent.Text))
            {
                Content = txtContent.Text;
                modify = true;
            }
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!Content.Equals(txtContent.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Nội dung của bạn chưa được lưu. Lưu lại?", "Thông tin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    btnOK_Click(null, null);
                }
                else Hide();
            }
        }
    }
}
