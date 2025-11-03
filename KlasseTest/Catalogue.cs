using System;
using System.Collections.Generic;

namespace KlasseTest
{
    public class Catalogue
    {
        public List<Model> models = new List<Model>();
        public List<ModelMethodBlock> modelBlocks = new List<ModelMethodBlock>();
        public List<TransitionMethodBlock> transitionBlocks = new List<TransitionMethodBlock>();

        public void AddModels()
        {
            Model usecase = new Model("Use Case", "Denne usecase er god", 1);
            models.Add(usecase);

            Model klassediagram = new Model("Klassediagram", "God dag", 2);
            models.Add(klassediagram);

            Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
            models.Add(sekvensdiagram);
        }

        //METHOD BLOCKS 
        public void AddMethodBlocks()
        {
            modelBlocks.Add(new ModelMethodBlock("ModelBlock1", "MB1", "Used in model handling"));
            modelBlocks.Add(new ModelMethodBlock("ModelBlock2", "MB2", "Another model block"));

            transitionBlocks.Add(new TransitionMethodBlock("TransitionBlock1", "TB1", "Handles transitions"));
        }
    }
}
