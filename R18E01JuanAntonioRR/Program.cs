namespace R18E01JuanAntonioRR;

    internal class Program
    {
    static void Main(string[] args)
    {
        Examen prueba; // Null por defecto

        prueba = new Examen();

        Console.WriteLine($"Asignatura: {prueba.Asignatura}\nNota: {prueba.Nota}");

        prueba = new Examen("Base de datos");

        Console.WriteLine($"Asignatura: {prueba.Asignatura}\nNota: {prueba.Nota}");

        prueba = new Examen("Lenguaje de marcas", 9.5f);

        Console.WriteLine($"Asignatura: {prueba.Asignatura}\nNota: {prueba.Nota}");
    }
            
    }

