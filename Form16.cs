using System;
using System.Windows.Forms;

namespace training_
{
    public partial class frmDialogs : Form
    {
        public frmDialogs()
        {
            InitializeComponent();
        }

        private void btnColor_Click( object sender, EventArgs e )
        {
            if ( colorDialog1.ShowDialog() == DialogResult.OK )
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void btnChangeFont_Click( object sender, EventArgs e )
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;

            fontDialog1.Font = textBox2.Font; // to open the dialog with same textbox font 

            if ( fontDialog1.ShowDialog() == DialogResult.OK )
            {
                textBox2.Font = fontDialog1.Font;
                textBox2.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply( object sender, EventArgs e )
        {
            textBox2.Font = fontDialog1.Font;
            textBox2.ForeColor = fontDialog1.Color;
        }

        private void btnSaveFile_Click( object sender, EventArgs e )
        {
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "SAVE FILE";
            saveFileDialog1.Filter = "text files (*.txt)|(*.txt)|ALL Files (*.*)|(*.*)";
            saveFileDialog1.FilterIndex = 2;
            if ( saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show( saveFileDialog1.FileName );
            }
        }

        private void btnOpenFile_Click( object sender, EventArgs e )
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "OPEN FILE";
            openFileDialog1.Filter = "text files (*.txt)|(*.txt)|ALL Files (*.*)|(*.*)";
            openFileDialog1.FilterIndex = 2;
            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show( openFileDialog1.FileName );
            }
        }

        private void btnExploreFiles_Click( object sender, EventArgs e )
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show( folderBrowserDialog1.SelectedPath );
            }
        }
    }
}
