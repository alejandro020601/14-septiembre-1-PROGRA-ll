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
            int num1 = 0;
            int num2 = 10;
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
            edad = byte.Parse(Console.ReadLine()); //=>"abc" ==> 52
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("su nombre completo y su edad es: " + nombre + apellido + " " + edad);

            Console.WriteLine("Digite un numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) //numero 1 mayor que numero 2
            {
                Console.WriteLine($"El numero mayor es {num1}");
            }
            else if (num1 < num2) //numero 2 mayor que numero 1
            {
                Console.WriteLine($"El numero mayor es {num2}");
            }
            else
            {
                Console.WriteLine($" El numero {num1} es igual");
            }
            float resultado = (num1 + num2);
            Console.WriteLine("La suma es: {0}", resultado);
            resultado = (num1 - num2);
            Console.WriteLine("La resta es: {0}", num1 - num2);
            Console.WriteLine("multiplicacion: {0}", num1 * num2);
            Console.WriteLine("La division es: {0}", (float)num1 / num2);

            //Actualizacion

        }
    }
}
