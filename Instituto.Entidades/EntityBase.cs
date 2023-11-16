namespace Instituto.Entidades;

public class EntityBase
{
    public int Id { get; set; }
    public bool Estado { get; set; }

    protected EntityBase()
    {
        Estado = true;
    }
}