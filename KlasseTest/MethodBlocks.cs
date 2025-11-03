using System;

namespace KlasseTest
{
    //Model Method Block
    public class ModelMethodBlock : AbstractMethodBlock
    {
        public ModelMethodBlock(string name, string id, string description)
            : base(name, id, description) { }
    }

    //Transition Method Block
    public class TransitionMethodBlock : AbstractMethodBlock
    {
        public TransitionMethodBlock(string name, string id, string description)
            : base(name, id, description) { }
    }
}
