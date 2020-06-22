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

        public string Content { get => content; }
        public bool Modify { get => modify; }

        public frmEditText(string content, string name, bool readOnly = false)
        {
            this.content = content;
            InitializeComponent();
            txtContent.Text = content;
            Text = name;
            Initialize.SetUpForm(this);
            if (readOnly)
            {
                btnCancel.Visible = false;
                txtContent.ReadOnly = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (modify)
                content = txtContent.Text;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (modify)
            {
                DialogResult dialogResult = MessageBox.Show("Nội dung của bạn chưa được lưu. Lưu lại?", "Thông tin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    btnOK_Click(null, null);
                else if (dialogResult == DialogResult.No)
                    Hide();
            }
            else Hide();
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            modify = true;
        }
    }
}
