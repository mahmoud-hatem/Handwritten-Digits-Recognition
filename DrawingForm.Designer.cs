namespace HandWrittenRecognitionProject
{
    partial class DrawingForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classifyBtn = new System.Windows.Forms.Button();
            this.classifierLabel = new System.Windows.Forms.Label();
            this.KLabel = new System.Windows.Forms.Label();
            this.classifierComboBox = new System.Windows.Forms.ComboBox();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // classifyBtn
            // 
            this.classifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifyBtn.Location = new System.Drawing.Point(86, 243);
            this.classifyBtn.Name = "classifyBtn";
            this.classifyBtn.Size = new System.Drawing.Size(140, 33);
            this.classifyBtn.TabIndex = 1;
            this.classifyBtn.Text = "Classify";
            this.classifyBtn.UseVisualStyleBackColor = true;
            this.classifyBtn.Click += new System.EventHandler(this.classifyBtn_Click);
            // 
            // classifierLabel
            // 
            this.classifierLabel.AutoSize = true;
            this.classifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifierLabel.Location = new System.Drawing.Point(31, 176);
            this.classifierLabel.Name = "classifierLabel";
            this.classifierLabel.Size = new System.Drawing.Size(65, 17);
            this.classifierLabel.TabIndex = 2;
            this.classifierLabel.Text = "Classifier";
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(31, 206);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(14, 13);
            this.KLabel.TabIndex = 3;
            this.KLabel.Text = "K";
            // 
            // classifierComboBox
            // 
            this.classifierComboBox.FormattingEnabled = true;
            this.classifierComboBox.Location = new System.Drawing.Point(105, 176);
            this.classifierComboBox.Name = "classifierComboBox";
            this.classifierComboBox.Size = new System.Drawing.Size(121, 21);
            this.classifierComboBox.TabIndex = 4;
            this.classifierComboBox.SelectedIndexChanged += new System.EventHandler(this.classifierComboBox_SelectedIndexChanged);
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(105, 203);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(121, 20);
            this.kTextBox.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(268, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 102);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 288);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.classifierComboBox);
            this.Controls.Add(this.KLabel);
            this.Controls.Add(this.classifierLabel);
            this.Controls.Add(this.classifyBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrawingForm";
            this.Text = "DrawingForm";
            this.Load += new System.EventHandler(this.DrawingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button classifyBtn;
        private System.Windows.Forms.Label classifierLabel;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.ComboBox classifierComboBox;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}