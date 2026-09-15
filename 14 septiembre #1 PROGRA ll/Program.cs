using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_septiembre__1_PROGRA_ll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;

            int num3, num4;
            float flotante = 3.14f;
            string cadena = "Hola mundo";
            String cadena2 = "Hola mundo 2";
            char caracter = 'A';
            Boolean booleano;
            bool booleano2 = true;

            var variable = 20; // tipo de dato inferido

            dynamic dinamica = null; // tipo de dato dinámico
            dinamica = "Hola mundo"; // se puede cambiar el tipo de dato en tiempo de ejecución
            dinamica = 3.14; // se puede cambiar el tipo de dato en tiempo de ejecución
            dinamica = true; // se puede cambiar el tipo de dato en tiempo de ejecución

            string nombre = "Alejandro ";
            Console.WriteLine("Yo me llamo: " + nombre);
            string apellido;
            Console.WriteLine("Digite su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Su nombre completo es: " + nombre + apellido);   //Concatenacion
            Console.WriteLine($"Su nombre completo es: {nombre}{apellido}");   //Interpolacion
            Console.WriteLine("Su nombre completo es: {0}{1}", nombre, apellido); // formato de cadenas
            Console.WriteLine("{0} Su nombre completo es: {1}", nombre, apellido); // formato de cadenas //se imprime dependiendo de donde estan los {}
            byte edad;
            float salario;
            double estatura;

            Console.WriteLine("digite su edad:");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("su nombre completo y su edad es: " + nombre + apellido + " " + edad);

        }
    }
}
