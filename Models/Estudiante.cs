// Representa a un estudiante, hereda de Persona
public class Estudiante : Persona
{
    // Calificaciones del estudiante
    public double[] Calificaciones { get; set; } = Array.Empty<double>();

    // Devuelve información formateada del estudiante
    public override string ObtenerInfo() => 
        $"Estudiante: {Nombre}, Edad: {Edad}, Promedio: {CalcularPromedio():F2}";

    // Calcula el promedio de calificaciones
    public double CalcularPromedio() => 
        Calificaciones.Length == 0 ? 0 : Calificaciones.Average();
}