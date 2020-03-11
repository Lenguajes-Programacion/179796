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
        //static void Main(string[] args)
        static void G(string[] args)
        {
            Memoria memoria = new Memoria();
            bool close_app = true;
            //Variables
            string operacion;
            string resultado;
            string resultado1;
            string resultado2;
            int cantidad1;
            int cantidad2;
            string continuar;
            string continuar2;
            string opcion;



            Console.WriteLine("Escriba la opcion de operacion que guste realizar:");

            Console.WriteLine("(+) Sumar");
            Console.WriteLine("(-) Restar");
            Console.WriteLine("(*) Multiplicar");
            Console.WriteLine("(/) Dividir");
            Console.WriteLine("(m) Memoria");
            Console.WriteLine("(mr) Borrar Memoria");
            Console.WriteLine("e Para salir \n");
            opcion = Console.ReadLine();


            Console.WriteLine("Ingrese la primera cantidad");
            cantidad1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda cantidad");
            cantidad2 = Console.ReadLine();


            switch (operacion)
            {

                case "+":
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
                    String o = cantidad1 + "+" + cantidad2;
                    MemoriaData data = new MemoriaData(DateTime.Now.ToString(), o, resultado.ToString());
                    memoria.GuardarMemoria(data);
                    resultado = 0;
                    break;

                case "-":
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

                case "*":
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

                case "/":
                    Console.WriteLine("El resultado de la suma es:");
                    resultado = cantidad1 / cantidad2;
                    Console.WriteLine("{0} / {1} = {2}", cantidad1, cantidad2, resultado);
                    Console.WriteLine("¿Desea utilizar el resultado para otra operacion? si/no");
                    continuar2 = Console.ReadLine();
                    _ = continuar2 == "si";
                    Console.WriteLine("El resultado anterior es:" + resultado + "\n");
                    Console.WriteLine("Agregue un nuevo dato para sumar");
                    resultado1 = (Console.ReadLine());
                    resultado2 = int.Parse;
                    resultado2 = resultado / resultado1;
                    Console.WriteLine("El resultado es:" + resultado2 + "\n");
                    break;


                case "m":
                    Console.WriteLine("Accediendo a Memoria \n");
                    Console.WriteLine("-----------------\n");
                    memoria.multidimensional();
                    String key = Console.ReadLine();
                    //Console.WriteLine(data.ToString());
                    // Elegir la opcion de resultado en nuestra memoria 
                    // y reutilizarla en alguna operación.
                    // 1. Crear metodo que nos regrese el resultado seleccionado.
                    resultado = memoria.GetMemoriaData(key);
                    // 2. Utilizar el resultado en una nueva operación.
                    Console.WriteLine(resultado);
                    // 3. Guardar la nueva operación en nuestra db.json.
                    // memoria.GuardarMemoria();
                    break;

                case "mr":
                    Console.WriteLine("Memoria Temporal Reiniciada! \n");
                    resultado = 0;
                    break;

                case "e":
                    Console.WriteLine("-----------------\n");
                    Console.WriteLine("Cerrando CalculApp! \n");
                    close_app = false;
                    break;

                default:
                    Console.WriteLine("Opción desconocida: {0}, intenta de nuevo \n", opcion);
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

                }
            }
        
