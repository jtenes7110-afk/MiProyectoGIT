using System;
using System.Collections.Generic;

namespace MiProyectoGIT
{
    class Program
    {
        // Lista compartida de tareas
        static List<Tarea> tareas = new List<Tarea>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE GESTIÓN DE TAREAS ===");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Guardar / Cargar tareas");
                Console.WriteLine("6. Editar tarea (extra)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        AgregarTarea();
                        break;
                    case 2:
                        ListarTareas();
                        break;
                    case 3:
                        CompletarTarea();
                        break;
                    case 4:
                        EliminarTarea();
                        break;
                    case 5:
                        GuardarOCargarTareas();
                        break;
                    case 6:
                        EditarTarea();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }

        // ===== FUNCIONES A DESARROLLAR POR EL EQUIPO =====

        static void AgregarTarea()
        {
            // TODO: Implementar (Compañero Melany)
            Console.WriteLine("Función AgregarTarea pendiente.");
        }

        static void ListarTareas()
        {
            // TODO: Implementar (Compañero Jima)
            Console.WriteLine("Función ListarTareas pendiente.");
        }

        static void CompletarTarea()
        {
            // TODO: Implementar (Compañero Liss)
            Console.WriteLine("Función CompletarTarea pendiente.");
        }

        static void EliminarTarea()
        {
            // TODO: Implementar (Compañero Mayra)
            Console.WriteLine("Función EliminarTarea pendiente.");
        }

        static void GuardarOCargarTareas()
        {
            // TODO: Implementar (Compañero Richard)
            Console.WriteLine("Función GuardarOCargarTareas pendiente.");
        }

        static void EditarTarea()
        {
            // TODO: Implementar 
            Console.WriteLine("Función EditarTarea pendiente.");
        }
    }

    // ===== CLASE BASE =====
    class Tarea
    {
        public string Titulo { get; set; }
        public bool Completada { get; set; }
    }
}