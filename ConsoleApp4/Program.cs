using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Find_it(int[] seq)
        {
            for (var i = 0; i < seq.Length; i++)
            {
                var counter = 0;
                for (var j = 0; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        counter++;
                    }
                    
                }
                if (counter % 2 != 0)
                {
                    return seq[i];
                }
            }
            return -1;
        }
    }
}
