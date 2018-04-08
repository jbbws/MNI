using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MNI
{
    struct FactorInfo
    {
        public double left;
        public double right;
    }
    struct FactorsLimits
    {
        public FactorInfo[] limits;
        public int err;        
        public FactorsLimits(int count)
        {
            this.limits = new FactorInfo[count];
            this.err = 0;
        }   
        double ConvertData(int side,string t,int fn)
        {
            double res = 0;
            try
            {
                res = Convert.ToDouble(t);
            }
            catch(FormatException e)
            {
                MessageBox.Show(this.ConvertErr(2, side, fn));

            }
            catch(OverflowException e)
            {
                MessageBox.Show(this.ConvertErr(1, side, fn));
            }
            return res;
        }
        string ConvertErr(int type, int side, int f)
        {
            string res= String.Empty;
            switch(type)
            {
                case 1:
                    res = String.Format("Значение {0} границы  фактора №{1} превышает допустимые значения", side == 1 ? "левой" : "правой", f);

                    this.err = 1;
                    break;
                case 2:
                    res = String.Format("Невозможно преобразовать значение {0} границы интервала фактора №{1}", side == 1 ? "левой" : "правой", f);
                    this.err = 1;
                    break;
            }
            return res;
        }
        public void ReadFactor(string left, string right,int f)
        {
            this.limits[f - 1].left = ConvertData(1, left, f);
            this.limits[f - 1].right = ConvertData(1, right, f);
        }        
        public void ClearData(int i)
        {
            limits = new FactorInfo[i];
            err = 0;
        }
    }
    struct ExeprimentData
    {
       public int type;
       public int factorsCount;

    }
}
