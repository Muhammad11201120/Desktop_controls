using System;
using System.Windows.Forms;

namespace training_
{
    public partial class Form3 : Form
    {
        short counter = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load( object sender, EventArgs e )
        {

        }

        private void btnAdd_Click( object sender, EventArgs e )
        {

            checkedListBox1.Items.Add( ( counter++ ) + " - " + txtItems.Text );
            txtItems.Clear();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnShow_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < checkedListBox1.CheckedItems.Count; i++ )
            {
                MessageBox.Show( checkedListBox1.CheckedItems[ i ].ToString() );
            }
        }

        private void btnCheckAll_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < checkedListBox1.Items.Count; i++ )
            {
                checkedListBox1.SetItemChecked( i, true );
            }
        }

        private void btnUnCheckAll_Click( object sender, EventArgs e )
        {
            for ( int i = 0; i < checkedListBox1.Items.Count; i++ )
            {
                checkedListBox1.SetItemChecked( i, false );
            }
        }

        private void btnRemove_Click( object sender, EventArgs e )
        {
            try
            {
                checkedListBox1.Items.RemoveAt( checkedListBox1.Items.Count - 1 );
            }
            catch ( Exception )
            {

                MessageBox.Show( "No Items", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }
    }
}
