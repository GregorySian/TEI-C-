using System;

namespace Themata
{
    partial class Program
    {
        private class TestCar
        {
            public static void Main(string[] args)
            {
                Car c1 = new Car();
                c1.InputData();
                Car c2 = new Car("Volvo", 1800, 165);
                Console.WriteLine(c2);
            }
        }
    }
}
