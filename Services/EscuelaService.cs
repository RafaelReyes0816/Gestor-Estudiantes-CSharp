// Implementa la gestión de estudiantes
public class EscuelaService : IEscuelaService
{
    private List<Estudiante> _estudiantes = new List<Estudiante>();

    public void AgregarEstudiante(Estudiante estudiante)
    {
        if (estudiante == null)
        {
            Console.WriteLine("No se puede agregar un estudiante nulo.");
            return;
        }
        _estudiantes.Add(estudiante);
    }

    public void MostrarEstudiantes()
    {
        if (_estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
            return;
        }
        foreach (var estudiante in _estudiantes)
            Console.WriteLine(estudiante.ObtenerInfo());
    }

    public bool BuscarEstudiante(string nombre)
    {
        var encontrados = _estudiantes.Where(e => e.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        if (encontrados.Count == 0)
            return false;
        foreach (var e in encontrados)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Calificaciones: {string.Join(", ", e.Calificaciones)}");
        }
        return true;
    }

    public bool BorrarEstudiante(string nombre)
    {
        var encontrados = _estudiantes
            .Where(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (encontrados.Count == 0)
            return false;

        foreach (var estudiante in encontrados)
            _estudiantes.Remove(estudiante);

        return true;
    }

    public bool EstaVacia() => _estudiantes.Count == 0;
}