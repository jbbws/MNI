using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNI.Base
{
    public class Experiment
    {
        public enum Type { Undefined,Simple, Minimal, Maximm };
        public enum Level { Top, Bot };
        public Type ExperimentType { get; set; }
        public int FactorCount { get; set; }
        public List<Factor> Factors { get; set; }

        public List<SeriesResult> SeriesSource { get; set; }
        public double[][] Series()
        {
            
            int seriesCount = (int)(Math.Pow(2,FactorCount));
            double[][] series = new double[seriesCount+1][];
            for (int i = 0; i < series.Length; i++)
                series[i] = new double[FactorCount];
            for(int j = 0; j < FactorCount; j++)
            {
                Level lastlevel = Level.Top;
                for(int i = 0; i < seriesCount; i++)
                {
                    int selector = (int)Math.Pow(2, j);
                    if(i % selector == 0)
                    {
                        switch (lastlevel)
                        {
                            case Level.Bot:
                                lastlevel = Level.Top;
                                break;
                            case Level.Top:
                                lastlevel = Level.Bot;
                                break;
                        }
                    }
                    switch(lastlevel)
                    {
                        case Level.Bot:
                            series[i][j] = Factors[j].InitValue - Factors[j].Interval;
                            break;
                        case Level.Top:
                            series[i][j] = Factors[j].InitValue + Factors[j].Interval;
                            break;
                    }
                }
                series[seriesCount][j] = Factors[j].InitValue;
            }
            return series;
        }

        public SeriesResult series;
        //public Experiment()
        //{}
        public double Core(double[] arg, double[] factors)
        {
            double result = 0;
            for(int i = 0; i< factors.Length;i++)
            {
                result += arg[i] * factors[i];
            }
            result += arg.Last();
            return result;
        }

        public List<SeriesResult> CalculateSeries(double[][] series, double[] args)
        {
            List<SeriesResult> result = new List<SeriesResult>();
            for(int i = 0; i < series.Length; i++)
            {
                double value = Core(args, series[i]);
                SeriesResult item = new SeriesResult { Result = value, Arguments = series[i] };
                result.Add(item);
            }
            return result;
        }        
    }
}
