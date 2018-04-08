using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNI
{
    public class StaticAnalyse
    {


         double AdekvatDispersion(double[] expRes, double[] mathRes, int countExp,int factCount)
        {
            double step = countExp - (factCount + 1);
            double summ = 0;
            for(int i =0;i <expRes.Length;i++)
            {
                summ += Math.Pow((expRes[i] - mathRes[i]), 2);
            }
            return summ / step;
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
        double OptimDisper(double[] res, double average, int expCount)
        {
            double summ = 0;
            for (int i = 0; i < res.Length; i++)
            {
                summ += Math.Pow((res[i] - average), 2);
            }
            return summ / expCount-1;
        }
        public double Fisher(double[] eRes, double[] mRes, int eCount, int fCount)
        {
            return AdekvatDispersion(eRes, mRes, eCount, fCount) / OptimDisper(eRes, getAverage(eRes), eCount);
        }  
        public double Student(double[] arg,double[] expRes, double[] mathRes, int expCount, int factCount,bool lib)
        {
            double  arg_av = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                arg_av += arg[i];
            }
            arg_av = arg_av / expCount;
            double arg_disp = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                arg_disp += Math.Pow(arg[i], 2); 
            }
            arg_disp = arg_disp / expCount;
            arg_disp = arg_disp - arg_av;
            double SKO = Math.Sqrt(arg_disp);

            double disp = 0;
            for (int i = 0; i < expRes.Length; i++)
            {
                double t = Math.Pow(expRes[i] - mathRes[i],2);
                disp += t;
            }
            disp = disp / (expCount - factCount - 1);
            disp = Math.Sqrt(disp);
            double stn = 0;
            if(lib == true)
            {
               // stn = disp/(Math.Sqrt(expCount)*)
            }
            else
            {

            }
            return 1;
        }

    }
}
