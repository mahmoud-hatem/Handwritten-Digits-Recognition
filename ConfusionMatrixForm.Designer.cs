namespace HandWrittenRecognitionProject
{
    partial class ConfusionMatrixForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.overallAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.executionTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overall Accuracy";
            // 
            // overallAccuracyTextBox
            // 
            this.overallAccuracyTextBox.Location = new System.Drawing.Point(207, 14);
            this.overallAccuracyTextBox.Name = "overallAccuracyTextBox";
            this.overallAccuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.overallAccuracyTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // executionTimeTextBox
            // 
            this.executionTimeTextBox.Location = new System.Drawing.Point(208, 39);
            this.executionTimeTextBox.Name = "executionTimeTextBox";
            this.executionTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.executionTimeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Execution Time in Ms";
            // 
            // ConfusionMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 324);
            this.Controls.Add(this.executionTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.overallAccuracyTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConfusionMatrixForm";
            this.Text = "ConfusionMatrixForm";
            this.Load += new System.EventHandler(this.ConfusionMatrixForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox overallAccuracyTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox executionTimeTextBox;
        private System.Windows.Forms.Label label2;
    }
}