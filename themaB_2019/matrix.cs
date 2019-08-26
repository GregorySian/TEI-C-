using System;

namespace themaB_2019
{
    public class matrix
    {
        double[,] array = new Double[,]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        public void LoopDiag()
        {
            double sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i + 1 == j)
                    {
                        sum += array[i, j];
                        Console.WriteLine("sum is : " + sum);

                    }
                }
            }
        }
    }
}
