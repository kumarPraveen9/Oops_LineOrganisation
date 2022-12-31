using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLength
    {
        public  void cal_len()
        {
            double Leng = 0.0;
            System.Console.WriteLine("Calculating length of two points of x,y Co-ordinates : \n");
            System.Console.WriteLine("Enter x1 y1 x2 y2 value of first point : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            
            Leng = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            System.Console.WriteLine("\nThe length of two points is: "+Leng);
        }
    }
}
