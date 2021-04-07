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
            Console.WriteLine("ingrese un parrafo\n");
            string parrafo = Console.ReadLine();
            string[] palabra = parrafo.Split(' ');
            int cont=0;
            foreach(string palabras in palabra) { cont++; }
            for(int x = 0; x < palabra.Length; x++)
            {
                for (int i = 0; i < palabra.Length; i++) { if (palabra[i] == palabra[x]) cont++; }

            }

        }
    }
}
