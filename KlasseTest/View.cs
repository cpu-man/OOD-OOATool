using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    public class View
    {
        int count;
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
                    DisplayBlock(catalogue.modelList[0]);
                    break;

                case "2":
                    DisplayBlock(catalogue.modelList[1]);
                    break;

                case "3":
                    DisplayBlock(catalogue.modelList[2]);
                    break;

                default:
                    Console.WriteLine("Invalid Input! Try Again");
                    //validInput = false;
                    break;


            }
        }
        //Philips metode til at vise modeller i konsollen
        public void DisplayBlock(MethodBlock block)
        {
            Console.Clear();
            Console.WriteLine(block.Name);
            Console.WriteLine(block.Description);
        }

        public void DisplayMethods(Catalogue catalogue)
        {
            count++;
            Console.Clear();
            Console.WriteLine("Liste over metoder");
            Console.WriteLine("1 - UML");
            Console.WriteLine("2 - Metode 2");
            Console.WriteLine("3 - Metode 3");
            if (count > 1)
            {
                Console.WriteLine("Invalid Input! Try 1 instead");
            }
            string input = Console.ReadLine();
            if (input == "1")
            {
                DisplayMethod(catalogue);
            }
            else
            {
                DisplayMethods(catalogue);
            }

        }

        public void DisplayMethod(Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine("1 - Use Case");
            Console.WriteLine("2 - Use Case-Klassediagram");
            Console.WriteLine("3 - Klassediagram");
            Console.WriteLine("4 - Klassediagram-Sekvensdiagram");
            Console.WriteLine("5 - Sekvensdiagram");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayBlock(catalogue.modelList[0]);
                    break;

                case "2":
                    DisplayBlock(catalogue.transitionList[0]);
                    break;

                case "3":
                    DisplayBlock(catalogue.modelList[1]);
                    break;

                case "4":
                    DisplayBlock(catalogue.transitionList[1]);
                    break;

                case "5":
                    DisplayBlock(catalogue.modelList[2]);
                    break;

                default:
                    Console.WriteLine("Invalid Input! Try Again");
                    //validInput = false;
                    break;
            }

        }


    }
}
