// Clase base abstracta para personas en el sistema
public abstract class Persona
{
    // Nombre de la persona (tambien puede ir el apellido)
    public string Nombre { get; set; } = string.Empty;

    // Edad de la persona
    public int Edad { get; set; }

    // Método que debe implementar cada subclase para mostrar información
    public abstract string ObtenerInfo();
}