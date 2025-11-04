using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    public class View
    {
        
        public void DisplayCatalogue(Catalogue catalogue)
        {
            int selection = Convert.ToInt32 (Console.ReadLine());
            for (int i = 0; i < catalogue.models.Count; i++)
            {
                if (selection == catalogue.models[i].Id)
                {
                    Console.Clear();
                    Console.WriteLine(catalogue.models[i].Name);
                    Console.WriteLine(catalogue.models[i].Description);
                    Console.WriteLine("\nTryk 'q' for at returnere til oversigten");
                    string quit = Console.ReadLine();
                    if (quit.ToLower() == "q" )
                    {
                        DisplayCatalogue(catalogue);
                    }
                }
            }
           
        }
        public void DisplayMenu(Catalogue catalogue)
        {
            string input;
            Console.Clear();
            Console.WriteLine("1 - Catalogue");
            Console.WriteLine("2 - Guides");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DisplayCatalogue(catalogue);
                    break;

                case "2":
                    DisplayMethods(catalogue);
                    break;

                default:
                    Console.WriteLine("Invalid Input!");

                
            }


        }
        //Philips metode til at vise guides i konsollen
        public void DisplayModels(Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine("Models:\n");
            for (int i = 0; i < catalogue.models.Count; i++)
            {
                Console.WriteLine($"{catalogue.models[i].Id} - {catalogue.models[i].Name}");
            }
            Console.WriteLine("\nSelect a model by entering its ID:");
        }
        //Philips metode til at vise guides i konsollen
        public void DisplayModel(Model model)
        {
            Console.Clear();
            Console.WriteLine(model.Name);
            Console.WriteLine(model.Description);
        }

        public void MenúSelection()
        {

        }
    }
}
