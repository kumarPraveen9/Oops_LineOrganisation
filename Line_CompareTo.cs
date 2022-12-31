using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class lineCompare1
    {
        public  void line_compare()
        {
            double Leng1 = 0.0;
            double Leng2 = 0.0;
       
            System.Console.WriteLine("Enter x1 y1 x2 y2 value of first line : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Leng1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            System.Console.WriteLine("Enter x1 y1 x2 y2 value of Second line : ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            Leng2 = Math.Sqrt((Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2)));

            Console.WriteLine("\nlength1:: {0}    length2:: {1} ", Leng1, Leng2);
            if (Leng1.CompareTo(Leng2)==0) //leng1==leng2 0=eqal
            {
                Console.WriteLine("\nBoth lines are  equal");
            }
            else if (Leng1.CompareTo(Leng2)==-1) //-1=>less than
            {
                Console.WriteLine("\nline1_length is less than line2_length");
            }
            else
            {
                Console.WriteLine("\nline1_length is greater than line2_length");
            }
        }
    }
}
