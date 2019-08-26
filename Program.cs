using System;
using System.Security.Cryptography.X509Certificates;

namespace Thema_Simeio
{
    class Simeio
    {
        public int _x;
        public int _y;

        public Simeio()
        {

        }
        public Simeio(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"x = {_x} y = {_y}" ;
        }
    }

    class Kyklos : Simeio
    {
        private double r;
        private static double pi = 3.14;


        public Kyklos(int x, int y, double radius): base(x,y)
        {
            r = radius;
        }
        public double Parameter()
        {
            return 2 * pi * r;

        }
        public override string ToString()
        {
            return $"x = {_x} y = {_y} Parameter = {Parameter()}" ;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Simeio s1 = new Simeio(150,200);
            Kyklos k1 = new Kyklos(50,100,14.2);
            Console.WriteLine(s1);
            Console.WriteLine(k1);
        }
    }
}
