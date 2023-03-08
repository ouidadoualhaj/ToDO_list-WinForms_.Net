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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //le nombre des taches effectuées
        public int Donetasks= 0;

        private void AddNewTask(string Text, bool Checked)
        {
            TasksList task = new TasksList(Text, Checked);
            task.Top = panel1.Controls.Count * task.Height;
            panel1.Controls.Add(task);
        }

        private void NewTask_Click(object sender, EventArgs e)
        {
            AddNewTask(textBox1.Text, false);
            textBox1.Text = " ";
        }

        public void UpdateDoneTaskCounter(int nmb)
        {
            textBox3.Text = "" + nmb;
        }

        
        private void panel1_Paint(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
