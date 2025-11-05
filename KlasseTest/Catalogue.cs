using KlasseTest;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace KlasseTest
{

    public class Catalogue
    {
        public List<Model> modelList = new List<Model>();
        public List<List<MethodBlock>> methodList = new List<List<MethodBlock>>();
        public List<Transition> transitions = new List<Transition>();


        public void AddTransition(Model from, Model to, string description)
        {
            Transition transition = new Transition(from, to, description);
            transitions.Add(transition);
        }



        public void AddMethod()
        {

        }

    }
}
