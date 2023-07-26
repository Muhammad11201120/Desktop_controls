using System.Windows.Forms;

namespace training_
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }
        private void treeView1_AfterCheck( object sender, TreeViewEventArgs e )
        {
            checkTreeViewNode( e.Node, e.Node.Checked );
        }
        private void checkTreeViewNode( TreeNode node, bool isChecked )
        {
            foreach ( TreeNode item in node.Nodes )
            {
                item.Checked = isChecked;
                if ( item.Nodes.Count > 0 )
                {
                    this.checkTreeViewNode( item, isChecked );
                }
            }
        }
    }
}
