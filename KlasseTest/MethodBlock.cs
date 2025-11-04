using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    // Fælles felter: navn og beskrivelse.
    public abstract class MethodBlock
    {
        public string Name { get; set; }
        public string Description { get; set; }


        // Basis-konstruktør som underklasser kalder
        protected MethodBlock(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}

