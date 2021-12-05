using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allfiles = Directory.GetFiles("C:/Users/User/Desktop/Учеба Программированию/8 день 22.11.2021/lab8/lab8/bin/Debug");
            foreach(string filename in allfiles)
            {
                Console.WriteLine(filename);
            }
                        {
                Console.ReadLine();
            }

        }
    }
}
