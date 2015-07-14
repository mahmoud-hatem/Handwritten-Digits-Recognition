using MNISTDataReader;
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
    public partial class Mode : Form
    {
        private string imagesPath;
        private string labelsPath;

        public static byte[][] testImagesFeatures;
        public static byte[] testLabels;

        public Mode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.imagesPath = openFileDialog1.FileName;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.labelsPath = openFileDialog1.FileName;
            }

            DigitalImageParser digitalImage = new DigitalImageParser(this.imagesPath, this.labelsPath, 10000);
            digitalImage.Parse();

            Mode.testImagesFeatures = digitalImage.ImagesFeatures;
            Mode.testLabels = digitalImage.Labels;

            MNISTClassificationForm mcf = new MNISTClassificationForm();
            mcf.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrawingForm df = new DrawingForm();

            df.Show();
        }
    }
}
