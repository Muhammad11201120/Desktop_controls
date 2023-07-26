using System.Windows.Forms;

namespace training_
{
    public partial class linkedLabelForm : Form
    {
        public linkedLabelForm()
        {
            InitializeComponent();
        }

        private void liblGoogle_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            liblGoogle.LinkVisited = true;
            System.Diagnostics.Process.Start( "www.google.com" );
        }

        private void button1_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }
    }
}
