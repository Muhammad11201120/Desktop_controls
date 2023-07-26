using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmMonthCalender : Form
    {
        public frmMonthCalender()
        {
            InitializeComponent();
        }

        private void btnSelectedRange_Click( object sender, EventArgs e )
        {
            MessageBox.Show( monthCalendar1.SelectionRange.ToString() );
        }

        private void btnStart_Click( object sender, EventArgs e )
        {
            MessageBox.Show( monthCalendar1.SelectionRange.Start.ToString() );
        }

        private void btnEnd_Click( object sender, EventArgs e )
        {
            MessageBox.Show( monthCalendar1.SelectionRange.End.ToString() );
        }
    }
}
