namespace WF1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btn1 = new System.Windows.Forms.Button();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(51, 394);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 25);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Crear en Lua";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tBox1
            // 
            this.tBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox1.Location = new System.Drawing.Point(24, 25);
            this.tBox1.Multiline = true;
            this.tBox1.Name = "tBox1";
            this.tBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox1.Size = new System.Drawing.Size(354, 363);
            this.tBox1.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(217, 394);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(112, 25);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Limpiar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 431);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# con Lua";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.Button btn2;
    }
}

