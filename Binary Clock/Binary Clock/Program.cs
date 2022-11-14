using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dtn = DateTime.Now;
            int ora, min, sec, aux;
            string binary;

            ora = dtn.Hour;
            min = dtn.Minute;
            sec = dtn.Second;
            binary = Convert.ToString(ora / 10, 2);
            aux = Convert.ToInt32(binary);

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }

            Console.WriteLine();
            binary = Convert.ToString(ora % 10, 2);
            aux = Convert.ToInt32(binary);

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            Console.WriteLine();

            binary = Convert.ToString(min / 10, 2);
            aux = Convert.ToInt32(binary);

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;
            
            Console.WriteLine();

            binary = Convert.ToString(min % 10, 2);
            aux = Convert.ToInt32(binary);

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            Console.WriteLine();

            binary = Convert.ToString(sec / 10, 2);
            aux = Convert.ToInt32(binary);

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            Console.WriteLine();

            binary = Convert.ToString(sec % 10, 2);
            aux = Convert.ToInt32(binary);

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            aux /= 10;

            if (aux % 10 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }

            Console.ReadLine();
        }
    }
}
