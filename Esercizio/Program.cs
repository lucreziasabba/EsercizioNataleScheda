using System;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a = int.MaxValue;
            Console.WriteLine(a);//2.147.483.647 perchè il MaxValue di un int è 2^31-1;
            if (a != int.MaxValue)
            {
                Console.WriteLine(a + 1); //trovandosi un overflow stampa l'opposto sommando 1 (-2^31); 
            }
            int b = -128;//b vale -128;
            int c = -b;//c vale l'opposto di b;
            Console.WriteLine(Convert.ToString(b, 2));//b viene convertita da decimale a binario;
            Console.WriteLine(Convert.ToString(c, 2));//c viene convertita da decimale a binario;
            Console.WriteLine("Inserisci un numero: ");
            int value = int.Parse(Console.ReadLine());
            int somma = value;
            value = ~value + 1;
            //value = value + 1;
            somma = somma + value;
            Console.WriteLine($"{value} è un valore opposto a quello inserito e {somma} è la somma tra il valore inserito e quello opposto");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));//si converte number in binario;
            short number1 = (short)number;//si cambia il tipo di variabile da long a short;
            Console.WriteLine(number1);//si stampa number1, ma è errato perchè le variabili short vanno da da -32,768 a 32,767 quindi va in overflow.
            Console.ReadLine();
        }
    }
}
