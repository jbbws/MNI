using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNI
{
    public class StaticAnalyse
    {
        Aproximation Aproximation { get; set; }
        public double RestQuadSumm { get { return CalcResqtQuadSumm(); } }
        public int AproximationLevel { get { return CalcAproximationLevle(); } }
        public double FisherKoef { get { return Fisher(); } }
        public double AdequacyDispersion { get { return RestQuadSumm / AproximationLevel; } }
        public double[][] ExperimentData { get; set; }
        public readonly double Epsilon = 0.000000001;
        public StaticAnalyse(double[][] values,Aproximation a)
        {
            ExperimentData = values;
            Aproximation = a;
        }
        private int CalcAproximationLevle()
        {
            return ExperimentData.Count() - (Aproximation.Factors + 1);
        }
        private double CalcResqtQuadSumm()
        {
            double[] aproxValues = new double[ExperimentData.Count()];
            for(int i = 0 ; i < aproxValues.Length; i++)
            {
                aproxValues[i] = Aproximation.TestAnsw(ExperimentData[i]);
            }
            double res = 0;
            for(int i = 0; i < aproxValues.Length; i++)
            {
                res += Math.Pow(aproxValues[i] - ExperimentData[i][Aproximation.Factors], 2);
            }
            return res;
        }
        public double GetDeterminationKoef()
        {
            return 1 - (AdequacyDispersion/Epsilon);
        }
        public double Fisher()
        {
            return AdequacyDispersion / Epsilon;
        }
         double AdekvatDispersion(double[] expRes, double[] mathRes)
        {
            double summ = 0;
            for(int i =0;i <expRes.Length;i++)
            {
                summ += Math.Pow((expRes[i] - mathRes[i]), 2);
            }
            return summ / AproximationLevel;
        }
        double getAverage(double[] arr)
        {
            double avg = 0;
            for(int i =0;i< arr.Length;i++)
            {
                avg += arr[i];
            }
            return avg / arr.Length;
        }
    }
}
