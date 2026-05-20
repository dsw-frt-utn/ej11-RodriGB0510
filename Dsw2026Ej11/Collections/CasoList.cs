using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private readonly List<Alumno> _alumnos = [];
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }
    public List<Alumno> ObtenerAlumnos()
    {
        return _alumnos;
    }
    public Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }
    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }
    public void EliminarAlumnoEn(int indice)
    {
        if (indice >= 0 && indice < _alumnos.Count)
        {
            _alumnos.RemoveAt(indice);
        }
    }
}