using System;

namespace Tema_Proiect_1_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex3
                Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
                tastaura*/

            int numar = 200;
          
            Console.WriteLine("Acest program va afisa ultima cifra a unui numar intreg citit de la tastaura");

            Console.WriteLine("Introduceti numarul");
             numar= int.Parse(Console.ReadLine());


            int ultimaCifraNumar = numar%10;
            Console.WriteLine(ultimaCifraNumar);
        }
    }
}
