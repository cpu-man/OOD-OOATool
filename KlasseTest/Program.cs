using System;

namespace KlasseTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            catalogue.AddModels();
            catalogue.AddMethodBlocks();

            View view = new View();
            view.List(catalogue);

            Console.WriteLine("\nFinished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

