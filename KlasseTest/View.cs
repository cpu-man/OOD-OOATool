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
                Console.Clear();
                Console.WriteLine($"{catalogue.models[i].Id} - {catalogue.models[i].Name}");
                if (selection == catalogue.models[i].Id)
                {
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
            bool validInput = false; 
            Console.Clear();
            Console.WriteLine("Welcome to the OOD-OOATool, Type the corresponding number, then press 'Enter'");
            do
            {
                Console.WriteLine("1 - Catalogue");
                Console.WriteLine("2 - Guides");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayCatalogue(catalogue);
                        break;

                    /*case "2":
                        DisplayMethods(catalogue);
                        break;*/

                    default:
                        Console.WriteLine("Invalid Input!");
                        validInput = false;
                        break;
                        

                }
            } while (!validInput);



        }

        public void MenúSelection()
        {

        }
    }
}
