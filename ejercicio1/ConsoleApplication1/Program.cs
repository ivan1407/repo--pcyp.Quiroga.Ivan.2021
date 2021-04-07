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
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");
            if (values.ContainsKey("Juan"))
            {

                Console.WriteLine(values["Juan"]);
             
            }
            else { Console.WriteLine("no existe"); }
            string pedro = "234235";
            if (values.TryGetValue("pedro", out pedro)) { Console.WriteLine(values["pedro"]); }
            else { Console.WriteLine("no contiene la llave"); }
            foreach(KeyValuePair<string,string> value in values) { Console.WriteLine(value.Key + ", " + value.Value); }
            values["Mariana"] = "58251425";
            Console.WriteLine(values["nuevo telefono de Mariana"]);
            Console.ReadLine();

        }
    }
   
  
}



