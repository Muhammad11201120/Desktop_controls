namespace training_
{
    partial class frmTreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmTreeView ) );
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Father" );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "Mother" );
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode( "Grand Father", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2} );
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode( "Node5" );
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode( "Node6" );
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode( "Unkil", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5} );
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode( "Grand Mother", new System.Windows.Forms.TreeNode[] {
            treeNode6} );
            this.imageList1 = new System.Windows.Forms.ImageList( this.components );
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ( ( System.Windows.Forms.ImageListStreamer ) ( resources.GetObject( "imageList1.ImageStream" ) ) );
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName( 0, "Boy.png" );
            this.imageList1.Images.SetKeyName( 1, "Girl.png" );
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point( 234, 65 );
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Father";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node3";
            treeNode2.Text = "Mother";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Node0";
            treeNode3.Text = "Grand Father";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Node5";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Node6";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Unkil";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Node1";
            treeNode7.Text = "Grand Mother";
            this.treeView1.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7} );
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size( 317, 228 );
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler( this.treeView1_AfterCheck );
            // 
            // frmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 800, 450 );
            this.Controls.Add( this.treeView1 );
            this.Name = "frmTreeView";
            this.Text = "Form8";
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}