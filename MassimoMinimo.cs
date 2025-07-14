using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class MassimoMinimo
    {
        public MassimoMinimo(int[] input) {

            int numeroMinimo = input[0];
            int numeroMassimo = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > numeroMassimo)
                {
                    numeroMassimo = input[i];
                }
                else if (input[i] < numeroMinimo)
                {
                    numeroMinimo = input[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Il numero minimo è: " + numeroMinimo);
            Console.WriteLine("");
            Console.WriteLine("Il numero massimo è: " + numeroMassimo);
        }
    }
}
