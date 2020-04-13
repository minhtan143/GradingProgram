using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingProgram
{
    public class Event
    {

        public void SetUpForm(Form form)
        {
            foreach (var var in form.Controls) { 
                if (var is Panel) {
                    Panel pnl = var as Panel;
                    SetUpPnl(pnl);
                }
                if (var is Button) {
                    Button btn = var as Button;
                    SetUpBtn(btn);
                }
                if (var is DataGridView)
                {
                    DataGridView dgv = var as DataGridView;
                    dgv.BackgroundColor = Color.Lavender;
                }
            }
        }
        public void SetUpPnl(Panel pnl)
        {
            pnl.BackgroundImage = Properties.Resources.bgrPnl;
            pnl.BackgroundImageLayout = ImageLayout.Stretch;

            foreach (var lbl in pnl.Controls)
                if (lbl is Label)
                    (lbl as Label).BackColor = System.Drawing.Color.Transparent;
            foreach (var btn in pnl.Controls)
                if (btn is Button)
                    SetUpBtn(btn as Button);
        }
        public void SetUpBtn(Button btn)
        {
            btn.BackgroundImage = Properties.Resources.bgrBtn;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn.Cursor = Cursors.Hand;
            //btn.Size = new Size(100,30);

            btn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            btn.MouseLeave += new System.EventHandler(this.MouseLeave);
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrDown;
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrBtn;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrBtn;
        }
        private void MouseMove(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackgroundImage = Properties.Resources.bgrOver;
        }
    }
}
