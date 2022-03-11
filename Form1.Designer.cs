namespace image_process
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picorg = new System.Windows.Forms.PictureBox();
            this.picres = new System.Windows.Forms.PictureBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btngrey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picorg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picres)).BeginInit();
            this.SuspendLayout();
            // 
            // picorg
            // 
            this.picorg.Location = new System.Drawing.Point(12, 12);
            this.picorg.Name = "picorg";
            this.picorg.Size = new System.Drawing.Size(333, 241);
            this.picorg.TabIndex = 0;
            this.picorg.TabStop = false;
            // 
            // picres
            // 
            this.picres.Location = new System.Drawing.Point(405, 12);
            this.picres.Name = "picres";
            this.picres.Size = new System.Drawing.Size(383, 241);
            this.picres.TabIndex = 1;
            this.picres.TabStop = false;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(54, 310);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(94, 29);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btngrey
            // 
            this.btngrey.Location = new System.Drawing.Point(269, 310);
            this.btngrey.Name = "btngrey";
            this.btngrey.Size = new System.Drawing.Size(94, 29);
            this.btngrey.TabIndex = 3;
            this.btngrey.Text = "grey";
            this.btngrey.UseVisualStyleBackColor = true;
            this.btngrey.Click += new System.EventHandler(this.btngrey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btngrey);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.picres);
            this.Controls.Add(this.picorg);
            this.Name = "Form1";
            this.Text = "image-process";
            ((System.ComponentModel.ISupportInitialize)(this.picorg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picorg;
        private PictureBox picres;
        private Button btnopen;
        private Button btngrey;
    }
}