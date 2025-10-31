using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    public class View
    {
        
        public void Model(Oversigt oversigt)
        {
            int selection = Convert.ToInt32 (Console.ReadLine());
            for (int i = 0; i < oversigt.modeller.Count; i++)
            {
                if (selection == oversigt.modeller[i].id)
                {
                    Console.Clear();
                    Console.WriteLine(oversigt.modeller[i].navn);
                    Console.WriteLine(oversigt.modeller[i].beskrivelse);
                    Console.WriteLine("\nTryk 'q' for at returnere til oversigten");
                    string quit = Console.ReadLine();
                    if (quit.ToLower() == "q" )
                    {
                        List(oversigt);
                    }
                }
            }
           
        }

        public void List(Oversigt oversigt)
        {
            Console.Clear();
            foreach (var x in oversigt.modeller)
            {
                Console.WriteLine(x.id + " "+ x.navn);
            }
            Console.WriteLine("\nTast nummeret for at vælge en model, tryk derefter 'Enter' ");
            Model(oversigt);


        }
    }
}
