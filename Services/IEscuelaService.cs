// Interfaz que define los servicios de la escuela
public interface IEscuelaService
{
    // Agrega un estudiante
    void AgregarEstudiante(Estudiante estudiante);

    // Muestra todos los estudiantes
    void MostrarEstudiantes();

    // Busca estudiantes por nombre
    void BuscarEstudiante(string nombre);

    // Borra estudiantes por nombre
    bool BorrarEstudiante(string nombre);
}