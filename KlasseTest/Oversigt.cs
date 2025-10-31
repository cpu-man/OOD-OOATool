using System;
using System.Collections.Generic;
using System.Reflection;

public class Oversigt
{

   public List<Model> modeller = new List<Model>();

    

    public void AddModels()
    {
        Model usecase = new Model("Sekvensdiagram", "Et eller andet", 3);
        usecase.id = 1;
        usecase.navn = "Use Case";
        usecase.beskrivelse = "Denne usecase er god";
        modeller.Add(usecase);

        Model klassediagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        klassediagram.id = 2;
        klassediagram.navn = "Klassediagram";
        klassediagram.beskrivelse = "God dag";
        modeller.Add(klassediagram);


        Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        modeller.Add(sekvensdiagram);
    }

}
