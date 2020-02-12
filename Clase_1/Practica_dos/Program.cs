using System;

namespace Calculadora
{
	class Program
	{
        static void Main(string[]args)
        {
            string continuar;
            int operacion;
            do
            {
                Console.WriteLine("Escriba el numero de la operacion que gustes realizar:");

                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. ");
                 
                operacion = int.Parse(Console.ReadLine());

                Calcular(operacion);

                Console.WriteLine("******************");
                Console.WriteLine("¿Desea realizar otra operacion?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");

                continuar = Console.ReadLine();

                if (continuar == "1")
                {
                    Console.Clear();
                }

            } while (continuar == "1");

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }

        private static void Calcular(int operacion)
        {
            Console.Clear();
            switch (operacion)
            {
                case 1:
                    {
                        Console.WriteLine("SUMAR");
                        Console.WriteLine("");
                        CalcularRespuesta(operacion);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("RESTAR");
                        Console.WriteLine("");
                        CalcularRespuesta(operacion);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("MULTIPLICAR");
                        Console.WriteLine("");
                        CalcularRespuesta(operacion);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("DIVIDIR");
                        Console.WriteLine("");
                        CalcularRespuesta(operacion);
                        break;
                    }

                default:
                    break;


            }
        }

        private static void CalcularRespuesta(int operacion)
        {
            Console.WriteLine("Escribe el primer numero: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero: "),
            double numero2 = double.Parse(Console.ReadLine());

            if(operacion == 1)
            {
                double resultado = numero1 + numero2;
                Console.WriteLine("Resultado {0} + {1} = {2}", numero1, numero2, resultado);
            }
            if(operacion == 2)
            {
                double resultado = numero1 - numero2;
                Console.WriteLine("Resultado {0} - {1} = {2}", numero1, numero2, resultado);
            }
            if (operacion == 3)
            {
                double resultado = numero1 * numero2;
                Console.WriteLine("Resultado {0} * {1} = {2}", numero1, numero2, resultado);
            }
            if (operacion == 4)
            {
                double resultado = numero1 / numero2;
                Console.WriteLine("Resultado {0} / {1} = {2}", numero1, numero2, resultado);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre {0}", numero2);
            }

        }


	}
}
