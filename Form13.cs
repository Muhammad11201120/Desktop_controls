using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmNumeric : Form
    {
        public frmNumeric()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged( object sender, EventArgs e )
        {
            lblNumeric.Text = numericUpDown1.Value.ToString();
        }
    }
}
