using KlasseTest;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Projekt 3 Anna, Lasse, Matias, Philip & Sidney");
        Catalogue catalogue = new Catalogue();
        catalogue.AddModels();
        
        View view = new View();
        view.List(catalogue);
       
    }
}