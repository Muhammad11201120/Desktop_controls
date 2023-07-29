using System.ComponentModel;
using System.Windows.Forms;

namespace training_
{
    public partial class frmErrorProvider : Form
    {
        public frmErrorProvider()
        {
            InitializeComponent();
        }

        private void txtFirstName_Validating( object sender, CancelEventArgs e )
        {
            if ( string.IsNullOrWhiteSpace( txtFirstName.Text ) )
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError( txtFirstName, "First Name Is Required" );
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError( txtFirstName, "" );
            }
        }
    }
}
