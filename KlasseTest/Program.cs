using KlasseTest;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Projekt 3 Anna, Lasse, Matias, Philip & Sidney");
        Oversigt oversigt = new Oversigt();
        oversigt.AddModels();
        View view = new View();
        view.List(oversigt);
        Console.WriteLine();
       
    }
}