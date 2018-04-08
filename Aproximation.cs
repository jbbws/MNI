﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MNI.Base;
using System.Data;
namespace MNI
{
    public class Aproximation
    {
        public double[] Answers { get; set; }
        public double[][] Gauss { get; set; }
        int countParam;
        int levelAprox;
        int Arguments { get; set; }
        int Factors { get; set; }
        public Aproximation(int factors, int seriescount)
        {
            Arguments = seriescount;
            Factors = factors;
            levelAprox = factors;
            countParam = factors + 1;
        }
        public double summul(double[] x1, double[] x2)
        {
            double sum = 0;
            for(int i =0; i<x1.Length;i++)
            {
                sum += x1[i] * x2[i];
            }
            return sum;
        }

        public double[] MulStrToNumber(double[] arr, double number)
        {
            double[] res = new double[arr.Length];
            for(int i = 0; i< arr.Length;i++)
            {
                res[i] = arr[i] * number;//(double.IsNaN(number) ? 0: number);
            }
            return res;
        }
    
        public double[] SubStrMatrx(double[] arr1, double[] arr2)
        {
            double[] res = new double[arr1.Length];
            for(int i =0; i < arr1.Length; i++)
            {
                res[i] = arr1[i] - arr2[i];
            }
            return res;
        }


        //public double[][] FillMatrix(double[][] source)
        //{ 
        //    double[][] res = new double[countParam][];
        //    for(int i = 0; i <countParam;i++)
        //    {
        //        res[i] = new double[countParam + 1];
        //        for(int j=0; j<countParam+1; j++)
        //        {
        //            res[i][j] = summul(source[j], source[i]);
        //        }
        //    }
        //    return res;
        //}
        public double[][] GetDataFromView(DataTable list)
        {
            Arguments = list.Rows.Count;
            double[][] res = new double[Arguments][];
            for (int i = 0; i < Arguments; i++)
            {
                res[i] = new double[list.Columns.Count];
                for (int j  = 0; j < list.Columns.Count; j++)
                {
                    res[i][j] = (double)list.Rows[i].ItemArray[j];
                }
            }
            return res;
        }
        public void DirectGaussMethod()
        {
            for (int i = 0; i < Factors; i++)
            {
                double[] v1 = MulStrToNumber(Gauss[i], 1 / Gauss[i][i]);    
                for (int j = i + 1; j < Arguments; j++)
                {
                    double[] v2 = MulStrToNumber(v1, Gauss[j][i]);
                     Gauss[j] = SubStrMatrx(Gauss[j],v2);
                }
            }
        }    
       /* int FindLastNotNullMemer()
        {
            double eps = 0.0001;
            int index = Factors - 1;
            int result = Arguments - 1;
            for(int i = Gauss.Length - 1; i >= 0;i --)
            {
                if( Math.Abs(Gauss[i][index] - 0) > eps)
                {
                    result = i;
                    return result;
                }
            }
            return index;
        }*/
        public void BackGaussMethod()
        {
            Answers = new double[Factors];
            //int item = FindLastNotNullMemer();
            double div = Gauss[Factors - 1][Factors]/ Gauss[Factors - 1][Factors - 1];
            //double lib = Gauss[countParam-1][countParam ]/ Gauss[countParam-1][countParam-1];
            Answers[Factors - 1] = div;// double.IsNaN(div) ? 0 : div;
            for (int i = Factors - 2; i >= 0; i--)
            {
                double summ = 0;
                for (int j = Factors - 1; j>i; j--)
                {
                    summ += Gauss[i][j] * Answers[j];
                }
                double v1 = (Gauss[i][Factors] - summ)/Gauss[i][i];
                Answers[i] = v1;//double.IsNaN(v1) ? 0 : v1; 
            }
        }

        //public double[] evalApproximation(double[][] fact)
        //{
        //    double[] res = new double[fact.Length];
        //    for (int k = 0; k < fact.Length; k++)
        //    {
        //        res[k] = 0;
        //        for (int i = 0; i < Answ.Length - 1; i++)
        //        {
        //            res[k] += Answ[i] * fact[i][k];
        //        }
        //    }
        //    return res;
        //}  
    }
}
