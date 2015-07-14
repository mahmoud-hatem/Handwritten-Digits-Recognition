using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandWrittenRecognitionProject
{
    public partial class ConfusionMatrixForm : Form
    {
        public ConfusionMatrixForm()
        {
            InitializeComponent();

            this.initializeGrid();
        }

        private void ConfusionMatrixForm_Load(object sender, EventArgs e)
        {

        }

        private void initializeGrid()
        {
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            this.dataGridView1.ColumnCount = 10;
            this.dataGridView1.RowCount = 10;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                this.dataGridView1.Columns[i].Name = "Class " + i.ToString();
                this.dataGridView1.Rows[i].HeaderCell.Value = "Class " + i.ToString();
            }
        }

        public void setConfusionMatrix(int[,] matrix, string executionTime)
        {
            this.executionTimeTextBox.Text = executionTime;

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int total = 0;
            int overallAccuracy = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i == j)
                    {
                        overallAccuracy += matrix[i, j];
                    }

                    total += matrix[i, j];
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            try
            {
                this.overallAccuracyTextBox.Text = (((float)overallAccuracy / total) * 100.0).ToString().Substring(0, 5) + " %";
            }

            catch
            {
                this.overallAccuracyTextBox.Text = (((float)overallAccuracy / total) * 100.0).ToString() + "%";
            }
        }
    }
}
