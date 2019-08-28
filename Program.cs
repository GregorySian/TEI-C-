using System;

namespace Thema_2019_Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere s1 = new Sphere(5.0,6.0,7.0,3.0);
            Sphere s2 = new Sphere(5);
            Sphere s3 = new Sphere();

            Console.WriteLine(s1 + "\n" + s2 + "\n" + s3 + "\n" );

        }
    }
}
