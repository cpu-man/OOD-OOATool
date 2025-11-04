using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    public class View
    {
        
        public void Model(Catalogue catalogue)
        {
            int selection = Convert.ToInt32 (Console.ReadLine());
            for (int i = 0; i < catalogue.models.Count; i++)
            {
                if (selection == catalogue.models[i].id)
                {
                    Console.Clear();
                    Console.WriteLine(catalogue.models[i].name);
                    Console.WriteLine(catalogue.models[i].description);
                    Console.WriteLine("\nTryk 'q' for at returnere til oversigten");
                    string quit = Console.ReadLine();
                    if (quit.ToLower() == "q" )
                    {
                        Catalogue(catalogue);
                    }
                }
            }
           
        }

        public void Catalogue(Catalogue catalogue)
        {
            Console.Clear();
            foreach (var x in catalogue.models)
            {
                Console.WriteLine(x.id + " "+ x.name);
            }
            Console.WriteLine("\nTast nummeret for at vælge en model, tryk derefter 'Enter' ");
            Model(catalogue);


        }
    }
}
