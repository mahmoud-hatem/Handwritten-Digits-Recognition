using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNISTDataReader
{
    public class DigitalImageParser
    {
        #region Pixels Init.
        private int ROWS = 28;
        private int COLUMNS = 28;
        #endregion

        #region Files
        private FileStream imagesFile;
        private FileStream labelsFiles;
        #endregion

        #region BinaryReaders
        BinaryReader imagesBinaryReader;
        BinaryReader labelsBinaryReader;
        #endregion

        #region
        private byte[, ,] imagesBuffer;
        private byte[][] imagesFeatures;
        private byte[] imagesLabels;
        private int dataSize;
        #endregion

        private List<Bitmap> images;

        public byte[, ,] ImagesBuffer
        {
            get { return this.imagesBuffer; }
        }

        public byte[][] ImagesFeatures
        {
            get { return this.imagesFeatures; }
        }

        public byte[] Labels
        {
            get { return this.imagesLabels; }
        }

        public DigitalImageParser(string imagesPath, string labelsPath, int dataSize)
        {
            this.imagesFile = new FileStream(imagesPath, FileMode.Open);
            this.labelsFiles = new FileStream(labelsPath, FileMode.Open);

            this.imagesBinaryReader = new BinaryReader(imagesFile);
            this.labelsBinaryReader = new BinaryReader(labelsFiles);

            this.dataSize = dataSize;
        }

        public void Parse()
        {
            int imagesMagicNumber = this.imagesBinaryReader.ReadInt32();
            int numberOfImages = this.imagesBinaryReader.ReadInt32();
            int numberOfRows = this.imagesBinaryReader.ReadInt32();
            int numberOfColumns = this.imagesBinaryReader.ReadInt32();

            int labelsMagicNumber = labelsBinaryReader.ReadInt32();
            int numberOfLabels = labelsBinaryReader.ReadInt32(); // Matches the number of image

            this.imagesBuffer = new byte[COLUMNS, ROWS, this.dataSize];
            this.imagesFeatures = new byte[this.dataSize][];
            this.imagesLabels = new byte[this.dataSize];

            this.images = new List<Bitmap>();

            for (int i = 0; i < this.dataSize; i++)
            {
                this.imagesFeatures[i] = new byte[ROWS * COLUMNS];
            }

            for (int i = 0; i < this.dataSize * ROWS * COLUMNS; i++)
            {
                int temp = 255 - (int)this.imagesBinaryReader.ReadByte();

                this.imagesFeatures[(int)i / (ROWS * COLUMNS)][(int)i % (ROWS * COLUMNS)] = Convert.ToByte(temp);
            }

            for (int i = 0; i < this.dataSize; i++)
            {
                this.imagesLabels[i] = this.labelsBinaryReader.ReadByte();
            }

            this.imagesBinaryReader.Close();
            this.labelsBinaryReader.Close();

            this.imagesFile.Close();
            this.labelsFiles.Close();
        }
    }
}
