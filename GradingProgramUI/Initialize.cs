using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GradingProgram
{
    public static class Initialize
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, uint Msg);

        private const uint SW_RESTORE = 0x09;

        public static bool CheckOpened(Form form)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == form.Text)
                {
                    ShowWindow(frm.Handle, SW_RESTORE);
                    frm.Focus();
                    return true;
                }
            }
            return false;
        }

        public static void SetUpForm(Form form)
        {
            form.Icon = Properties.Resources.logoGG;

            foreach (var control in form.Controls) 
            {
                if (control is TabControl)
                    SetUpTab(control as TabControl);
                if (control is Panel) 
                    SetUpPnl(control as Panel);

                if (control is Button) 
                    SetUpBtn(control as Button);

                if (control is DataGridView)
                    SetUpDgv(control as DataGridView);
            }
        }

        public static void SetUpTab(TabControl tab)
        {
            
            foreach (TabPage tp in tab.TabPages)
                foreach (var control in tp.Controls)
                {
                    if (control is Panel)
                        SetUpPnl(control as Panel);

                    if (control is Button)
                        SetUpBtn(control as Button);

                    if (control is DataGridView)
                        SetUpDgv(control as DataGridView);
                }
        }

        public static void SetUpDgv(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.Lavender;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
        }

        public static void SetUpPnl(Panel pnl)
        {
            pnl.BackgroundImage = Properties.Resources.bgrPnl;
            pnl.BackgroundImageLayout = ImageLayout.Stretch;

            foreach (var control in pnl.Controls)
            {
                if (control is Label)
                    (control as Label).BackColor = Color.Transparent;
                if (control is Button)
                    SetUpBtn(control as Button);
            }
        }

        public static void SetUpBtn(Button btn)
        {
            btn.BackgroundImage = Properties.Resources.bgrBtn;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.Cursor = Cursors.Hand;

            btn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));


            btn.MouseDown += new MouseEventHandler(MouseDown);
            btn.MouseUp += new MouseEventHandler(MouseUp);
            btn.MouseMove += new MouseEventHandler(MouseMove);
            btn.MouseLeave += new EventHandler(MouseLeave);
        }

        private static void MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrDown;
        }

        private static void MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrBtn;
        }

        private static void MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrBtn;
        }
        private static void MouseMove(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrOver;
        }
    }
}
