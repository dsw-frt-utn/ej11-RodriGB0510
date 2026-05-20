using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> _alumnos = [];
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        _alumnos.Add(legajo, alumno);
    }
    public Alumno? BuscarAlumno(int legajo)
    {
        return _alumnos.GetValueOrDefault(legajo);
    }
    public Dictionary<int, Alumno> ObtenerAlumnos()
    {
        return _alumnos;
    }
    public void EliminarAlumno(int legajo)
    {
        _alumnos.Remove(legajo);
    }
}