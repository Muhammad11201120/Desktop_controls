using System;
using System.Drawing;
using System.Windows.Forms;

namespace training_
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Info";
            notifyIcon1.BalloonTipText = "Here Is Some Notifications";
            notifyIcon1.ShowBalloonTip( 2000 );
        }
        private void notifyIcon1_BalloonTipClicked( object sender, EventArgs e )
        {
            MessageBox.Show( "notify clicked" );
        }
    }
}
