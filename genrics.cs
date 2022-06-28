using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProblemUsingGenerics
{
    public class genrics
    {
        public void greatest(int a,int b,int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine("Greatest number: {0}",a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Greatest number: {0}", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Greatest number: {0}", c);
            }
            else if (a == b)
            {
                Console.WriteLine(+a + " is equal to " + b + " both number is maximum");
            }
            else if (a == c)
            {
                Console.WriteLine(+a + " is equal to " + c + " both number is maximum");
            }
            else if (b == c)
            {
                Console.WriteLine(+b + " is equal to  " + c + " both number is maximum");
            }
            else
            {
                Console.WriteLine("All three numbers are equal");
            }
        }
    }
}