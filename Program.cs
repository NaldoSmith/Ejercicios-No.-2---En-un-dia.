using System;

namespace En_un_dia__Ejercicio_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usar el operador condicional para calcular el menor de dos numeros.
            int num;
            int num1;
            Console.WriteLine("Ingresar num 1");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar num 2");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num < num1)
            {
                Console.WriteLine(num + " Es el menor");
            }
            else if (num1 < num)
            { 
                Console.WriteLine(num1 + " Es el menor");
            }
            Console.ReadLine();
        }
    }
}
