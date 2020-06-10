using System;

namespace En_un_dia__Ejercicio_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que lea una letra tecleada por el usuario y diga si
            //se trata de un signo de puntuacion, una cifra numerica o algun otro caracter.
            char T;
            Console.WriteLine("Ingresar Tecla");
            T = Convert.ToChar(Console.ReadLine());
            switch (T)
            {
                case ' ': Console.WriteLine("Es un Espacio"); break;
              
                case 'b': goto case 'a';
                case 'c': goto case 'a';
                case 'd': goto case 'a';
                case 'e': goto case 'a';
                case 'f': goto case 'a';
                case 'g': goto case 'a';
                case 'h': goto case 'a';
                case 'i': goto case 'a';
                case 'j': goto case 'a';
                case 'k': goto case 'a';
                case 'l': goto case 'a';
                case 'm': goto case 'a';
                case 'n': goto case 'a';
                case 'ñ': goto case 'a';
                case 'o': goto case 'a';
                case 'p': goto case 'a';
                case 'q': goto case 'a';
                case 'r': goto case 'a';
                case 's': goto case 'a';
                case 't': goto case 'a';
                case 'u': goto case 'a';
                case 'v': goto case 'a';
                case 'w': goto case 'a';
                case 'x': goto case 'a';
                case 'y': goto case 'a';
                case 'z': goto case 'a';
                case 'a': Console.WriteLine("Es una letra"); break;

                case '.': goto case ',';
                case ';': goto case ',';
                case ':': goto case ',';
                case '{': goto case ',';
                case '"': goto case ',';
                case '?': goto case ',';
                case '(': goto case ',';
                case ')': goto case '.';
                case '<': goto case ',';
                case '>': goto case '.';
                case '}': goto case ',';
                case '-': goto case ',';
                case ',': Console.WriteLine("Es un signo de puntuacion"); break;



                case '1': goto case '0';
                case '2': goto case '0';
                case '3': goto case '0';
                case '4': goto case '0';
                case '5': goto case '0';
                case '6': goto case '0';
                case '7': goto case '0';
                case '8': goto case '0';
                case '9': goto case '0';
                case '0': Console.WriteLine("Es una cifra numerica"); break;



                default: Console.WriteLine("algun otro caracter"); break;
            }
            Console.ReadLine();
            }
        }
}
