// ✅ Array, List<T>  loop

//Trova il massimo e minimo in un array

//Calcola la media di una lista di voti

//Conta quante volte compare un numero in un array

using System;
class Program
{
    static void Main()
    {
        int[] array1 = new int[5];

        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine("Inserisci un numero:");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        ArrayList.MassimoMinimo massimoMinimo = new ArrayList.MassimoMinimo(array1);

        // Calcolo della media
        Console.WriteLine("");

        ArrayList.CalcoloMedia calcoloMedia = new ArrayList.CalcoloMedia(array1);
        Console.WriteLine("");


        // Contare quante volte compare un numero
        ArrayList.QuanteVolte quanteVolte = new ArrayList.QuanteVolte(array1);
    }
}
