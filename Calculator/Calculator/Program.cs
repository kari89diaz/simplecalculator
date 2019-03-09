using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation;
            int operatorone;
            int operatortwo;
            int result;
            Console.WriteLine("Seleccione operador:");
            Console.WriteLine("1. Suma     2. Resta    3.Multiplicación    4.División");
            operation = int.Parse(Console.ReadLine());
            Console.Clear();
            
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Ingrese operador 1:");
                    operatorone = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese operador 2");
                    operatortwo = int.Parse(Console.ReadLine());
                    Console.Clear();
                    result = operatorone + operatortwo;
                    Console.WriteLine("El resultado de la suma {0}+{1}={2}", operatorone, operatortwo, result);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Ingrese operador 1:");
                    operatorone = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese operador 2");
                    operatortwo = int.Parse(Console.ReadLine());
                    Console.Clear();
                    result = operatorone - operatortwo;
                    Console.WriteLine("El resultado de la resta {0}-{1}={2}", operatorone, operatortwo, result);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Ingrese operador 1:");
                    operatorone = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese operador 2");
                    operatortwo = int.Parse(Console.ReadLine());
                    Console.Clear();
                    result = operatorone * operatortwo;
                    Console.WriteLine("El resultado de la multiplicacion {0}x{1}={2}", operatorone, operatortwo, result);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Ingrese operador 1:");
                    operatorone = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese operador 2");
                    operatortwo = int.Parse(Console.ReadLine());
                    Console.Clear();
                    result = operatorone / operatortwo;
                    Console.WriteLine("El resultado de la división {0}%{1}={2}", operatorone, operatortwo, result);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("La opción ingresada no es válida");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
