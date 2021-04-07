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
            string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
            string[] removeColors = { "RED", "WHITE", "BLUE" };
            List<string> colores = new List<string>(colors);
            List<string> removedor = new List<string>(removeColors);

            foreach (string color in colores) { Console.WriteLine(color); }
            int x, i;
            for (x = 0; x < colores.Count; x++)
            {
                for (i = 0; i < removedor.Count; i++) { if (removedor[i] == colores[x]) { colores.RemoveAt(x); } }

            }
            Console.WriteLine("\ncolores removidos ");
            foreach (string color in colores) { Console.WriteLine(color); }
            Console.ReadLine();     }
    }
}
