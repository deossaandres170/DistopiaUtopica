using System;

class Program
{
    static void Main()
    {
        MenuPrincipal();
    }

    static void MensajeVolverMenuAnterior()
    {
        Console.WriteLine("Regresando Al Menú Anterior...");
    }

    static void Default()
    {
        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
    }

    static void RegistrarLibro()
    {
        Console.WriteLine("Has seleccionado: Registrar Libro");
    }

    static void ListarTodos()
    {
        Console.WriteLine("Has seleccionado: Listar todos");
    }

    static void ListarDisponibles()
    {
        Console.WriteLine("Has seleccionado: Listar disponibles");
    }

    static void ListarLibrosPrestados()
    {
        Console.WriteLine("Has seleccionado: Listar prestamos");
    }

    static void VerDetallePorID()
    {
        Console.WriteLine("Has seleccionado: Ver detalle (por ID/ISBN)");
    }

    static void EditarTitulo()
    {
        Console.WriteLine("Has seleccionado: Editar Título");
    }

    static void EditarAutor()
    {
        Console.WriteLine("Has seleccionado: Editar Autor");
    }

    static void EditarAño()
    {
        Console.WriteLine("Has seleccionado: Editar Año / Categoría");
    }

    static void EliminarLibro()
    {
        Console.WriteLine("Has seleccionado: Eliminar libro");
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

                    do
                    {
                        Console.WriteLine("\n--- MENÚ LIBROS ---");
                        Console.WriteLine("0. Volver Al Menú Anterior");
                        Console.WriteLine("1. Registrar Libro");
                        Console.WriteLine("2. Listar Libros");
                        Console.WriteLine("3. Ver detalle (por ID/ISBN)");
                        Console.WriteLine("4. Actualizar libro");
                        Console.WriteLine("5. Eliminar libro");
                        Console.Write("Selecciona una opción: ");

                        Opcion = Convert.ToInt32(Console.ReadLine());

                        switch (Opcion)
                        {
                            case 0:

                                MensajeVolverMenuAnterior();
                                break;

                            case 1:

                                RegistrarLibro();
                                break;

                            case 2:

                                Console.WriteLine("Has seleccionado: Listar Libros");

                                do
                                {
                                    Console.WriteLine("\n--- LISTAR LIBROS ---");
                                    Console.WriteLine("1. Volver Al Menú Anterior");
                                    Console.WriteLine("2. Listar todos");
                                    Console.WriteLine("3. Listar disponibles");
                                    Console.WriteLine("4. Listar prestados");
                                    Console.Write("Selecciona una opción: ");

                                    Opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (Opcion)
                                    {
                                        case 1:

                                            Console.WriteLine("Regresando Al Menú Anterior...");
                                            break;

                                        case 2:

                                            ListarTodos ();
                                            break;

                                        case 3:

                                            ListarDisponibles ();
                                            break;

                                        case 4:

                                            ListarLibrosPrestados ();
                                            break;

                                        default:

                                            Default();
                                            break;

                                    }

                                } while (Opcion != 1);
                                break;

                            case 3:

                                VerDetallePorID();
                                break;

                            case 4:

                                Console.WriteLine("Has seleccionado: Actualizar libro");

                                do
                                {
                                    Console.WriteLine("\n--- ACTUALIZAR LIBRO ---");
                                    Console.WriteLine("1. Volver Al Menú Anterior");
                                    Console.WriteLine("2. Editar Título");
                                    Console.WriteLine("3. Editar Autor");
                                    Console.WriteLine("4. Editar Año / Categoria");
                                    Console.Write("Selecciona una opción: ");

                                    Opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (Opcion)
                                    {
                                        case 1:

                                            MensajeVolverMenuAnterior();
                                            break;

                                        case 2:

                                            EditarTitulo();
                                            break;

                                        case 3:

                                            EditarAutor();
                                            break;

                                        case 4:

                                            EditarAño();
                                            break;

                                        default:

                                            Default();
                                            break;

                                    }

                                } while (Opcion != 1);
                                break;

                            case 5:

                                EliminarLibro();

                                Console.Write("¿Estás seguro de que deseas eliminar el libro? (s/n): ");
                                
                                break;
                                
                            default:

                                Default();
                                break;

                        }
                    } while (Opcion != 0);

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

                    Default();
                    break;

            }
        } while (Opcion != 6);
    }
}

