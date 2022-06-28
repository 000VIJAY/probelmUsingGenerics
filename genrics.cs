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
        public void greatest(double a,double b,double c)
        {
            if (a.CompareTo(b) >0 && a.CompareTo(c) > 0)
            {
                Console.WriteLine("Greatest name: {0}",a);
            }
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                Console.WriteLine("Greatest name: {0}", b);
            }
            else if (c.CompareTo(b) > 0 && c.CompareTo(a) > 0)
            {
                Console.WriteLine("Greatest name: {0}", c);
            }
            else
            {
                Console.WriteLine("All three numbers are equal or greatest two are equal");
            }
        }
    }
}