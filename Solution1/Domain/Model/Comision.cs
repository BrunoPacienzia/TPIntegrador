namespace Domain.Model
{
    public class Comision
    {
        public int Id { get; set; }
        public int AnioEspecialidad { get; set; }
        public string Descripcion { get; set; }
        public Plan Plan { get; set; }
    }
}
