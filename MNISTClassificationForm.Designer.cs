namespace HandWrittenRecognitionProject
{
    partial class MNISTClassificationForm
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
            this.classifierComBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.KLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.classifyBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfImagesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // classifierComBox
            // 
            this.classifierComBox.FormattingEnabled = true;
            this.classifierComBox.Location = new System.Drawing.Point(160, 59);
            this.classifierComBox.Name = "classifierComBox";
            this.classifierComBox.Size = new System.Drawing.Size(125, 21);
            this.classifierComBox.TabIndex = 0;
            this.classifierComBox.SelectedIndexChanged += new System.EventHandler(this.classifierComBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 263);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classifier";
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KLabel.Location = new System.Drawing.Point(-2, 86);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(26, 25);
            this.KLabel.TabIndex = 3;
            this.KLabel.Text = "K";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(160, 91);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(125, 20);
            this.kTextBox.TabIndex = 4;
            // 
            // classifyBtn
            // 
            this.classifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classifyBtn.Location = new System.Drawing.Point(180, 422);
            this.classifyBtn.Name = "classifyBtn";
            this.classifyBtn.Size = new System.Drawing.Size(188, 39);
            this.classifyBtn.TabIndex = 5;
            this.classifyBtn.Text = "Classify";
            this.classifyBtn.UseVisualStyleBackColor = true;
            this.classifyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(353, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of Images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // numberOfImagesTextBox
            // 
            this.numberOfImagesTextBox.Location = new System.Drawing.Point(160, 27);
            this.numberOfImagesTextBox.Name = "numberOfImagesTextBox";
            this.numberOfImagesTextBox.Size = new System.Drawing.Size(125, 20);
            this.numberOfImagesTextBox.TabIndex = 11;
            // 
            // MNISTClassificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 473);
            this.Controls.Add(this.numberOfImagesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.classifyBtn);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.KLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.classifierComBox);
            this.Name = "MNISTClassificationForm";
            this.Text = "MNISTClassificationForm";
            this.Load += new System.EventHandler(this.MNISTClassificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox classifierComBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Button classifyBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberOfImagesTextBox;
    }
}