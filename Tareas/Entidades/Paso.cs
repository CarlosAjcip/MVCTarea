namespace Tareas.Entidades
{
    public class Paso
    {
        public Guid Id { get; set; }
        public int Tarea_Id { get; set; }
        public Tarea Tarea { get; set; }
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
        public int Orden { get; set; }


    }
}
