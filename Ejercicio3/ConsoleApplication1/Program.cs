using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            Console.WriteLine("ingrese un parrafo\n");
            string parrafo = Console.ReadLine();
            string[] palabras = parrafo.Split(' ');
            int cont = 0;
            foreach (string palabra in palabras)
            {
                string palabraActual = palabra;
                foreach (string word in palabras)
                {
                    if (palabraActual.Equals(word)) { cont++; }
                }
                if (diccionario.Count == 0)
                {
                    diccionario.Add(palabraActual, cont);
                    cont = 0;
                }
                else
                {
                    bool repetido = false;
                    for (int x = 0; x < diccionario.Count; x++)
                    {
                        if (diccionario.ElementAt(x).Key.Equals(palabraActual) && diccionario.ElementAt(x).Value.Equals(cont))
                        {
                            repetido = true;
                            break;
                        }
                    }
                    if (repetido == false)
                    {
                        diccionario.Add(palabraActual, cont);
                    }
                }
                cont = 0;
            }
            Console.WriteLine("\ncontenido del diccionario ");
            Console.WriteLine("Key\t\tValue");
            foreach (KeyValuePair<string, int> elemento in diccionario)
            {
                Console.WriteLine(elemento.Key + "\t\t" + elemento.Value);
                cont++;


            }
            Console.WriteLine("total de palabras sin repetir: " + cont);
            Console.ReadLine();
        }

    }
}
