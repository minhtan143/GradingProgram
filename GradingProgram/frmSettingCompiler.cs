using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmSettingCompiler : Form
    {
        private bool modify;

        public frmSettingCompiler()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            dgvSettingCompiler.ReadOnly = false;
            dgvSettingCompiler.AllowUserToAddRows = true;
            dgvSettingCompiler.SelectionMode = DataGridViewSelectionMode.CellSelect;
            LoadData();
        }

        private void LoadData()
        {
            lblGuid.Text = "► Thêm tại dòng trống cuối cùng\n" +
                           "► Xóa: Nhấn Delete\n" +
                           "► Chuyển lên: Alt + ↑; Chuyển xuống: Alt + ↓";

            DataTable data = Utility.ReadFromSetting();
            foreach (DataRow row in data.Rows)
            {
                dgvSettingCompiler.Rows.Add(row.ItemArray);
            }

            modify = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable("SettingCompiler");
            data.Columns.Add("FileType");
            data.Columns.Add("Setting");

            foreach (DataGridViewRow row in dgvSettingCompiler.Rows)
                data.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());

            Utility.WriteToSetting(data);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSettingCompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modify)
            {
                DialogResult dialogResult = MessageBox.Show("Thay đổi của bạn chưa được lưu. Lưu lại?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                    btnSave_Click(null, null);
                else if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void dgvSettingCompiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                int index = dgvSettingCompiler.CurrentRow.Index;
                if (e.KeyCode == Keys.Up && index > 0)
                {
                    DataGridViewRow temp = dgvSettingCompiler.Rows[index];
                    dgvSettingCompiler.Rows.Remove(temp);
                    dgvSettingCompiler.Rows.Insert(index - 1, temp);
                    dgvSettingCompiler.Rows[index].Cells[dgvSettingCompiler.CurrentCell.ColumnIndex].Selected = true;
                }
                else if (e.KeyCode == Keys.Down && index < dgvSettingCompiler.RowCount - 2)
                {
                    DataGridViewRow temp = dgvSettingCompiler.Rows[index];
                    dgvSettingCompiler.Rows.Remove(temp);
                    dgvSettingCompiler.Rows.Insert(index + 1, temp);
                }
            }
            else if (e.KeyData == Keys.Delete)
            {
                DialogResult dialogResult = MessageBox.Show("Xóa cài đặt này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    dgvSettingCompiler.Rows.Remove(dgvSettingCompiler.CurrentRow);
            }
        }

        private void dgvSettingCompiler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modify = true;
        }
    }
}
