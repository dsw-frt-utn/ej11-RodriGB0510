using Dsw2026Ej11.Domain;
using System.Globalization;
namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private readonly List<Libro> _libros = [];
    public Libro? GetPrimero()
    {
        return _libros.Where(libro => libro.Id == _libros.Min(primero => primero.Id)).Select(libro => libro).FirstOrDefault();
    }
    public Libro? GetUltimo()
    {
        return _libros.Where(libro => libro.Id == _libros.Max(ultimo => ultimo.Id)).Select(libro => libro).FirstOrDefault();
    }
    public decimal GetTotalPrecios()
    {
        return _libros.Sum(libro => libro.Precio);
    }
    public decimal GetPromedioPrecios()
    {
        return _libros.Average(libro => libro.Precio);
    }
    public List<Libro> GetListById()
    {
        return _libros.Where(libro => libro.Id > 15).ToList();
    }
    public List<string> GetLibros()
    {
        return _libros.Select(libro => $"{libro.Titulo}: {libro.Precio.ToString("C",new CultureInfo("es-AR"))}").ToList();
    }
    public Libro? GetMayorPrecio()
    {
        return _libros.Where(libro => libro.Precio == _libros.Max(mayor => mayor.Precio)).Select(libro => libro).FirstOrDefault();
    }
    public Libro? GetMenorPrecio()
    {
        return _libros.Where(libro => libro.Precio == _libros.Min(menor => menor.Precio)).Select(libro => libro).FirstOrDefault();
    }
    public List<Libro> GetMayorPromedio()
    {
        var promedio = GetPromedioPrecios();
        return _libros.Where(libro => libro.Precio > promedio).ToList();
    }
    public List<Libro> GetLibrosOrdenados()
    {
        return _libros.OrderByDescending(libro => libro.Titulo).ToList();
    }
}