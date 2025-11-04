using KlasseTest;
using System;
using System.Collections.Generic;
using System.Reflection;

public class Catalogue
{

   public List<Model> models = new List<Model>();
    public List<Guide> guides = new List<Guide>();
    public List<Transition> transitions = new List<Transition>();



    public void AddModels()
    {
        Model usecase = new Model("Use Case", "Hejsa", 1);
        models.Add(usecase);

        Model klassediagram = new Model("Klassediagram", "Lav nogle klasser", 2);
        models.Add(klassediagram);


        Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        models.Add(sekvensdiagram);
    }
    public void AddTransition(Model from, Model to, string description)
    {
        Transition transition = new Transition(from, to, description);
        transitions.Add(transition);
    }



public void AddGuide()
    {

    }

}
