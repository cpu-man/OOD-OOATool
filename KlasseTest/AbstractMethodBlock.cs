using System;

namespace KlasseTest
{
    // Superclass for alle method blocks
    public abstract class AbstractMethodBlock
    {
        // Navn , id og beskrivelse
        public string name;
        public string id;           
        public string description;

        protected AbstractMethodBlock(string name, string id, string description)
        {
            this.name = name;
            this.id = id;
            this.description = description;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{id}: {name} - {description}");
        }
    }
}
