// Implementación de los servicios de la escuela
public class EscuelaService : IEscuelaService
{
    // Lista interna de estudiantes
    private List<Estudiante> _estudiantes = new List<Estudiante>();

    // Agrega un estudiante a la lista
    public void AgregarEstudiante(Estudiante estudiante)
    {
        if (estudiante == null)
        {
            Console.WriteLine("No se puede agregar un estudiante nulo.");
            return;
        }
        _estudiantes.Add(estudiante);
    }

    // Muestra todos los estudiantes registrados
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

    // Busca estudiantes cuyo nombre contenga el texto dado (ignora mayúsculas/minúsculas)
    public void BuscarEstudiante(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("Debe ingresar un nombre válido para buscar.");
            return;
        }
        BuscarEstudiante(nombre, 0);
    }

    // Método recursivo interno para buscar estudiantes por nombre
    private void BuscarEstudiante(string nombre, int index)
    {
        if (index >= _estudiantes.Count) return;

        if (_estudiantes[index].Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine(_estudiantes[index].ObtenerInfo());

        BuscarEstudiante(nombre, index + 1);
    }

    // Borra todos los estudiantes cuyo nombre coincida exactamente (ignora mayúsculas/minúsculas)
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

    // Indica si la lista de estudiantes está vacía
    public bool EstaVacia() => _estudiantes.Count == 0;
}