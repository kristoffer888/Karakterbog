using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakterbog
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            float x = 0;
            List<float> karakterliste = new List<float>();
            while (x != 0 || i == 0)
            {
                Console.WriteLine("skriv karakter");
                string input = Console.ReadLine();
                if (input != "")
                {
                    x = float.Parse(input);
                }
                karakterliste.Add(x);
                if (input == "")
                {
                    Console.Clear();
                    float max = karakterliste.Max();
                    float min = karakterliste.Min();
                    float average = karakterliste.Average();
                    Console.WriteLine("Max = {0}, Min = {1}, Average = {2} ", max, min, average);
                }
            }
        }
    }
}
