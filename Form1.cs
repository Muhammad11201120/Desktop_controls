using System;
using System.Windows.Forms;

namespace training_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlinkedLabrl_Click(object sender, EventArgs e)
        {
            linkedLabelForm form = new linkedLabelForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDateAndTime form = new frmDateAndTime();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMonthCalender form = new frmMonthCalender();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTimer form = new frmTimer();
            form.ShowDialog(); ;
        }

        private void btnnotify_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void btnTrrView_Click(object sender, EventArgs e)
        {
            frmTreeView form = new frmTreeView();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.ShowDialog();
        }
    }
}
