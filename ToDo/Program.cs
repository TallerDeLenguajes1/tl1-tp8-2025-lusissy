using ToDoEspacio;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numeroTareas = rnd.Next(3, 6); // te da al menos 3 tareas (antes podía dar 0)
        int indice, duracion;
        string[] descripcion = { "Limpiar", "Correr", "Estudiar", "Lavar" };

        List<Tarea> tPendientes = new List<Tarea>();
        List<Tarea> tRealizadas = new List<Tarea>();

        for (int i = 0; i < numeroTareas; i++)
        {
            indice = rnd.Next(0, descripcion.Length);
            duracion = rnd.Next(10, 100);
            Tarea pendiente = new Tarea(1000 + i, descripcion[indice], duracion);
            tPendientes.Add(pendiente);
        }

        int opcion;
        do
        {
            Console.WriteLine("\nIngrese una opcion:");
            Console.WriteLine("1 - Marcar tarea realizada");
            Console.WriteLine("2 - Buscar tareas pendientes por descripción");
            Console.WriteLine("3 - Mostrar listado de todas las tareas");
            Console.WriteLine("4 - Salir\n");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Funciones.tareaRealizada(tRealizadas, tPendientes);
                    break;

                case 2:
                    Funciones.buscarTarea(tPendientes);
                    break;

                case 3:
                    Console.WriteLine("Tareas pendientes:");
                    for (int i = 0; i < tPendientes.Count; i++)
                    {
                        Console.WriteLine("ID:" + tPendientes[i].TareaID + ", Descripcion:" + tPendientes[i].Descripcion);
                    }
                    Console.WriteLine("Tareas realizadas:");
                    for (int i = 0; i < tRealizadas.Count; i++)
                    {
                        Console.WriteLine("ID:" + tRealizadas[i].TareaID + ", Descripcion:" + tRealizadas[i].Descripcion);
                    }
                    break;

                case 4:
                    Console.WriteLine("Fin del Programa.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente otra vez.");
                    break;
            }

        } while (opcion != 4);
    }
}
