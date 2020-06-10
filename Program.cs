using System;

namespace En_un_dia__Ejercicio_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que use el operador condicional para mostrar el valor absoluto de un numero de la siguiente forma:
            //si el numero es positivo, se mostrara tal cual; si es negativo, se mostrara el signo cambiado.

            int num;
            Console.WriteLine("Ingresar numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0) { Console.WriteLine("El numero es negativo " + num); }
            else
            {
                Console.WriteLine("El numero es positivo " + num);
            }

            Console.ReadKey();
        }
    }
}
