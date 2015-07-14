namespace HandWrittenRecognitionProject
{
    partial class Main
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
            this.existedDatabaseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // existedDatabaseBtn
            // 
            this.existedDatabaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existedDatabaseBtn.Location = new System.Drawing.Point(13, 33);
            this.existedDatabaseBtn.Name = "existedDatabaseBtn";
            this.existedDatabaseBtn.Size = new System.Drawing.Size(259, 51);
            this.existedDatabaseBtn.TabIndex = 0;
            this.existedDatabaseBtn.Text = "Load Training Images";
            this.existedDatabaseBtn.UseVisualStyleBackColor = true;
            this.existedDatabaseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Training Labels";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(94, 192);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.existedDatabaseBtn);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button existedDatabaseBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

