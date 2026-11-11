using System;
using system_books.Models;

namespace system_books
{
    class Program
    {
        static void Main(string[] args)
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

        static void RegistrarUsuario()
        {
            Console.WriteLine("Has seleccionado: Registrar Usuario");
        }

        static void ListarUsuarios()
        {
            Console.WriteLine("Has seleccionado: Listar Usuarios");
        }

        static void VerdDetalleUsuarioPorID()
        {
            Console.WriteLine("Has seleccionado:  Ver detalle de usuario (por ID/ documento) ");
        }

        static void EditarNombre()
        {
            Console.WriteLine("Has seleccionado: Editar nombre ");
        }

        static void EditarContacto()
        {
            Console.WriteLine("Has seleccionado: Editar contacto ");
        }

        static void ActivarDesactivar()
        {
            Console.WriteLine("Has seleccionado: Activar/Desacticar ");
        }

        static void EliminarUsuario()
        {
            Console.WriteLine("Has seleccionado:  Eliminar usuario ");
        }

        static void CrearPrestamo()
        {
            Console.WriteLine("Has seleccionado:  Crear prestamo ");
        }

        static void PrestamosListarTodos()
        {
            Console.WriteLine("Has seleccionado:  Listar todos los  prestamos ");
        }

        static void PrestamosListarActivos()
        {
            Console.WriteLine("Has seleccionado:  Listar  los  prestamos activos  ");
        }

        static void PreestamosListarCerrados()
        {
            Console.WriteLine("Has seleccionado:  Listar  los  prestamos cerrados o (devueltos)");
        }

        static void RegistrarDevolucion()
        {
            Console.WriteLine("Has seleccionado:  Registrar devolución ");
        }

        static void ElliminarPrestamo()
        {
            Console.WriteLine("Has seleccionado: Eliminar prestamos ");
        }

        static void VerDetallePrestamoPorID()
        {
            Console.WriteLine("Has seleccionado:  Ver detalle de prestamo por (ID) ");
        }

        static void BuscarLibro()
        {
            Console.WriteLine("Has seleccionado: Buscar libro");
        }

        static void BuscarUsuario()
        {
            Console.WriteLine("Has seleccionado: Buscar usuario");
        }

        static void Reportes()
        {
            Console.WriteLine("Has seleccionado: Reportes");
        }

        static void GuardarDatos()
        {
            Console.WriteLine("Has seleccionado: Guardar datos");
        }

        static void CargarDatos()
        {
            Console.WriteLine("Has seleccionado: Cargar datos");
        }

        static void ReiniciarDatos()
        {
            Console.WriteLine("Has seleccionado: Reiniciar datos ");
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
                Console.WriteLine("7. Ejecutar Pruebas de Objetos (Evidencia EV07)");
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

                                    string ConfirmacionEliminarLibro = Console.ReadLine();

                                    if (ConfirmacionEliminarLibro.Trim().ToLower() == "s")
                                    {
                                        Console.WriteLine("Eliminación de libro exitosa");
                                        break;
                                    }
                                    else if (ConfirmacionEliminarLibro.Trim().ToLower() == "n")
                                    {
                                        Console.WriteLine("Se cancelo la eliminación del libro");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción no válida. Regresando al menú...");

                                        Opcion = 1;

                                        break;
                                    }


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

                                    MensajeVolverMenuAnterior();
                                    break;

                                case 1:

                                    RegistrarUsuario();
                                    break;

                                case 2:

                                    ListarUsuarios();
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

                                                MensajeVolverMenuAnterior();
                                                break;

                                            case 2:

                                                EditarNombre();
                                                break;

                                            case 3:

                                                EditarContacto();
                                                break;

                                            case 4:

                                                ActivarDesactivar();
                                                break;

                                            default:

                                                Default();
                                                break;

                                        }

                                    } while (Opcion != 1);
                                    break;

                                case 5:

                                    EliminarUsuario();

                                    Console.Write("¿Estás seguro de que deseas eliminar al usuario? (s/n): ");
                                    string ConfirmacionEliminarUsuario = Console.ReadLine();

                                    if (ConfirmacionEliminarUsuario.Trim().ToLower() == "s")
                                    {
                                        Console.WriteLine("Eliminación de usuario exitosa");
                                        break;
                                    }
                                    else if (ConfirmacionEliminarUsuario.Trim().ToLower() == "n")
                                    {
                                        Console.WriteLine("Se cancelo la eliminación del usuario");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción no válida. Regresando al menú...");

                                        Opcion = 1;

                                        break;
                                    }

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

                                    MensajeVolverMenuAnterior();
                                    break;

                                case 1:

                                    CrearPrestamo();
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

                                                MensajeVolverMenuAnterior();
                                                break;

                                            case 2:

                                                PrestamosListarTodos();
                                                break;

                                            case 3:

                                                PrestamosListarActivos();
                                                break;

                                            case 4:

                                                PreestamosListarCerrados();
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

                                    RegistrarDevolucion();

                                    break;

                                case 5:

                                    Console.Write("¿Estás seguro de que deseas eliminar el prestamo? (s/n): ");
                                    string ConfirmacionEliminacionPrestamo = Console.ReadLine();

                                    if (ConfirmacionEliminacionPrestamo.Trim().ToLower() == "s")
                                    {
                                        Console.WriteLine("EL prestamo se elimino con exito...");
                                        break;
                                    }
                                    else if (ConfirmacionEliminacionPrestamo.Trim().ToLower() == "n")
                                    {
                                        Console.WriteLine("Se cancelo la eliminación de el prestamo...");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción no válida. Regresando al menú...");

                                        Opcion = 1;

                                        break;
                                    }


                                    ElliminarPrestamo();

                                    break;

                                default:

                                    Default();
                                    break;

                            }
                        } while (Opcion != 0);

                        break;

                    case 4:

                        Console.WriteLine("Has seleccionado: Búsquedas y reportes");

                        do
                        {
                            Console.WriteLine("\n--- BÚSQUEDAS Y REPORTES ---");
                            Console.WriteLine("0. Volver Al Menú Anterior");
                            Console.WriteLine("1. Buscar Libro");
                            Console.WriteLine("2. Buscar usuario");
                            Console.WriteLine("3. Reportes");
                            Console.Write("Selecciona una opción: ");

                            Opcion = Convert.ToInt32(Console.ReadLine());

                            switch (Opcion)
                            {
                                case 0:

                                    MensajeVolverMenuAnterior();
                                    break;

                                case 1:

                                    BuscarLibro();
                                    break;

                                case 2:

                                    BuscarUsuario();
                                    break;

                                case 3:

                                    Reportes();
                                    break;

                                default:

                                    Default();
                                    break;

                            }

                        } while (Opcion != 0);

                        break;

                    case 5:

                        Console.WriteLine("Has seleccionado: Guardar / Cargar datos");

                        do
                        {
                            Console.WriteLine("\n--- GUARDAR Y CARGAR DATOS ---");
                            Console.WriteLine("0. Volver Al Menú Anterior");
                            Console.WriteLine("1. Guardar Datos");
                            Console.WriteLine("2. Cargar Datos");
                            Console.WriteLine("3. Reiniciar datos");
                            Console.Write("Selecciona una opción: ");

                            Opcion = Convert.ToInt32(Console.ReadLine());

                            switch (Opcion)
                            {
                                case 0:

                                    MensajeVolverMenuAnterior();
                                    break;

                                case 1:

                                    GuardarDatos();
                                    break;

                                case 2:

                                    CargarDatos();
                                    break;

                                case 3:

                                    Console.Write("¿Estás seguro de que deseas Reiniciar datos (vaciar todo)? (s/n): ");

                                    string ConfirmacionVaciar = Console.ReadLine();

                                    if (ConfirmacionVaciar.Trim().ToLower() == "s")
                                    {
                                        Console.WriteLine("Vaciado Exitoso...");
                                        break;
                                    }
                                    else if (ConfirmacionVaciar.Trim().ToLower() == "n")
                                    {
                                        Console.WriteLine("Se cancelo el vaciado...");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opción no válida. Regresando al menú...");

                                        Opcion = 1;

                                        break;
                                    }


                                    ReiniciarDatos();

                                    break;

                                default:

                                    Default();
                                    break;

                            }

                        } while (Opcion != 0);

                        break;

                    case 6:

                        Console.Write("¿Deseas guardar los cambios antes de  salir ? (s/n): ");

                        string ConfirmacionSalir = Console.ReadLine();

                        if (ConfirmacionSalir.Trim().ToLower() == "s")
                        {
                            Console.WriteLine("Guardado exitoso...");
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }
                        else if (ConfirmacionSalir.Trim().ToLower() == "n")
                        {
                            Console.WriteLine(" No se guardaron los cambios de la aplicación...");
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida. Regresando al menú...");

                            Opcion = 1;

                            break;
                        }

                    case 7:

                        // Llamamos al método con los objetos de prueba de la EV07
                        EjecutarPruebasEV07();
                        break;

                    default:

                        Default();
                        break;

                    

                }
            } while (Opcion != 6);
        }

        // --- MÉTODO CON LAS PRUEBAS OBLIGATORIAS DE LA EV07 ---
        static void EjecutarPruebasEV07()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("     PRUEBAS DE OBJETOS Y MODELOS (EV07)          ");
            Console.WriteLine("==================================================\n");

            // 1. Crear 2 Libros
            Libro libro1 = new Libro("978-0143127741", "Cien años de soledad", "Gabriel García Márquez", 1967);
            Libro libro2 = new Libro("978-0451524935", "1984", "George Orwell", 1949);

            // 2. Crear 2 Usuarios
            Usuario usuario1 = new Usuario("10203040", "Ana María Gómez", "ana.gomez@email.com");
            Usuario usuario2 = new Usuario("50607080", "Carlos Pérez", "carlos.perez@email.com");

            // 3. Crear 1 Préstamo
            Prestamo prestamo1 = new Prestamo(1, libro1, usuario1);

            // --- MOSTRAR INFORMACIÓN EN CONSOLA ---
            Console.WriteLine("--- 1. RESÚMENES ---");
            Console.WriteLine(libro1.ResumenCorto());
            Console.WriteLine(libro2.ResumenCorto());
            Console.WriteLine(usuario1.ResumenCorto());
            Console.WriteLine(usuario2.ResumenCorto());
            Console.WriteLine(prestamo1.ResumenCorto());

            Console.WriteLine("\n--- 2. DETALLES COMPLETOS ---");
            Console.WriteLine(libro1.DetalleCompleto());
            Console.WriteLine(libro2.DetalleCompleto());
            Console.WriteLine(usuario1.DetalleCompleto());
            Console.WriteLine(usuario2.DetalleCompleto());
            Console.WriteLine(prestamo1.DetalleCompleto());

            Console.WriteLine("\n--- 3. VALIDACIONES ESPECÍFICAS ---");
            Console.WriteLine($"¿Libro 1 está disponible? -> {libro1.Disponible}");
            Console.WriteLine($"¿Libro 2 está disponible? -> {libro2.Disponible}");
            Console.WriteLine($"¿Usuario 1 está activo? -> {usuario1.Activo}");
            Console.WriteLine($"Estado inicial del Préstamo -> {prestamo1.Estado}");
            Console.WriteLine($"¿El préstamo está vencido? -> {prestamo1.EstaVencido()}");
            Console.WriteLine($"Días transcurridos del préstamo -> {prestamo1.DiasTranscurridos()} días");

            Console.WriteLine("\n==================================================");
        }

    }
}
