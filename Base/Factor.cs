using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNI.Base
{
    public class Factor
    {
        public double TopLimit { get; set; }
        public double BotLimit { get; set; }
        public double InitValue { get; set; }
        public double CurrentValue { get; set; }
        public double Interval { get; set; }
        public void setFactor(double bot, double top, double value, double interval )
        {
            TopLimit = top;
            BotLimit = bot;
            CurrentValue = value;
            Interval = interval;
        }
        public Factor(double bot, double top, double value, double interval)
        {
            TopLimit = top;
            BotLimit = bot;
            CurrentValue = value;
            InitValue = value;
            Interval = interval;
        }
    }

}
