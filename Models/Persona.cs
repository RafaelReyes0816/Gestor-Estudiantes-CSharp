// Representa una persona en el sistema
public abstract class Persona
{
    public string Nombre { get; set; } = string.Empty;
    public int Edad { get; set; }
    public abstract string ObtenerInfo();
}