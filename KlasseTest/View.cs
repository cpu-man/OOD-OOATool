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
            do
            {
                Console.WriteLine("1 - Catalogue");
                Console.WriteLine("2 - Guides");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayModels(catalogue);
                        break;

                    case "2":
                        DisplayMethods(catalogue);
                        break;

                    default:
                        Console.WriteLine("Invalid Input! Try Again");
                        validInput = false;
                        break;
                        

                }
            } while (validInput);



        }
        //Philips metode til at vise guides i konsollen
        public void DisplayModels(Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine("Models:\n");
            for (int i = 0; i < catalogue.modelList.Count; i++)
            {
                Console.WriteLine($"{catalogue.modelList[i].Id} - {catalogue.modelList[i].Name}");
            }
            Console.WriteLine("\nSelect a model by entering its ID:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayModel(catalogue.modelList[0]);
                    break;

                case "2":
                    DisplayModel(catalogue.modelList[1]);
                    break;

                case "3":
                    DisplayModel(catalogue.modelList[2]);
                    break;

                default:
                    Console.WriteLine("Invalid Input! Try Again");
                    //validInput = false;
                    break;


            }
        }
        //Philips metode til at vise modeller i konsollen
        public void DisplayModel(Model model)
        {
            Console.Clear();
            Console.WriteLine(model.Name);
            Console.WriteLine(model.Description);
        }

        public void DisplayMethods(Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine("Liste over metoder");
            Console.WriteLine("1 - UML");
            Console.WriteLine("2 - Metode 2");
            Console.WriteLine("3 - Metode 3");
            

        }

        public void DisplayMethod()
        {
            Console.Clear();
            Console.WriteLine("1 - Use Case");
            Console.WriteLine("2 - Use Case-Klassediagram");
            Console.WriteLine("3 - Klassediagram");
            Console.WriteLine("4 - Klassediagram-Sekvensdiagram");
            Console.WriteLine("5 - Sekvensdiagram");

        }


    }
}
