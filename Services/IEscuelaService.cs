// Servicios de la escuela
public interface IEscuelaService
{
    void AgregarEstudiante(Estudiante estudiante);
    void MostrarEstudiantes();
    bool BuscarEstudiante(string nombre);
    bool BorrarEstudiante(string nombre);    
}