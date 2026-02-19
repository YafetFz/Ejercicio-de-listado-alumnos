using Yafet_Flores_Listado_Alumnos;

Console.WriteLine("Yafet Alessandro Flores Zavala");

List<Alumno> alumnos = new List<Alumno>()
{
    new Alumno("Juan", "Perez", "2004-05-10", 85),
    new Alumno("Maria", "Lopez", "2003-08-15", 90),
    new Alumno("Carlos", "Perez", "2004-05-10", 70),
    new Alumno("Ana", "Martinez", "2005-02-20", 95),
    new Alumno("Luis", "Gomez", "2003-11-30", 60),
    new Alumno("Sofia", "Hernandez", "2004-01-12", 88),
    new Alumno("Pedro", "Ramirez", "2005-07-07", 76),
    new Alumno("Elena", "Perez", "2003-08-15", 92)
};

// MOSTRAR TODOS
Console.WriteLine("\n=== LISTA DE ALUMNOS ===");

foreach (var alumno in alumnos)
{
    Console.WriteLine(alumno.ToString());
}


// FILTRO POR APELLIDO
Console.WriteLine("\n=== FILTRO POR APELLIDO: Perez ===");

foreach (var alumno in alumnos)
{
    if (alumno.Apellido == "Perez")
    {
        Console.WriteLine(alumno.ToString());
    }
}


// FILTRO POR FECHA DE NACIMIENTO
Console.WriteLine("\n=== FILTRO POR FECHA: 2003-08-15 ===");

foreach (var alumno in alumnos)
{
    if (alumno.FechaNacimiento == "2003-08-15")
    {
        Console.WriteLine(alumno.ToString());
    }
}


// FILTRO POR NOTA
Console.WriteLine("\n=== FILTRO POR NOTA: 90 ===");

foreach (var alumno in alumnos)
{
    if (alumno.Nota == 90)
    {
        Console.WriteLine(alumno.ToString());
    }
}


// PROMEDIO DE NOTAS
int sumaNotas = 0;

foreach (var alumno in alumnos)
{
    sumaNotas += alumno.Nota;
}

double promedio = (double)sumaNotas / alumnos.Count;

Console.WriteLine("\n=== PROMEDIO DE LA CLASE ===");
Console.WriteLine("Promedio: " + promedio);


Console.ReadKey();
