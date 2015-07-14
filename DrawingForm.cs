using HandWrittenRecognitionProject.Classifiers;
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
    public partial class DrawingForm : Form
    {
        bool isMouseDown;
       // Bitmap resizedImage;

        public DrawingForm()
        {
            InitializeComponent();

            Dictionary<string, string> list = new Dictionary<string, string>();
            list.Add("KNN", "KNN");
            list.Add("Bayes", "Bayes");
            list.Add("Logistic Regression", "Logistic Regression");
            list.Add("SVM", "SVM");
            list.Add("Neural Network", "Neural Network");

            this.classifierComboBox.DataSource = new BindingSource(list, null);
            this.classifierComboBox.DisplayMember = "Key";
            this.classifierComboBox.ValueMember = "Value";

            this.kTextBox.Visible = true;
            this.KLabel.Visible = true;

            this.isMouseDown = false;
            this.pictureBox1.Image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
        }

        public int K
        {
            get { return Convert.ToInt32(kTextBox.Text); }
        }

        public string ClassifierType
        {
            get { return ((KeyValuePair<string, string>)this.classifierComboBox.SelectedItem).Value; }
            set { this.classifierComboBox.Text = value.ToString(); }
        }

        public Bitmap Image
        {
            get { return (Bitmap)this.pictureBox1.Image; }
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {

        }

        private void classifyBtn_Click(object sender, EventArgs e)
        {
            Bitmap currentImage = new Bitmap(pictureBox1.Image);

            if (ClassifierType == "KNN")
            {
                KNearestNeighbour knnClassifier = new KNearestNeighbour(10, Main.trainingImagesFeatures, Main.trainingLabels);

                pictureBox2.Image = pictureBox1.Image;
                Bitmap drawnImage = new Bitmap(scaledImage((Bitmap)pictureBox1.Image));
                pictureBox2.Image = drawnImage;
                //byte[] imageFeatures = bitmapToBuffer(drawnImage);

//                int classIndex = knnClassifier.classifySorting(K, imageFeatures);

  //              MessageBox.Show(classIndex.ToString());

            }
        }

        private void classifierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.classifierComboBox.Text != "KNN")
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point point = this.pictureBox1.PointToClient(Cursor.Position);
                DrawPoint(point.X, point.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
                isMouseDown = false;
        }

        private void DrawPoint(float x, float y)
        {
            Bitmap b = new Bitmap(this.pictureBox1.Image);
            Graphics g = Graphics.FromImage(b);

            g.FillEllipse(Brushes.Black, x, y, 30, 30);

            pictureBox1.Image = b;
        }

        public Bitmap scaledImage(Bitmap original)
        {
            int ratioX = 140 / 28;
            int ratioY = 140 / 28;

            Bitmap resizedImage = new Bitmap(140 / ratioX, 140 / ratioY);

            Graphics.FromImage(resizedImage).DrawImage(original, 10, 10, 140 / ratioX, 140 / ratioY);

            return resizedImage;
        }

        private byte[] bitmapToBuffer(Bitmap digit)
        {
            byte[] imageFeatures = new byte[28 * 28];

            int index = 0;

            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    byte temp = digit.GetPixel(i, j).R;
                    imageFeatures[index] = temp;

                    index++;
                }
            }

            return imageFeatures;
        }
    }
}
