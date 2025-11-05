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
            for (int i = 0; i < catalogue.modelList.Count; i++)
            {
                Console.Clear();
                Console.WriteLine($"{catalogue.modelList[i].Id} - {catalogue.modelList[i].Name}");
                if (selection == catalogue.modelList[i].Id)
                {
                    Console.WriteLine(catalogue.modelList[i].Name);
                    Console.WriteLine(catalogue.modelList[i].Description);
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
        //Philips metode til at vise modeller i konsollen
        public void DisplayModel(Model model)
        {
            Console.Clear();
            Console.WriteLine(model.Name);
            Console.WriteLine(model.Description);
        }

        public void MenúSelection()
        {

        }


        public void DisplayMethods(catalogue)
        {
            Console.Clear();
            Console.WriteLine("Liste over metoder");

            for (int i = 0; i < catalogue.methodList; Count; i++)
            {
                for (int j = 0; j < catalogue.methodList[i]; Count, j++)

                {

                    Console.WriteLine(catalogue.methodList[i][j].Name)
                }
               
            }


        }



    }
}
