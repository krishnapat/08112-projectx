using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_x
{
    class Program
    {
        static void Main(string[] args)
        {
            // program projectx
            string x;
            bool f;
            int a,z,g;
            Console.WriteLine("Enter input");
            string input;
            input = Console.ReadLine();
            x = input;
            g = input.Length;
            z = g -1;
            a = 0;
            if (g == 1) 
            {
                f = true;
            }     
        f = true;

        while (f = true & (a < z))
        {
            //while character at a of x is one of 
            while (x[a] == ' ' || x[a] == ',' || x[a] == '!' || x[a] == '?' || x[a] == '.')
            {
                a++;
            }
            while (x[z] == ' ' || x[z] == ',' || x[z] == '!' || x[z] == '?' || x[z] == '.')
            {
                z--;
            }
            string wq = x.ToUpper();
            if ( wq[a] == wq[z]  )
            {
                z--;
                a++;
            }
            else
            {
                f = false;
            }
        }

            if (f == false)
            {

            }
            else 
            {

            }
            
        }
    }
}
