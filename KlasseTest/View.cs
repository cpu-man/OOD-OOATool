using System;

namespace KlasseTest
{
    public class View
    {
        public void List(Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine("Models");
            foreach (var m in catalogue.models)
            {
                Console.WriteLine($"{m.id}: {m.name}");
            }

            Console.WriteLine("\n Model Method Blocks");
            foreach (var block in catalogue.modelBlocks)
            {
                block.ShowInfo();
            }

            Console.WriteLine("\nTransition Method Blocks");
            foreach (var t in catalogue.transitionBlocks)
            {
                t.ShowInfo();
            }

            Console.WriteLine("\nSelect a model id to view details, or type 'q' to quit:");
            string input = Console.ReadLine();
            if (input?.ToLower() == "q") return;

            if (int.TryParse(input, out int selection))
            {
                ShowModel(catalogue, selection);
            }
        }

        private void ShowModel(Catalogue catalogue, int selection)
        {
            foreach (var model in catalogue.models)
            {
                if (model.id == selection)
                {
                    Console.Clear();
                    Console.WriteLine(model.name);
                    Console.WriteLine(model.description);
                    Console.WriteLine("\nTryk 'q' for at returnere til oversigten");
                    string quit = Console.ReadLine();
                    if (quit?.ToLower() == "q")
                    {
                        List(catalogue);
                    }
                    return;
                }
            }

            Console.WriteLine("Model not found. Press any key to go back.");
            Console.ReadKey();
            List(catalogue);
        }
    }
}
