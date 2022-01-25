using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProb2
{
    public class HarmonicNumber
    {
        public void GetHarmonic()
        {
            float h1 = 1;
            Console.WriteLine("Enter which harmonic number you need:");
            int harmonic = (int)Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= harmonic; i++)
            {
                h1 += (float)1 / i;
            }
            Console.WriteLine("{0}th Harmonic number is : {1}", harmonic,h1);

        }
    }
}
