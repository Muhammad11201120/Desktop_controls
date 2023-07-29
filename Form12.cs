using System;
using System.Windows.Forms;

namespace training_
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll( object sender, EventArgs e )
        {
            lblTrackBar.Text = trackBar1.Value.ToString();
        }
    }
}
