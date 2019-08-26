using System;

namespace Themata4
{
    class OrthParal
    {
        private double _ipsos;
        private double _platos;

        public OrthParal()
        {
          
        }

        public OrthParal(double ipsos, double platos)
        {
            _ipsos = ipsos;
            _platos = platos;
        }

        public void SetPlatos(double platos)
        {
            _platos = platos;
        }

        public void SetIpsos(double ipsos)
        {
            _ipsos = ipsos;
        }

        public bool Equals(OrthParal op)
        {
            if (op._platos == _platos && op._ipsos == _ipsos)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Area()
        {
            return _platos * _ipsos;
        }

        static void Main(string[] args)
        {
            OrthParal par1 = new OrthParal();
            par1.SetIpsos(5.0);
            par1.SetPlatos(3.0);
            Console.WriteLine(par1.Area());
            OrthParal par2 = new OrthParal(5.0, 3.0);
            Console.WriteLine(par2.Area());
            Console.WriteLine(par1.Equals(par2));
        }
    }
}
