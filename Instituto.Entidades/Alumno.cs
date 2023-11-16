namespace Instituto.Entidades
{
    public class Alumno : EntityBase
    {
        public string Nombre { get; set; } = default!;
        public string Correo { get; set; } = default!;
        public int Edad { get; set; }
    }
}