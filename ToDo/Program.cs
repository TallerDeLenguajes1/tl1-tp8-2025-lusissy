using ToDoEspacio;
Random rnd = new Random();
int numeroTareas=rnd.Next(3);
int indice, duracion;
string [] descripcion={"Limpiar", "Correr", "Estudiar", "Lavar"};

List<Tarea> tPendientes= new List<Tarea>();
List<Tarea> tRealizadas = new List<Tarea>();

for (int i = 0; i < numeroTareas; i++)
{
    indice= rnd.Next(0,3);
    duracion=rnd.Next(10,100);
    Tarea pendiente= new Tarea(1000+i, descripcion[indice], duracion);
    tPendientes.Add(pendiente);
}

int idRealizado;
Console.WriteLine("Escribe el id de la tarea ya realizada:");
string? realizado=Console.ReadLine();
int.TryParse(realizado, out idRealizado);

for (int j = 0; j < tPendientes.Count; j++)
{

    if (tPendientes[j].TareaID == idRealizado)
    {
        tRealizadas.Add(tPendientes[j]);
        tPendientes.RemoveAt(j);
        break;
    }
    tPendientes[j].MostrarDatos();
}
Console.WriteLine("Escribe la descripcion de la tarea a mostrar:");
string? descrp=Console.ReadLine();
for (int k = 0; k < tPendientes.Count; k++)
{
    if (tPendientes[k].Descripcion == descrp) 
    {
        tPendientes[k].MostrarDatos();
    }else
    {
        Console.WriteLine("No hay tareas por mostrar");
    }
}