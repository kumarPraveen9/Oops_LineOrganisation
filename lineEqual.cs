using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class lineEqual
    {
        public  void equal()
        {
            double Leng1 = 0.0;
            double Leng2 = 0.0;
            System.Console.WriteLine("Calculating First Line length of two points of x,y Co-ordinates : \n");
            System.Console.WriteLine("Enter x1 y1 x2 y2 value of first point : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Leng1 = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            System.Console.WriteLine("Enter x1 y1 x2 y2 value of Second point : ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            Leng2 = Math.Sqrt((Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2)));

            Console.WriteLine("\nlength1:: {0}    length2:: {1} ", Leng1, Leng2);
            if (Leng1 == Leng2)
            {
                Console.WriteLine("Both line are Equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equal");
            }
        }
    }
}
