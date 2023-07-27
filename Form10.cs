using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnAdd_Click( object sender, EventArgs e )
        {
            if ( string.IsNullOrEmpty( txtId.Text ) || string.IsNullOrEmpty( txtName.Text ) )
            {
                return;
            }
            ListViewItem item = new ListViewItem( txtId.Text.Trim() );
            if ( rbMale.Checked )
            {
                item.ImageIndex = 0;
            }
            if ( rbGirl.Checked )
            {
                item.ImageIndex = 1;
            }
            item.SubItems.Add( txtName.Text.Trim() );
            listView1.Items.Add( item );
            txtId.Clear();
            txtName.Clear();
            txtId.Focus();
        }

        private void btnRemove_Click( object sender, EventArgs e )
        {
            if ( listView1.Items.Count > 0 )
            {
                listView1.Items.Remove( listView1.SelectedItems[ 0 ] );
            }
        }
    }
}
