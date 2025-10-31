using KlasseTest;
using System;
using System.Collections.Generic;
using System.Reflection;

public class Catalogue
{

   public List<Model> models = new List<Model>();
    public List<Guide> guides = new List<Guide>();
    

    public void AddModels()
    {
        Model usecase = new Model("Sekvensdiagram", "Et eller andet", 3);
        usecase.id = 1;
        usecase.name = "Use Case";
        usecase.description = "Denne usecase er god";
        models.Add(usecase);

        Model klassediagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        klassediagram.id = 2;
        klassediagram.name = "Klassediagram";
        klassediagram.description = "God dag";
        models.Add(klassediagram);


        Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        models.Add(sekvensdiagram);
    }

    public void AddGuide()
    {

    }

}
