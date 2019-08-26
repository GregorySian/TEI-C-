using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;



namespace Themata2
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public bool Equals(Point P)
        { 
            if (X == P.X && Y == P.Y && Z == P.Z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ((X + Y + Z) / 3);
        }


        public void TextWriter()
        {
            using (StreamWriter writer = File.CreateText("point.txt"))
            {
                writer.WriteLine("X " + X, "Y " + Y + "Z " + Z);
            }
        }

        public static ArrayList<Point> getPoints (string file)
        {
            string file = "point.txt";
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(getPoints(file: "point.txt"));

        }
    }
}
