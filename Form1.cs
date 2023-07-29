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

        private void btnlinkedLabrl_Click( object sender, EventArgs e )
        {
            linkedLabelForm form = new linkedLabelForm();
            form.ShowDialog();
        }

        private void button2_Click( object sender, EventArgs e )
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button3_Click( object sender, EventArgs e )
        {
            frmDateAndTime form = new frmDateAndTime();
            form.ShowDialog();
        }

        private void button4_Click( object sender, EventArgs e )
        {
            frmMonthCalender form = new frmMonthCalender();
            form.ShowDialog();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            frmTimer form = new frmTimer();
            form.ShowDialog(); ;
        }

        private void btnnotify_Click( object sender, EventArgs e )
        {
            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void btnTrrView_Click( object sender, EventArgs e )
        {
            frmTreeView form = new frmTreeView();
            form.ShowDialog();
        }

        private void button5_Click( object sender, EventArgs e )
        {
            Form9 form = new Form9();
            form.ShowDialog();
        }

        private void button6_Click( object sender, EventArgs e )
        {
            frmListView form = new frmListView();
            form.ShowDialog();
        }

        private void btnErrorProvider_Click( object sender, EventArgs e )
        {
            frmErrorProvider form = new frmErrorProvider();
            form.ShowDialog();
        }

        private void Form1_Load( object sender, EventArgs e )
        {

        }

        private void btnTrckBar_Click( object sender, EventArgs e )
        {
            Form12 form = new Form12();
            form.ShowDialog();
        }

        private void btnNumeric_Click( object sender, EventArgs e )
        {
            frmNumeric form = new frmNumeric();
            form.ShowDialog();
        }

        private void btnTapVontrol_Click( object sender, EventArgs e )
        {
            frmTapControl form = new frmTapControl();
            form.ShowDialog();
        }

        private void btnPanel_Click( object sender, EventArgs e )
        {
            frmPanel form = new frmPanel();
            form.ShowDialog();
        }

        private void btnDialogs_Click( object sender, EventArgs e )
        {
            frmDialogs form = new frmDialogs();
            form.ShowDialog();
        }

        private void btnMdi_Click( object sender, EventArgs e )
        {
            frmMdi form = new frmMdi();
            form.ShowDialog();
        }
    }
}
