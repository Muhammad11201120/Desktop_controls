namespace training_
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnlinkedLabrl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnnotify = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTrrView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlinkedLabrl
            // 
            this.btnlinkedLabrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkedLabrl.Location = new System.Drawing.Point(12, 54);
            this.btnlinkedLabrl.Name = "btnlinkedLabrl";
            this.btnlinkedLabrl.Size = new System.Drawing.Size(300, 78);
            this.btnlinkedLabrl.TabIndex = 1;
            this.btnlinkedLabrl.Text = "Link Label";
            this.btnlinkedLabrl.UseVisualStyleBackColor = true;
            this.btnlinkedLabrl.Click += new System.EventHandler(this.btnlinkedLabrl_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Checked List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 78);
            this.button3.TabIndex = 3;
            this.button3.Text = "Date And Time";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 78);
            this.button4.TabIndex = 4;
            this.button4.Text = "Month Calender ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnnotify
            // 
            this.btnnotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotify.Location = new System.Drawing.Point(501, 54);
            this.btnnotify.Name = "btnnotify";
            this.btnnotify.Size = new System.Drawing.Size(300, 78);
            this.btnnotify.TabIndex = 5;
            this.btnnotify.Text = "NotifyIcon";
            this.btnnotify.UseVisualStyleBackColor = true;
            this.btnnotify.Click += new System.EventHandler(this.btnnotify_Click);
            // 
            // btnTrrView
            // 
            this.btnTrrView.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrrView.Location = new System.Drawing.Point(501, 191);
            this.btnTrrView.Name = "btnTrrView";
            this.btnTrrView.Size = new System.Drawing.Size(300, 78);
            this.btnTrrView.TabIndex = 6;
            this.btnTrrView.Text = "Tree View";
            this.btnTrrView.UseVisualStyleBackColor = true;
            this.btnTrrView.Click += new System.EventHandler(this.btnTrrView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 750);
            this.Controls.Add(this.btnTrrView);
            this.Controls.Add(this.btnnotify);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnlinkedLabrl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlinkedLabrl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnnotify;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTrrView;
    }
}

