using System;

namespace themaC_2019
{
    class Time
    {
        public int wres;
        public int lepta;
        public int deytera;

        public Time()
        {
            wres = 0;
            lepta = 0;
            deytera = 0;
        }

        public Time(int Wres, int Lepta, int Deytera)
        {
            wres = Wres;
            lepta = Lepta;
            deytera = Deytera;
        }


        public override String ToString()
        {
            return $"{wres}:{lepta}:{deytera}";
        }

        
    }
}
