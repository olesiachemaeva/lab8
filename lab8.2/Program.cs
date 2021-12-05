using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "10 чисел/Log.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            { 
                sw.WriteLine("10 случайых чисел: "); 
             }
            double[] myarr = new double[10];
            Random random = new Random();

            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = random.Next();
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(Convert.ToString(myarr));
            }

        }
    }
}
