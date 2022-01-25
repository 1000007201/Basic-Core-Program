using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProb2
{
    public class TossResult
    {
        int head_count = 0;
        int tail_count = 0;
        public void Toss()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int random_number = rand.Next(2);
                if (random_number == 0)
                {
                    head_count++;
                }
                else
                {
                    tail_count++;
                }

            }
            Console.WriteLine("Percentage of Heads is {0}\nPercentage of Tails is {1}",head_count,tail_count);

        }
        
    }
}
