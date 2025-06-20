namespace ToDoEspacio
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string? Descripcion { get; set; }
        public int Duracion { get; set; } 
        public Tarea(int id, string desc, int duracion)
        {
            TareaID=id;
            Descripcion=desc;
            Duracion=duracion;
        }
    
        
    }
    
}