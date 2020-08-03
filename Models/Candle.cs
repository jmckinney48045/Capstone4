using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone4.Models
{
    public class Candle
    {
        public int CandleID { get; set; }
        public string Scent { get; set; }

        public string CandleType { get; set; }
        public double CandlePrice { get; set; }

        public List<Candle> Candles { get; set; }
    }
}
