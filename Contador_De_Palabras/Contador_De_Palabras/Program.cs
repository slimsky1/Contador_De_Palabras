using System;
using System.Collections.Generic;
using System.Linq;

namespace Contador_De_Palabras
{
    class Program
    {
        static void Main(string[] args)
        {
            string parrafo = Console.ReadLine();
            Dictionary<string, int> dicPalabras = new Dictionary<string, int>();
            //var values = parrafo.Split(' ');

            List<string> listaPalabras = parrafo.Split(' ').ToList();

            int value;
            foreach(string word in listaPalabras)
            {
                if (dicPalabras.TryGetValue(word, out value))
                {
                    dicPalabras[word]++;
                }
                else
                {
                    dicPalabras.Add(word, 1);
                }
            }

            Console.Clear();

            Console.WriteLine("{0,-10}{1,-20}", "Key: ", "Value: ");

            foreach (KeyValuePair<string, int> valor in dicPalabras)
            {
                Console.WriteLine("{0,-10}{1,-20}",valor.Key, valor.Value);
            }

            Console.WriteLine();

            Console.WriteLine("size: " + dicPalabras.Count);
            

        }
    }
}
