using System;
using System.Collections.Generic;
using System.Text;

namespace Thema_2019_Sphere
{
    class Sphere
    {
        private double _x;
        private double _y;
        private double _z;
        private double _r;
        private const double pi = 3.14;


        public double Embadon()
        {
            return 4.0/3.0 * pi * Math.Pow(_r,3);
        }

        public Sphere(double x, double y, double z, double r)
        {
            _x = x;
            _y = y;
            _z = z;
            _r = r;
        }

        public Sphere(double r)
        {
            _r = r;
        }

        public Sphere() : this(0.0, 0.0, 0.0, 1.0)
        {

        }

        public override String ToString()
        {
            return $"({_x},{_y},{_z},{_r}) = {Embadon()}";
        }
    }
}
