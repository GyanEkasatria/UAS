using System;

namespace Rental
{
    public abstract class Rental1
    {
        public string NAMA { get; set; }
        public string JENIS { get; set; }
        public double JamMain { get; set;}
        public abstract double JUMLAH();
    }
}
