using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    public class View
    {
        
        static void Model()
        {
        }

        public void List(Oversigt oversigt)
        {
            foreach (var x in oversigt.modeller)
            {
                Console.WriteLine(x.navn);
            }
            
        }
    }
}
