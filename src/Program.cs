using System;

class Program
{
    static void Main()
    {
        MenuPrincipal();
    }

    static void MenuPrincipal()
    {
        int Opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");

            Opcion = Convert.ToInt32(Console.ReadLine());

            switch (Opcion)
            {
                case 1:

                    Console.WriteLine("Has seleccionado: Ver libros");
                    break;

                case 2:

                    Console.WriteLine("Has seleccionado: Ver usuarios");
                    break;

                case 3:

                    Console.WriteLine("Has seleccionado: Ver préstamos");
                    break;

                case 4:

                    Console.WriteLine("Has seleccionado: Búsquedas y reportes");
                    break;

                case 5:

                    Console.WriteLine("Has seleccionado: Guardar / Cargar datos");
                    break;

                case 6:

                    Console.WriteLine("Saliendo del programa...");
                    break; 

                default:

                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
                    
            }
        } while (Opcion != 6);
    }
}

