using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace training_
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i <= 10; i++ )
            {
                if ( progressBar1.Value < progressBar1.Maximum )
                {
                    Thread.Sleep( 500 );
                    progressBar1.Value += 10;
                    label1.Text = ( ( ( float ) progressBar1.Value / progressBar1.Maximum ) * 100 ) + "%";
                    progressBar1.Refresh();
                    label1.Refresh();
                }
                else
                {
                    progressBar1.Enabled = false;
                }
            }

        }

        private void Form9_Load( object sender, EventArgs e )
        {

        }

        private void button2_Click( object sender, EventArgs e )
        {
            progressBar1.Value = 0;
            label1.Text = "0 %";
        }
    }
}
