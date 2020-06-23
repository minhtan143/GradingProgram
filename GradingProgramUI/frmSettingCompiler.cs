using System;
using System.Data;
using System.Windows.Forms;

namespace GradingProgram
{
    public partial class frmSettingCompiler : Form
    {
        private bool modify;
        private int index;
        public frmSettingCompiler()
        {
            InitializeComponent();
            Initialize.SetUpForm(this);
            dgvSettingCompiler.ReadOnly = false;
            dgvSettingCompiler.AllowUserToAddRows = true;
            dgvSettingCompiler.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //lblGuid.Text = "► Thêm tại dòng trống cuối cùng\n► Xóa: Nhấn Delete\n► Chuyển lên: Alt + ↑; Chuyển xuống: Alt + ↓\n► Đặt lại mặc định: Ctrl + R";
            LoadData();
        }

        private void LoadData()
        {
            DataTable data = Utility.ReadFromSetting();
            dgvSettingCompiler.Rows.Clear();
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

            for (int i = 0; i < dgvSettingCompiler.RowCount - 1; i++)
                data.Rows.Add(dgvSettingCompiler.Rows[i].Cells[0].Value.ToString(), dgvSettingCompiler.Rows[i].Cells[1].Value.ToString());

            Utility.WriteToSetting(data);
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void frmSettingCompiler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
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
        }

        private void dgvSettingCompiler_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Alt)
            //{
            //    int index = dgvSettingCompiler.CurrentRow.Index;
            //    if (e.KeyCode == Keys.Up && index > 0)
            //    {
            //        DataGridViewRow temp = dgvSettingCompiler.Rows[index];
            //        dgvSettingCompiler.Rows.Remove(temp);
            //        dgvSettingCompiler.Rows.Insert(index - 1, temp);
            //        dgvSettingCompiler.Rows[index].Cells[dgvSettingCompiler.CurrentCell.ColumnIndex].Selected = true;
            //    }
            //    else if (e.KeyCode == Keys.Down && index < dgvSettingCompiler.RowCount - 2)
            //    {
            //        DataGridViewRow temp = dgvSettingCompiler.Rows[index];
            //        dgvSettingCompiler.Rows.Remove(temp);
            //        dgvSettingCompiler.Rows.Insert(index + 1, temp);
            //    }
            //}
            //else if (e.KeyData == Keys.Delete)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Xóa cài đặt này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //        dgvSettingCompiler.Rows.Remove(dgvSettingCompiler.CurrentRow);
            //}
            //else if (e.Control && e.KeyCode == Keys.R)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Khôi phục tất cả cài đặt bộ dịch về mặc định?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        Utility.DefaultSettingCompiler();
            //        LoadData();
            //    }
            //}
        }

        private void dgvSettingCompiler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            modify = true;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Khôi phục tất cả cài đặt bộ dịch về mặc định?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Utility.DefaultSettingCompiler();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa cài đặt này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                dgvSettingCompiler.Rows.Remove(dgvSettingCompiler.CurrentRow);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            index = dgvSettingCompiler.CurrentRow.Index;
            if (index < dgvSettingCompiler.RowCount - 2)
            {
                DataGridViewRow temp = dgvSettingCompiler.Rows[index];
                dgvSettingCompiler.Rows.Remove(temp);
                dgvSettingCompiler.Rows.Insert(index + 1, temp);
                dgvSettingCompiler.Rows[index+1].Cells[dgvSettingCompiler.CurrentCell.ColumnIndex].Selected = true;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            index = dgvSettingCompiler.CurrentRow.Index;
            if (index > 0)
            {
                DataGridViewRow temp = dgvSettingCompiler.Rows[index];
                dgvSettingCompiler.Rows.Remove(temp);
                dgvSettingCompiler.Rows.Insert(index - 1, temp);
                dgvSettingCompiler.Rows[index-1].Cells[dgvSettingCompiler.CurrentCell.ColumnIndex].Selected = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
