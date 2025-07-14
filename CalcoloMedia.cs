using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class CalcoloMedia
    {
        public CalcoloMedia(int[] input) {
            int somma = 0;
            int numeroElementi = input.Length;

            for (int i = 0; i < input.Length; i++)
            {
               somma += input[i];
            }
            somma /= numeroElementi;
            Console.WriteLine("La media dei voti è: " + somma);
        }
    }
}
