using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


namespace ThemaA2_2019
{
    class Program
    {

        static void Main(string[] args)
        {
            var near = new Nearest();
            double[] ar = { -14.5, - 5.4,1.5,18.2,22.7,29.2};
            Console.WriteLine(near.Prakseis(ar));
        }
    }
}
    

