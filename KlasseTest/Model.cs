using KlasseTest;
using System;

namespace KlasseTest
{

    public class Model : MethodBlock
    {
        // Unikt tal ID for modellen – bruges til valg i menuen
        public int Id { get; set; }


        // Opretter en model med navn, beskrivelse og et tal ID.
        // Kalder MethodBlock for at sætte fælles felter.
        public Model(string name, string description, int id)
            : base(name, description)
        {
            Id = id;
        }
    }
}

