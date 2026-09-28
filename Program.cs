using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres = new string[max];
        static double[] notas = new double[max];
        static int contador = 0;
        static public void Titulo()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Sistemas de Gestión de notas");
            Console.WriteLine("*******************************");
        }
        static public void Registrar_estudiante()
        {
            Console.WriteLine("Registro de estudiante nuevo: ");
            if (contador >= 100)
            {
                Console.WriteLine("alcanza la capacidad máxima");
                return;
            }
            Console.Write("Ingresar nombre del estudiante: ");
            string nombre = Console.ReadLine();
            double nota;
            while (true)
            {
                Console.Write("Ingresar nota[0-20]:");
                nota = double.Parse(Console.ReadLine());
                if(nota >=0 && nota <= 20)
                {
                    break;
                }
                Console.WriteLine("Error, Volver a ingresar la nota [0-20]");
            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
            Console.WriteLine("Registro con éxito...!!");
        }
        static public void buscar_estudiante()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
