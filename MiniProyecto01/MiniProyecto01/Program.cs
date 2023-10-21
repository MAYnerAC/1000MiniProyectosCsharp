using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Generador de Contrasenias Aleatorias");
                Console.Write("Longitud de la Contrasenia: ");
                int longitud = int.Parse(Console.ReadLine());

                string contraseña = GenerarContraseñaAleatoria(longitud);
                Console.WriteLine("Contrasenia Generada: " + contraseña);

                Console.WriteLine("================================================================");
                Console.WriteLine("¿Deseas probar de nuevo? (S/N): ");
                Console.WriteLine("================================================================");

            } while (Console.ReadLine().Trim().ToUpper() == "S");

            //Salir
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();

            //
        }

        static string GenerarContraseñaAleatoria(int longitud)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";

            Random random = new Random();
            char[] contraseña = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                contraseña[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new string(contraseña);
        }

        //
    }

    //
}

//MiniProyectoMAYnerAC