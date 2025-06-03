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