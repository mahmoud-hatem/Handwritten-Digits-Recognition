using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandWrittenRecognitionProject
{
    public static class Utilities
    {
        public static double Euclidean(byte[] currentImageFeatures, byte[] trainingImageFeatures)
        {
            int length = currentImageFeatures.Count();
            double result = 0.0;

            for (int i = 0; i < currentImageFeatures.Count(); i++)
            {
                result += (currentImageFeatures[i] - trainingImageFeatures[i]) *
                    (currentImageFeatures[i] - trainingImageFeatures[i]);
            }

            return Math.Sqrt(result);
        }

        public static double EuclideanDouble(double[] currentImageFeatures, byte[] trainingImageFeatures)
        {
            int length = currentImageFeatures.Count();
            double result = 0.0;

            for (int i = 0; i < currentImageFeatures.Count(); i++)
            {
                result += (currentImageFeatures[i] - trainingImageFeatures[i]) *
                    (currentImageFeatures[i] - trainingImageFeatures[i]);
            }

            return Math.Sqrt(result);
        }
    }
}
