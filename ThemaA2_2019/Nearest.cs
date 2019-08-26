using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThemaA2_2019
{
     class Nearest
     {
         public Double Sum=0, Avg;
         double[] array = { -14.5, -5.4, 1.5, 18.2, 22.7, 29.2 };
        public double Prakseis(double[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Sum += array[i];
                Avg = Sum / array.Length;
            }

            double nearest = array.OrderBy(i => Math.Abs((double) i - Avg)).First();
            return nearest;
        }

    }
}
