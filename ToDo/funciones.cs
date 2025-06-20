namespace ToDoEspacio
{
    public static class Funciones
    {
        public static void buscarTarea(List<Tarea> lista)
        {
            string cadSalida = "";
            Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar:");
            string? descripcion = Console.ReadLine();

            for (int i = 0; i < lista.Count; i++)
            {
                string descTarea = lista[i].Descripcion;
                bool encontrada = false;

                for (int j = 0; j <= descTarea.Length - descripcion.Length; j++)
                {
                    int k = 0;

                    while (k < descripcion.Length && descTarea[j + k] == descripcion[k])
                    {
                        k++;
                    }

                    if (k == descripcion.Length)
                    {
                        encontrada = true;
                        break;
                    }
                }

                if (encontrada)
                {
                    cadSalida = $"ID: {lista[i].TareaID}\nDescripcion: {lista[i].Descripcion}\nDuracion: {lista[i].Duracion}";
                    Console.WriteLine(cadSalida);
                }
            }

            if (cadSalida == "")
            {
                Console.WriteLine("No hay tarea con esa descripcion.");
            }
        }

        public static void tareaRealizada(List<Tarea> realizadas, List<Tarea> pendientes)
        {
            Console.WriteLine("Ingrese el ID de la tarea que ya realizó:");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < pendientes.Count; i++)
            {
                if (pendientes[i].TareaID == id)
                {
                    realizadas.Add(pendientes[i]);
                    pendientes.RemoveAt(i);
                    Console.WriteLine("Tarea marcada como realizada.");
                    return;
                }
            }

            Console.WriteLine("No se encontró una tarea con ese ID.");
        }
    }
}
