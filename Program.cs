using System;

namespace themaC_2019
{
    class Program
    {
        static void Main(string[] args)
        {
          var t1 = new Time(10,15,23);
          var t2 = new Time(01,03,05);
          var t = new Time(00,00,00);


          int tW = t1.wres + t2.wres;
          int tL = t1.lepta + t2.lepta;
          int tD = t1.deytera + t2.deytera;

          t.wres = tW;
          t.lepta = tL;
          t.deytera = tD;
          Console.WriteLine("t is : "  + t);

          int tW2 = t1.wres - t2.wres;
          int tL2 = t1.lepta - t2.lepta;
          int tD2 = t1.deytera - t2.deytera;

          t.wres = tW2;
          t.lepta = tL2;
          t.deytera = tD2;

          Console.WriteLine("t1 is : " + t1);
          Console.WriteLine("t2 is : " + t2);
          Console.WriteLine("t is : " + t);


        }
    }
}
