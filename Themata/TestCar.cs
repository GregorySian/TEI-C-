using System;

namespace Themata
{
    partial class Program
    {
        private class TestCar
        {
            public static void Main(string[] args)
            {
                Program.Car c1 = new Program.Car();
                c1.InputData();
                Program.Car c2 = new Program.Car("Volvo", 1800, 165);
                Console.WriteLine(c2);
            }
        }
    }
}