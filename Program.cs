using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }
        

        static void Main(string[] args)
        {
            
            int x = Convert.ToInt32(Console.ReadLine());  
            int y = Convert.ToInt32(Console.ReadLine());
            
            int sum = Sum(x, y);
            int sub = Sub(x, y);
            Console.WriteLine(sum+" "+sub);
        }
    }
}
