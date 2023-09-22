using Practicas7_9;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Arreglo array = new Arreglo();
            do
            {
                Console.Clear();
                PrintMenu();
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        array.CountCeros();
                        break;
                    case 2:
                        array.EsCuadroMagico();
                        break;
                    case 3:
                        array.OperarMatriz();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa....");
                        Thread.Sleep(3000);
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Escriba una opción valida");
                        Thread.Sleep(1500);
                        break;

                };

            } while (!exit);

        }

        static void PrintMenu()
        {

            Console.WriteLine("Bienvenido Elija la opción que desea: ");
            Console.WriteLine("1-Practica 7(Buscador de 0)\n2-Practica 8(Cuadro mágico)\n" +
                "3-Practica 9(Operaciones de matriz)\n4-Salir");
        }
    }
}