// Representa a un estudiante y su información académica
public class Estudiante : Persona
{
    public double[] Calificaciones { get; set; } = Array.Empty<double>();

    public override string ObtenerInfo() => 
        $"Estudiante: {Nombre}, Edad: {Edad}, Promedio: {CalcularPromedio():F2}";

    public double CalcularPromedio() => 
        Calificaciones.Length == 0 ? 0 : Calificaciones.Average();
}