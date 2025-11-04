using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseTest
{
    public class Transition : MethodBlock
    {
        // ID for modellen man går FRA
        public int FromModelId { get; }
        // ID for modellen man går TIL
        public int ToModelId { get; }
        // Sammensat ID i "fra-til", eks. "1-2", string format.
        public string Id { get; }


        // Transition-navnet dannes automatisk som "fraNavn-tilNavn"
        public Transition(Model from, Model to, string description)
            : base($"{from.Name}-{to.Name}", description)
        {
            // Gemmer modellerne der er forbundet med overgangen
            FromModelId = from.Id;
            ToModelId = to.Id;
            // Bygger etID der tydeligt viser overgangen mellem to modeller
            Id = $"{from.Id}-{to.Id}";
        }
    }
}

