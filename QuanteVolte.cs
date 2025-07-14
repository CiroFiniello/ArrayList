using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class QuanteVolte
    {
        public QuanteVolte(int[] input)
        {
            int maxValore = input.Max();  // Trova il valore massimo per sapere quanto grande fare il contatore
            int[] contatore = new int[maxValore + 1]; // Array contatore per ogni numero

            // Conta le occorrenze
            for (int i = 0; i < input.Length; i++)
            {
                contatore[input[i]]++;
            }

            // Stampa solo i numeri che compaiono almeno una volta
            for (int i = 0; i < contatore.Length; i++)
            {
                if (contatore[i] > 0)
                {
                    Console.WriteLine($"Il numero {i} compare {contatore[i]} volte.");
          

                }
            }

        }
    }
}
