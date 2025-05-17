var escuela = new EscuelaService();

// Muestra un título centrado y decorado en la consola
void MostrarTitulo(string titulo)
{
    Console.WriteLine(new string('=', 40));
    Console.WriteLine(titulo.PadLeft((40 + titulo.Length) / 2).PadRight(40));
    Console.WriteLine(new string('=', 40));
}

while (true)
{
    Console.Clear();
    // Menú principal de opciones
    MostrarTitulo("MENÚ PRINCIPAL");
    Console.WriteLine("1. Agregar estudiante");
    Console.WriteLine("2. Mostrar estudiantes");
    Console.WriteLine("3. Buscar");
    Console.WriteLine("4. Borrar estudiante");
    Console.WriteLine("5. Salir");
    Console.WriteLine(new string('-', 40));
    Console.Write("Seleccione una opción: ");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            MostrarTitulo("AGREGAR ESTUDIANTE");
            string nombre;
            // Solicita y valida el nombre
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine() ?? "";
                if (string.IsNullOrWhiteSpace(nombre))
                    Console.WriteLine("El nombre no puede estar vacío.");
            } while (string.IsNullOrWhiteSpace(nombre));

            int edad;
            // Solicita y valida la edad
            do
            {
                Console.Write("Edad: ");
                var edadInput = Console.ReadLine();
                if (!int.TryParse(edadInput, out edad) || edad < 0)
                {
                    Console.WriteLine("Edad inválida. Debe ser un número positivo.");
                    edad = -1;
                }
            } while (edad < 0);

            double[] calificaciones;
            // Solicita y valida las calificaciones (mínimo 2, máximo 6)
            while (true)
            {
                Console.Write("Calificaciones (mínimo 2, máximo 6, separadas por coma, ej: 90,80,75): ");
                var califInput = Console.ReadLine() ?? "";
                var califStrings = califInput.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                             .Take(6);
                calificaciones = califStrings
                    .Select(s => double.TryParse(s.Trim(), out double c) ? (double?)c : null)
                    .Where(c => c.HasValue)
                    .Select(c => c.GetValueOrDefault())
                    .ToArray();

                if (calificaciones.Length < 2)
                {
                    Console.WriteLine("Debe ingresar al menos dos calificaciones válidas.");
                }
                else
                {
                    break;
                }
            }

            // Agrega el estudiante a la lista
            escuela.AgregarEstudiante(new Estudiante
            {
                Nombre = nombre,
                Edad = edad,
                Calificaciones = calificaciones
            });
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("✅ Estudiante agregado con éxito.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            MostrarTitulo("LISTA DE ESTUDIANTES");
            escuela.MostrarEstudiantes();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            Console.Clear();
            MostrarTitulo("BUSCAR ESTUDIANTE");
            if (escuela.EstaVacia())
            {
                Console.WriteLine("No hay estudiantes registrados para buscar.");
                Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            Console.Write("Nombre a buscar: ");
            var nombreBuscar = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nombreBuscar))
            {
                bool encontrado = escuela.BuscarEstudiante(nombreBuscar);
                Console.WriteLine("----------------------------------------");
                if (!encontrado)
                {
                    Console.WriteLine($"No se encontró ningún estudiante con el nombre \"{nombreBuscar}\".");
                }
                else
                {
                    Console.WriteLine("Búsqueda finalizada.");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un nombre válido.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            Console.Clear();
            MostrarTitulo("BORRAR ESTUDIANTE");
            // Si no hay estudiantes, vuelve al menú
            if (escuela.EstaVacia())
            {
                Console.WriteLine("No hay estudiantes registrados para borrar.");
                Console.WriteLine("Presione cualquier tecla para volver al menú principal...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            Console.WriteLine("Estudiantes registrados:");
            escuela.MostrarEstudiantes();
            Console.WriteLine("----------------------------------------");
            // Pide el nombre completo para borrar
            Console.Write("Escriba el nombre completo del estudiante a borrar: ");
            var nombreBorrar = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nombreBorrar))
            {
                bool borrado = escuela.BorrarEstudiante(nombreBorrar);
                if (borrado)
                {
                    Console.WriteLine("✅ Estudiante(s) borrado(s) con éxito.");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún estudiante con ese nombre.");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un nombre válido.");
            }
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
        case "5":
            Console.Clear();
            MostrarTitulo("¡Hasta luego!");
            return;
        default:
            Console.WriteLine("Opción no válida.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}