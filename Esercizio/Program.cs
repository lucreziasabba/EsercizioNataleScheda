using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a = int.MaxValue;
            Console.WriteLine(a);//2.147.483.647 perchè il MaxValue di un int è 2^31-1;
            Console.WriteLine(a + 1);//trovandosi un overflow stampa l'opposto sommando 1 (-2^31);
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            int value = 31;
            int somma = value;
            value = ~value + 1;
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
        }
    }
}
