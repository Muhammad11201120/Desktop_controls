using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmDateAndTime : Form
    {
        public frmDateAndTime()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            MessageBox.Show( dateTimePicker1.Value.ToShortDateString() );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            MessageBox.Show( dateTimePicker1.Value.ToLongDateString() );
        }

        private void dateTimePicker1_ValueChanged( object sender, EventArgs e )
        {
            label1.Text = dateTimePicker1.Text + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString( "dd - MMM - yyyy" ) + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString( "ddd - MM - yyyy" );
        }
    }
}
