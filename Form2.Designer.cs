namespace training_
{
    partial class linkedLabelForm
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
            this.liblGoogle = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liblGoogle
            // 
            this.liblGoogle.AutoSize = true;
            this.liblGoogle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liblGoogle.Location = new System.Drawing.Point(88, 61);
            this.liblGoogle.Name = "liblGoogle";
            this.liblGoogle.Size = new System.Drawing.Size(131, 27);
            this.liblGoogle.TabIndex = 0;
            this.liblGoogle.TabStop = true;
            this.liblGoogle.Text = "Google.com";
            this.liblGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liblGoogle_LinkClicked);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(438, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkedLabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liblGoogle);
            this.Name = "linkedLabelForm";
            this.Text = "Linked Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel liblGoogle;
        private System.Windows.Forms.Button button1;
    }
}