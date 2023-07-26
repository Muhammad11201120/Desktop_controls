using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmTimer : Form
    {
        int counter = 0;
        public frmTimer()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            timer1.Enabled = true;
        }

        private void button2_Click( object sender, EventArgs e )
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick( object sender, EventArgs e )
        {
            counter++;
            lblTimer.Text = counter.ToString();
            if ( counter == 10 )
            {
                timer1.Enabled = false;
            }
        }
    }
}
