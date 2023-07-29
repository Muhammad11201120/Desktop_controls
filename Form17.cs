using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }

        private void btnNewForm_Click( object sender, EventArgs e )
        {
            frmListView form = new frmListView();
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void cmsChangeColor_Click( object sender, EventArgs e )
        {
            colorDialog1.AllowFullOpen = true;
            if ( colorDialog1.ShowDialog() == DialogResult.OK )
            {
                btnNewForm.BackColor = colorDialog1.Color;
            }

        }

        private void cmsChangeFont_Click( object sender, EventArgs e )
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;

            fontDialog1.Font = btnNewForm.Font; // to open the dialog with same textbox font 

            if ( fontDialog1.ShowDialog() == DialogResult.OK )
            {
                btnNewForm.Font = fontDialog1.Font;
            }

        }
    }
}
