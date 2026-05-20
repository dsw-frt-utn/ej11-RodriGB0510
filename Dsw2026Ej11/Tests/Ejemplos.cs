using Dsw2026Ej11.Domain;
using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        Alumno alu1 = new Alumno(101, "Juan", 8.41d);
        Alumno alu2 = new Alumno(102, "María", 9.25d);
        Alumno alu3 = new Alumno(103, "Pedro", 7.50d);
        lista.AgregarAlumno(alu1);
        lista.AgregarAlumno(alu2);
        lista.AgregarAlumno(alu3);

        Console.WriteLine("\nListando alumnos...\n");
        foreach (var alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine($"\t{alumno}");
        }

        Console.WriteLine("\nBuscando alumnos Juan y Alicia...\n");
        var nombresABuscar = new[] { "Juan", "Alicia" };
        foreach (var nombre in nombresABuscar)
        {
            var alumno = lista.BuscarAlumnoPorNombre(nombre);
            if (alumno != null)
                Console.WriteLine($"\tAlumno encontrado: {alumno}");
            else
                Console.WriteLine($"\t{nombre} no existe");
        }

        lista.EliminarAlumno(alu2);
        Console.WriteLine($"\n{alu2.Nombre} fue eliminada. Listando alumnos...\n");
        foreach (var alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine($"\t{alumno}");
        }

        lista.EliminarAlumnoEn(0);
        Console.WriteLine($"\n Primer alumno eliminado. Listando alumnos...\n");
        foreach (var alumno in lista.ObtenerAlumnos())
        {
            Console.WriteLine($"\t{alumno}");
        }
    }
    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno alu1 = new Alumno(101, "Juan", 8.41d);
        Alumno alu2 = new Alumno(102, "María", 9.25d);
        Alumno alu3 = new Alumno(103, "Pedro", 7.50d);
        diccionario.AgregarAlumno(58399, alu1);
        diccionario.AgregarAlumno(58400, alu2);
        diccionario.AgregarAlumno(58401, alu3);

        Console.WriteLine("\nListando alumnos...\n");
        foreach (var (legajo, alumno) in diccionario.ObtenerAlumnos())
        {
            Console.WriteLine($"\tLegajo: {legajo}, Alumno: {alumno}");
        }

        Console.WriteLine("\nBuscando alumnos con legajos 58399 y 58402...\n");
        var legajosABuscar = new[] { 58399, 58402 };
        foreach (var legajo in legajosABuscar)
        {
            var alumno = diccionario.BuscarAlumno(legajo);
            if (alumno != null)
                Console.WriteLine($"\tAlumno encontrado: Legajo: {legajo}, Alumno: {alumno}");
            else
                Console.WriteLine($"\tLegajo {legajo} no existe");
        }

        diccionario.EliminarAlumno(58400);
        Console.WriteLine($"\nAlumno con legajo 58400 eliminado. Listando alumnos...\n");
        foreach (var (legajo, alumno) in diccionario.ObtenerAlumnos())
        {
            Console.WriteLine($"\tLegajo: {legajo}, Alumno: {alumno}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Libro? primero = linq.GetPrimero();
        if ( primero != null )
            Console.WriteLine($"\n Primer libro: {primero?.Id} - {primero?.Titulo} - {primero?.Precio}\n");
        else
            Console.WriteLine("\n No hay libros en la lista\n");

        Libro? ultimo = linq.GetUltimo();
        if(ultimo != null)
            Console.WriteLine($"\n Ultimo libro: {ultimo?.Id} - {ultimo?.Titulo} - {ultimo?.Precio}\n");
        else
            Console.WriteLine("\n No hay libros en la lista\n");

        Console.WriteLine($"\n Total de precios: {linq.GetTotalPrecios()}\n");

        Console.WriteLine($"\n Promedio de precios: {linq.GetPromedioPrecios()}\n");

        Console.WriteLine($"\n Libros ordenados por Id (mayores a 15):\n");
        foreach (var libro in linq.GetListById())
        {
            Console.WriteLine($"\t{libro.Id} - {libro.Titulo} - {libro.Precio}");
        }

        Console.WriteLine($"\n Títulos de los libros:\n");
        foreach (var titulo in linq.GetLibros())
        {
            Console.WriteLine($"\t{titulo}");
        }

        Libro? mayorPrecio = linq.GetMayorPrecio();
        Console.WriteLine($"\n Libro con mayor precio: {mayorPrecio?.Id} - {mayorPrecio?.Titulo} - {mayorPrecio?.Precio}\n");

        Libro? menorPrecio = linq.GetMenorPrecio();
        Console.WriteLine($"\n Libro con menor precio: {menorPrecio?.Id} - {menorPrecio?.Titulo} - {menorPrecio?.Precio}\n");

        Console.WriteLine($"\n Libros con precio mayor al promedio:\n");
        foreach (var libro in linq.GetMayorPromedio())
        {
            Console.WriteLine($"\t{libro.Id} - {libro.Titulo} - {libro.Precio}");
        }

        Console.WriteLine($"\n Libros ordenados por titulo de forma descendente:");
        foreach (var libro in linq.GetLibrosOrdenados())
        {
            Console.WriteLine($"\t{libro.Id} - {libro.Titulo} - {libro.Precio}");
        }
    }
}
