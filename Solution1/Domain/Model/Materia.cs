namespace Domain.Model
{
    public class Materia
    {
        public int Id { get; set; }
        public  string Descripcion { get; set; }
        public  int HSSemanales { get; set; }
        public  int HSTotales { get; set; }  
        public  Plan Plan { get; set; }
        public string Nombre { get; set; }
    }
}
