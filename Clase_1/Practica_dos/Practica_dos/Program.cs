using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string operacion;
            string resultado;
            string resultado1;
            string resultado2;
            int cantidad1;
            int cantidad2;
            string continuar;
            string continuar2;



            Console.WriteLine("Escriba el numero de la operacion que gustes realizar:");

            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Memoria");

            operacion = Console.ReadLine();


            Console.WriteLine("Ingrese la primera cantidad");
            cantidad1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda cantidad");
            cantidad2 = Console.ReadLine();

            
            switch (operacion)
            {

                case "1":
                    Console.WriteLine("El resultado de la suma es:");
                    resultado = cantidad1 + cantidad2;
                    Console.WriteLine("resultado {0} + {1} = {2}", cantidad1, cantidad2, resultado);
                    Console.WriteLine("¿Desea utilizar el resultado para otra operacion? si/no");
                    continuar2 = Console.ReadLine();
                    /*_ = continuar2 == "si";*/
                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                    Console.WriteLine("Agregue un nuevo dato para sumar");
                    resultado1 = (Console.ReadLine());
                    resultado2 = resultado + resultado1;
                    Console.WriteLine("El resultado es:" + resultado2 + "\n");
                    break;

                case "2":
                    Console.WriteLine("El resultado de la resta es:");
                    resultado = cantidad1 - cantidad2;
                    Console.WriteLine("{0} - {1} = {2}", cantidad1, cantidad2, resultado);
                    Console.WriteLine("¿Desea utilizar el resultado para otra operacion? si/no");
                    continuar2 = Console.ReadLine();
                    _ = continuar2 == "si";
                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                    Console.WriteLine("Agregue un nuevo dato para restar");
                    resultado1 = (Console.ReadLine());
                    resultado2 = resultado - resultado1;
                    Console.WriteLine("El resultado es:" + resultado2 + "\n");
                    break;

                case "3":
                    Console.WriteLine("El resultado de la suma es:");
                    resultado = cantidad1 * cantidad2;
                    Console.WriteLine("{0} * {1} = {2}", cantidad1, cantidad2, resultado);
                    Console.WriteLine("¿Desea utilizar el resultado para otra operacion? si/no");
                    continuar2 = Console.ReadLine();
                    _ = continuar2 == "si";
                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                    Console.WriteLine("Agregue un nuevo dato para sumar");
                    resultado1 = (Console.ReadLine());
                    resultado2 = resultado * resultado1;
                    Console.WriteLine("El resultado es:" + resultado2 + "\n");
                    break;

                case "4":
                    Console.WriteLine("El resultado de la suma es:");
                    resultado = cantidad1 / cantidad2;
                    Console.WriteLine("{0} / {1} = {2}", cantidad1, cantidad2, resultado);
                    Console.WriteLine("¿Desea utilizar el resultado para otra operacion? si/no");
                    continuar2 = Console.ReadLine();
                    _ = continuar2 == "si";
                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                    Console.WriteLine("Agregue un nuevo dato para sumar");
                    resultado1 = (Console.ReadLine());
                    resultado2 = resultado / resultado1;
                    Console.WriteLine("El resultado es:" + resultado2 + "\n");
                    break;
            }



                 Console.WriteLine("******************");
                 Console.WriteLine("¿Desea realizar otra operacion?");
                 Console.WriteLine("1. Si");
                 Console.WriteLine("2. No");

                 continuar = Console.ReadLine();

                 if (continuar == "1")
                 {
                     Console.Clear();
                 }



             Console.WriteLine("Presione una tecla para salir");
             Console.ReadKey();

         }

            /*static void Calcular (int operacion, double resultado,double continuar2, double resultado2)
            {

                Console.Clear();
                switch (operacion)
                {
                    case 1:
                        {

                            Console.WriteLine("Desea utilizar el resultado para otra operacion? si/no");
                            continuar2 = Console.ReadLine();
                            _ = continuar2 = "si";
                            Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                            Console.WriteLine("Agregue nuevo dato para sumar");
                            resultado2 = resultado + resultado2;
                            Console.WriteLine("El resultado es:" + resultado + "\n");
                            break;
                        }
                        /*
                                            case 2:
                                                {
                                                    Console.WriteLine("RESTAR");
                                                    Console.WriteLine("");
                                                    CalcularRespuesta(operacion);
                                                    Console.WriteLine("Desea utilizar el resultado para otra operacion? si/no");
                                                    continuar2 = Console.ReadLine();
                                                    _ = continuar2 == "si";
                                                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                                                    Console.WriteLine("Agregue nuevo dato para sumar");
                                                    resultado2 = resultado - resultado2;
                                                    Console.WriteLine("El resultado es:" + resultado + "\n");
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    Console.WriteLine("MULTIPLICAR");
                                                    Console.WriteLine("");
                                                    CalcularRespuesta(operacion);
                                                    Console.WriteLine("Desea utilizar el resultado para otra operacion? si/no");
                                                    continuar2 = Console.ReadLine();
                                                    _ = continuar2 == "si";
                                                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                                                    Console.WriteLine("Agregue nuevo dato para sumar");
                                                    resultado2 = resultado * resultado2;
                                                    Console.WriteLine("El resultado es:" + resultado + "\n");
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    Console.WriteLine("DIVIDIR");
                                                    Console.WriteLine("");
                                                    CalcularRespuesta(operacion);
                                                    Console.WriteLine("Desea utilizar el resultado para otra operacion? si/no");
                                                    continuar2 = Console.ReadLine();
                                                    _ = continuar2 == "si";
                                                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                                                    Console.WriteLine("Agregue nuevo dato para sumar");
                                                    resultado2 = resultado / resultado2;
                                                    Console.WriteLine("El resultado es:" + resultado + "\n");
                                                    break;
                                                }

                                            default:
                                                break;


                                        }
                                    }

                                    private static void CalcularRespuesta(int operacion)
                                    {
                                        Console.WriteLine("Escribe el primer numero: ");
                                        double Valor1 = double.Parse(Console.ReadLine());
                                        Console.WriteLine("Escribe el segundo numero: ");
                                        double Valor2 = double.Parse(Console.ReadLine());

                                        if (operacion == 1)
                                        {
                                            double resultado = numero1 + numero2;
                                            Console.WriteLine("resultado {0} + {1} = {2}", valor1, valor2, resultado);
                                        }
                                        if (operacion == 2)
                                        {
                                            double resultado = numero1 - numero2;
                                            Console.WriteLine("resultado {0} - {1} = {2}", valor1, valor2, resultado);
                                        }
                                        if (operacion == 3)
                                        {
                                            double resultado = numero1 * numero2;
                                            Console.WriteLine("resultado {0} * {1} = {2}", valor1, valor2, resultado);
                                        }
                                        if (operacion == 4)
                                        {
                                            double resultado = numero1 / numero2;
                                            Console.WriteLine("resultado {0} / {1} = {2}", valor1, valor2, resultado);
                                        }


                                    }
                                    */

                }
            }
        
