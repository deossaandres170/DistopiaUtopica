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

    static void RegistrarUsuario ()
    {
        Console.WriteLine("Has seleccionado: Registrar Usuario");
    }

    static void ListarUsuarios ()
    {
        Console.WriteLine("Has seleccionado: Listar Usuarios");
    }

    static void VerdDetalleUsuarioPorID ()
    {
        Console.WriteLine("Has seleccionado:  Ver detalle de usuario (por ID/ documento) ");
    }

    static void EditarNombre ()
    {
        Console.WriteLine("Has seleccionado: Editar nombre ");
    }

    static void EditarContacto ()
    {
        Console.WriteLine("Has seleccionado: Editar contacto ");
    }

    static void ActivarDesactivar ()
    {
        Console.WriteLine("Has seleccionado: Activar/Desacticar ");
    }

    static void EliminarUsuario ()
    {
        Console.WriteLine("Has seleccionado:  Eliminar usuario ");
    }

    static void CrearPrestamo ()
    {
        Console.WriteLine("Has seleccionado:  Crear prestamo ");
    }

    static void PrestamosListarTodos ()
    {
        Console.WriteLine("Has seleccionado:  Listar todos los  prestamos ");
    }

    static void PrestamosListarActivos ()
    {
        Console.WriteLine("Has seleccionado:  Listar  los  prestamos activos  ");
    }

    static void PreestamosListarCerrados ()
    {
        Console.WriteLine("Has seleccionado:  Listar  los  prestamos cerrados o (devueltos)");
    }

    static void RegistrarDevolucion ()
    {
        Console.WriteLine("Has seleccionado:  Registrar devolución ");
    }

    static void ElliminarPrestamo ()
    {
        Console.WriteLine("Has seleccionado: Eliminar prestamos ");
    }

    static void VerDetallePrestamoPorID ()
    {
        Console.WriteLine("Has seleccionado:  Ver detalle de prestamo por (ID) ");
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

                                            ListarTodos();
                                            break;

                                        case 3:

                                            ListarDisponibles();
                                            break;

                                        case 4:

                                            ListarLibrosPrestados();
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

                    do
                    {
                        Console.WriteLine("\n--- MENÚ USUARIOS ---");
                        Console.WriteLine("0. Volver Al Menú Anterior");
                        Console.WriteLine("1. Registrar usuario");
                        Console.WriteLine("2. Listar usuarios");
                        Console.WriteLine("3. Ver detalle de usuario (por ID/ documento)");
                        Console.WriteLine("4. Actualizar usuario");
                        Console.WriteLine("5. Eliminar usuario");
                        Console.Write("Selecciona una opción: ");

                        Opcion = Convert.ToInt32(Console.ReadLine());

                        switch (Opcion)
                        {
                            case 0:

                                MensajeVolverMenuAnterior ();
                                break;

                            case 1:

                                RegistrarUsuario ();
                                break;

                            case 2:

                                ListarUsuarios ();
                                break;

                            case 3:

                                VerdDetalleUsuarioPorID();
                                break;

                            case 4:

                                Console.WriteLine("Has seleccionado: Actualizar Usuario");

                                do
                                {
                                    Console.WriteLine("\n--- ACTUALIZAR USUARIO ---");
                                    Console.WriteLine("1. Volver Al Menú Anterior");
                                    Console.WriteLine("2. Editar Nombre");
                                    Console.WriteLine("3. Editar Contacto");
                                    Console.WriteLine("4. Activar / Desactivar ");
                                    Console.Write("Selecciona una opción: ");

                                    Opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (Opcion)
                                    {
                                        case 1:

                                            MensajeVolverMenuAnterior ();
                                            break;

                                        case 2:

                                            EditarNombre ();
                                            break;

                                        case 3:

                                            EditarContacto ();
                                            break;

                                        case 4:

                                            ActivarDesactivar ();
                                            break;

                                        default:

                                            Default();
                                            break;

                                    }

                                } while (Opcion != 1);
                                break;

                            case 5:

                                EliminarUsuario ();

                                Console.Write("¿Estás seguro de que deseas eliminar al usuario? (s/n): ");

                                break;

                            default:

                                Default();
                                break;

                        }
                    } while (Opcion != 0);

                    break;

                case 3:

                    Console.WriteLine("Has seleccionado: Prestamos");

                    do
                    {
                        Console.WriteLine("\n--- MENÚ PRESTAMOS ---");
                        Console.WriteLine("0. Volver Al Menú Anterior");
                        Console.WriteLine("1. Crear Préstamo");
                        Console.WriteLine("2. Listar Préstamo");
                        Console.WriteLine("3. Ver detalle del Préstamo (por ID)");
                        Console.WriteLine("4. Registrar Devolución");
                        Console.WriteLine("5. Eliminar Préstamo");
                        Console.Write("Selecciona una opción: ");

                        Opcion = Convert.ToInt32(Console.ReadLine());

                        switch (Opcion)
                        {
                            case 0:

                                MensajeVolverMenuAnterior ();
                                break;

                            case 1:

                                CrearPrestamo ();
                                break;

                            case 2:

                                Console.WriteLine("Has seleccionado: Listar Préstamo");

                                do
                                {
                                    Console.WriteLine("\n--- LISTAR PRESTAMO ---");
                                    Console.WriteLine("1. Volver Al Menú Anterior");
                                    Console.WriteLine("2. Listar Todos");
                                    Console.WriteLine("3. Listar Activos");
                                    Console.WriteLine("4. Listar Cerrados (devueltos) ");
                                    Console.Write("Selecciona una opción: ");

                                    Opcion = Convert.ToInt32(Console.ReadLine());

                                    switch (Opcion)
                                    {
                                        case 1:

                                            MensajeVolverMenuAnterior ();
                                            break;

                                        case 2:

                                            PrestamosListarTodos ();
                                            break;

                                        case 3:

                                            PrestamosListarActivos ();
                                            break;

                                        case 4:

                                            PreestamosListarCerrados ();
                                            break;

                                        default:

                                            Default();
                                            break;

                                    }

                                } while (Opcion != 1);

                                
                                break;

                            case 3:

                                VerDetallePrestamoPorID();
                                break;

                            case 4:

                                RegistrarDevolucion ();

                                break;

                            case 5:

                                ElliminarPrestamo ();

                                Console.Write("¿Estás seguro de que deseas eliminar el prestamo? (s/n): ");

                                break;

                            default:

                                Default();
                                break;

                        }
                    } while (Opcion != 0);

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

