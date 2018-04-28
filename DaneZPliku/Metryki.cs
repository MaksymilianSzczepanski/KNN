using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaneZPliku
{
    public delegate double Metryka(double[] ob,double[]ob2);

    class Metryki
    {
        public double eklidesowa(double[] ob1, double[]ob2)
        {
            double d = 0.0;
            for (int i = 0; i < ob1.Length; i++)
            {
                d += Math.Pow((ob1[i] - ob2[i]), 2);             
            }
            d = Math.Sqrt(d);
            return d;
        }
        public double czebaszewa(double[] ob1,double[] ob2)
        {
            List<double> wartosci = new List<double>();
            double pom = 0;
            for (int i = 0; i < ob1.Length; i++)
            {
                wartosci.Add(Math.Abs(ob1[i] -ob2[i]));              
            }
            pom = wartosci[0];
            for (int i = 0; i < wartosci.Count; i++)
            {
                if (pom < wartosci[i])
                    pom = wartosci[i];
            }
            return pom;
        }
        public double manhattan(double[] ob1,double[] ob2)
        {
            double wynik=0;
            for (int i = 0; i < ob1.Length; i++)
            {
                wynik += Math.Abs(ob1[i] - ob2[i]);
            }
            return wynik;
        }
        public double canberra(double[] ob1,double[] ob2)
        {                     
            double d=0.0;
            for (int i = 0; i < ob1.Length; i++)
            {
                d+=Math.Abs((ob1[i] - ob2[i])/(ob1[i] + ob2[i]));
            }           
            return d;
        }

        public double pearsona(double[] ob1,double[] ob2)
        {
            double sr_ob1=0.0;
            double sr_ob2=0.0;
            double suma=0;
            double suma1=0;
            double wynik = 0.0;
            for (int i = 0; i < ob1.Length; i++)
			{
			    suma+=ob1[i];
                suma1+=ob2[i];
			}
            sr_ob1=suma/ob1.Length;            
            sr_ob2=suma1/ob1.Length;
            double suma_ob1=0.0;
            double suma_ob2=0.0;
            for (int i = 0; i < ob1.Length; i++)
			{
			    suma_ob1+=Math.Pow(ob1[i]-sr_ob1,2);
                suma_ob2 += Math.Pow(ob2[i] - sr_ob2, 2);
			}

           
           
            double r=0.0;
            for (int i = 0; i < ob1.Length; i++)
            {
                r += ((ob1[i] - sr_ob1) / Math.Sqrt(suma_ob1 / ob1.Length)) * ((ob2[i] - sr_ob2) / Math.Sqrt(suma_ob2 / ob2.Length));
            }
            r /= ob1.Length;
            wynik = 1 - Math.Abs(r);
            return wynik;
        }


    }
}
