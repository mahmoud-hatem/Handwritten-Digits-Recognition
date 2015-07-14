using HandWrittenRecognitionProject.Classifiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandWrittenRecognitionProject
{
    public partial class MNISTClassificationForm : Form
    {
        private int[,] confusionMatrix;

        public MNISTClassificationForm()
        {
            InitializeComponent();

            Dictionary<string, string> list = new Dictionary<string, string>();
            list.Add("KNN", "KNN");
            list.Add("KNN Modified", "KNN Modified");
            list.Add("Bayes", "Bayes");
            list.Add("Logistic Regression", "Logistic Regression");
            list.Add("SVM", "SVM");
            list.Add("Neural Network", "Neural Network");

            this.classifierComBox.DataSource = new BindingSource(list, null);
            this.classifierComBox.DisplayMember = "Key";
            this.classifierComBox.ValueMember = "Value";

            this.kTextBox.Visible = true;
            this.KLabel.Visible = true;

            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            this.setColumns();
            
        }

        public int K
        {
            get { return Convert.ToInt32(kTextBox.Text); }
        }

        public string ClassifierType
        {
            get { return ((KeyValuePair<string, string>)this.classifierComBox.SelectedItem).Value; }
            set { this.classifierComBox.Text = value.ToString(); }
        }

        public int NumberOfImages
        {
            get { return Convert.ToInt32(numberOfImagesTextBox.Text); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int index = 0;
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Output.txt");
            StreamWriter file = new StreamWriter(@path);

            KNearestNeighbour knnClassifier = new KNearestNeighbour(10, Main.trainingImagesFeatures, Main.trainingLabels);

            this.confusionMatrix = new int[10, 10];

            var watch = Stopwatch.StartNew();

            if (ClassifierType == "KNN")
            {
                while (index != NumberOfImages)
                {
                    int classIndex = knnClassifier.classify(K, Mode.testImagesFeatures[index]);

                    this.confusionMatrix[Mode.testLabels[index], classIndex]++;

                    string[] output = { index.ToString(), Mode.testLabels[index].ToString(), classIndex.ToString() };

                    this.dataGridView1.Rows.Add(output);

                    string outputFile = "Image# " + index.ToString() + "\t Predection: "
                        + classIndex.ToString() + "\t Label: " + Mode.testLabels[index] + "\n";

                    file.WriteLine(outputFile);

                    index++;
                }

                watch.Stop();
                file.WriteLine(watch.ElapsedMilliseconds.ToString());

                Process proc = Process.GetCurrentProcess();

                file.WriteLine((proc.PrivateMemorySize64 / 1024).ToString());
            }

            else if (ClassifierType == "KNN Modified")
            {  
                while (index != NumberOfImages)
                {
                    int classIndex = knnClassifier.classifyModified(Mode.testImagesFeatures[index]);

                    this.confusionMatrix[Mode.testLabels[index], classIndex]++;

                    string[] output = { index.ToString(), Mode.testLabels[index].ToString(), classIndex.ToString() };

                    this.dataGridView1.Rows.Add(output);

                    string outputFile = "Image# " + index.ToString() + "\t Predection: "
                        + classIndex.ToString() + "\t Label: " + Mode.testLabels[index] + "\n";

                    file.WriteLine(outputFile);

                    index++;
                }

                watch.Stop();
                file.WriteLine(watch.ElapsedMilliseconds.ToString());

                Process proc = Process.GetCurrentProcess();
             
                file.WriteLine((proc.PrivateMemorySize64 / 1024).ToString());
            }

            file.Close();

            ConfusionMatrixForm cmf = new ConfusionMatrixForm();
            cmf.Show();

            cmf.setConfusionMatrix(this.confusionMatrix, watch.ElapsedMilliseconds.ToString());
        }

        private void MNISTClassificationForm_Load(object sender, EventArgs e)
        {

        }

        private void classifierComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.classifierComBox.Text != "KNN")
            {
                this.KLabel.Visible = false;
                this.kTextBox.Visible = false;
            }

            else
            {
                this.KLabel.Visible = true;
                this.kTextBox.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setColumns()
        {
            this.dataGridView1.ColumnCount = 3;

            this.dataGridView1.Columns[0].Name = "Image #";
            this.dataGridView1.Columns[1].Name = "Label";
            this.dataGridView1.Columns[2].Name = "Prediction";
        }


    }
}
