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
            Console.Clear();
            Console.WriteLine("Welcome to the OOD-OOATool, Type the corresponding number, then press 'Enter'");
            string input;
            while (true)
          
            {
                Console.WriteLine("1 - Catalogue");
                Console.WriteLine("2 - Guides");
               Console.WriteLine("q - Quit"); 
                input = Console.ReadLine();
                if (input == "q") break; 
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
                     
                        break;
                        

                }
            } 



        }
        //Metoder der viser en oversigt af modeller i kataloget
        public void DisplayModels(Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine("Models:\n");
            for (int i = 0; i < catalogue.modelList.Count; i++) //Forløkke der tæller og udskriver listen af modeller
            {
                Console.WriteLine($"{catalogue.modelList[i].Id} - {catalogue.modelList[i].Name}");
            }
            Console.WriteLine("\nSelect a model by entering its ID or select m for menu"); 
            string input = Console.ReadLine();

            switch (input) //En switch der lader brugeren vælge en specifik model
            {
                case "1":
                    DisplayBlock(catalogue.modelList[0], catalogue); //Går ind i listen modelList
                    break;

                case "2":
                    DisplayBlock(catalogue.modelList[1], catalogue);
                    break;

                case "3":
                    DisplayBlock(catalogue.modelList[2], catalogue);
                    break;

                case "m":
                    Console.Clear();                
                    return;  //Returnerer til hovedmenu
                    

                default:
                    Console.WriteLine("Invalid Input! Try Again");
                    break;


            }
        }
        
        public void DisplayBlock(MethodBlock block, Catalogue catalogue)
        {
            Console.Clear();
            Console.WriteLine(block.Name);
            Console.WriteLine(block.Description);
            Console.WriteLine("");
            Console.WriteLine("r for return");

            
            string input = Console.ReadLine();
            if (input == "r") 
            {
                Console.Clear(); 
                
                DisplayModels(catalogue);

            }
        }


        public void DisplayMethods(Catalogue catalogue)
        {
            count++;
            Console.Clear();
            Console.WriteLine("Liste over metoder");
            Console.WriteLine("1 - UML");
            Console.WriteLine("2 - Metode 2");
            Console.WriteLine("3 - Metode 3");
            Console.WriteLine("m for menu");
            if (count > 1)
            {
                Console.WriteLine("Invalid Input! Try 1 instead");
            }
            string input = Console.ReadLine();
            if (input == "1")
            {
                DisplayMethod(catalogue);
            }
            if (input == "m") 
            {
                Console.Clear();
                return; 
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
            Console.WriteLine("");
            Console.WriteLine("r for return"); 
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayBlock(catalogue.modelList[0], catalogue);
                    break;

                case "2":
                    DisplayBlock(catalogue.transitionList[0], catalogue);
                    break;

                case "3":
                    DisplayBlock(catalogue.modelList[1], catalogue);
                    break;

                case "4":
                    DisplayBlock(catalogue.transitionList[1], catalogue);
                    break;

                case "5":
                    DisplayBlock(catalogue.modelList[2], catalogue);
                    break;

                case "r":
                    Console.Clear();
                    DisplayMethods(catalogue);
                    return; 
                    

                default:
                    Console.WriteLine("Invalid Input! Try Again");
                    break;
            }

        }


    }
}
