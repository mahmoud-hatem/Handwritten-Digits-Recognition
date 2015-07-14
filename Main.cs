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
    public partial class Main : Form
    {
        private string imagesPath;
        private string labelsPath;

        public static byte[][] trainingImagesFeatures;
        public static byte[] trainingLabels;

        public Main()
        {
            InitializeComponent();
            okBtn.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.imagesPath = openFileDialog1.FileName;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DigitalImageParser digitalImage = new DigitalImageParser(this.imagesPath, this.labelsPath, 60000);
            digitalImage.Parse();

            Main.trainingImagesFeatures = digitalImage.ImagesFeatures;
            Main.trainingLabels = digitalImage.Labels;

            Mode mode = new Mode();
            mode.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.labelsPath = openFileDialog1.FileName;
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
