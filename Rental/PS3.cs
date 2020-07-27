using System;
using System.Collections.Generic;
using System.Text;

namespace Rental
{
    public class PS3 : Rental1
    {
        public double Biaya { get; set; }
        public override double JUMLAH()
        {
            return JamMain * Biaya;
        }
    }
}
