using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do
{
    public partial class TasksList : UserControl
    {
        
        public TasksList(string Text, bool Checked)
        {
            InitializeComponent();
            task.Text = Text;
            checkBox1.Checked = Checked;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Panel pnl = this.Parent as Panel;
            Form1 form = pnl.Parent as Form1;

            pnl.Controls.Remove(this);
            this.Dispose();
            reorderListrView(pnl);

            form.Donetasks = form.Donetasks - 1;
            form.UpdateDoneTaskCounter(form.Donetasks);
        }

        private void reorderListrView(Panel pnl)
        {
            int index = 0;
            foreach (Control c in pnl.Controls)
            {
                c.Top = index * c.Height;
                index++;
            }
        }

        private void TasksList_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                task.Font = new Font(task.Font.Name, task.Font.SizeInPoints, FontStyle.Strikeout);
                Panel pnl = this.Parent as Panel;
                // Get the parent form
                Form1 form = pnl.Parent as Form1;
                // increment the done task counter
                form.Donetasks = form.Donetasks + 1;
                form.UpdateDoneTaskCounter(form.Donetasks);
            }
            else
            {
                task.Font = new Font(task.Font.Name, task.Font.SizeInPoints, FontStyle.Regular);
            }
        }


        private void task_Click(object sender, EventArgs e)
        {

        }
    }
}
