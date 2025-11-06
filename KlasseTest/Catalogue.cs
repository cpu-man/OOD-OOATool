using KlasseTest;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace KlasseTest
{

    public class Catalogue
    {
        // Liste over alle modeller i systemet (Use Case, Klassediagram, Sekvensdiagram osv.)
        public List<Model> modelList = new List<Model>();

        // Liste over "MethodBlocks" — dvs. metoder eller trin, som kan være samlet i guider
        public List<List<MethodBlock>> methodList = new List<List<MethodBlock>>();


        // Liste over alle overgange (Transitions) mellem modeller
        public List<Transition> transitionList = new List<Transition>();

        // Denne metode opretter en overgang mellem to modeller (fra én model til en anden)
        // Eksempel: fra Use Case → Klassediagram
        public void AddTransition(Model from, Model to, string description)
        {
            // Opretter et nyt Transition-objekt med de to modeller og en beskrivelse
            Transition transition = new Transition(from, to, description);
            transitionList.Add(transition);
        }



        public void AddMethod()
        {

        }

    }
}
