using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandWrittenRecognitionProject.Classifiers
{
    public class KNearestNeighbour
    {
        private int numberOfClasses;
        private byte[][] trainingImagesFeatures; // First Dimention -> index of image, Coprespond-> Feature of the image
        private byte[] trainingLabels; // Data of training images

        private List<double> nearestNeighboursDistances; 
        private List<int> nearestNeighboursClasses;

        private int[,] confusionMatrix;

        public KNearestNeighbour(int numberOfClasses, byte[][] trainingImagesFeatures, byte[] trainingLabels)
        {
            this.numberOfClasses = numberOfClasses;
            this.trainingImagesFeatures = trainingImagesFeatures;
            this.trainingLabels = trainingLabels;

            this.confusionMatrix = new int[numberOfClasses, numberOfClasses];
        }

        public int classify(int K, byte[] testImageFeatures)
        {
            // K -> ha5od ad eh mn el items
            int[] classFrequency = new int[this.numberOfClasses];
            int classIndex = 0;
            int maximumOccure = 0;

            this.nearestNeighboursClasses = new List<int>();
            this.nearestNeighboursDistances = new List<double>();
            List<KeyValuePair<double, int>> neighbours = new List<KeyValuePair<double, int>>();

            #region find KNN

            for (int index = 0; index < trainingImagesFeatures.Count(); index++)
            {
                double distance = Utilities.Euclidean(testImageFeatures, trainingImagesFeatures[index]);

                neighbours.Add(new KeyValuePair<double, int>(distance, trainingLabels[index]));
            }

            //sorting 3ala l Key
            neighbours = neighbours.OrderBy(x => x.Key).ToList();

            // el k neieghbours elly hashta3'al 3alehom
            for (int i = 0; i < K; i++)
            {
                this.nearestNeighboursDistances.Add(neighbours[i].Key);
                this.nearestNeighboursClasses.Add(neighbours[i].Value);
            }

            #endregion
            // 1 3 4 1 3
            int idx = 0;

            #region Class set
            for (int i = 0; i < nearestNeighboursClasses.Count; i++)
            {
                classFrequency[nearestNeighboursClasses[i]]++;

                if (++idx == K) 
                    break;
            }

            for (int i = 0; i < this.numberOfClasses; i++)
            {
                if (classFrequency[i] > maximumOccure)
                {
                    classIndex = i;
                    maximumOccure = classFrequency[i];
                }
            }

            return classIndex;

            #endregion

        }

        public int classifyModified(byte[] testImageFeatures)
        {
            #region Pre-processing to calculate the classes means

            double[][] classesMeans;
            int[] classesFrequency;

            List<double> distances = new List<double>();
            double minimumDistance = 0.0;

            int predictedClass = 0;

            classesMeans = new double[this.numberOfClasses][];

            for (int i = 0; i < this.numberOfClasses; i++)
            {
                classesMeans[i] = new double[28 * 28];
            }

            classesFrequency = new int[this.numberOfClasses];

            for (int i = 0; i < this.trainingLabels.Count(); i++)
            {
                classesFrequency[this.trainingLabels[i]]++;

                for (int j = 0; j < this.trainingImagesFeatures[i].Count(); j++)
                {
                    classesMeans[this.trainingLabels[i]][j] += this.trainingImagesFeatures[i][j];
                }
            }

            for (int i = 0; i < this.numberOfClasses; i++)
            {
                for (int j = 0; j < 28 * 28; j++)
                {
                    classesMeans[i][j] = classesMeans[i][j] / classesFrequency[i];
                }
            }

            #endregion

            for (int i = 0; i < classesMeans.Length; i++)
            {
                distances.Add(Utilities.EuclideanDouble(classesMeans[i], testImageFeatures));

                if (i == 0)
                {
                    minimumDistance = distances[i];
                    predictedClass = i;
                }

                else
                {
                    if (distances[i] < minimumDistance)
                    {
                        minimumDistance = distances[i];
                        predictedClass = i;
                    }
                }
            }

            return predictedClass;
        }
    }
}
