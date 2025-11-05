using KlasseTest;


namespace KlasseTest
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOD-OOATool, Type the corresponding number, then press 'Enter'");
            
            //Console.WriteLine("Projekt 3 Anna, Lasse, Matias, Philip & Sidney");
            Catalogue catalogue = new Catalogue();
            

            Model usecase = new Model("Use Case", "Hejsa", 1);
        catalogue.modelList.Add(usecase);

            Model klassediagram = new Model("Klassediagram", "Lav nogle klasser", 2);
        catalogue.modelList.Add(klassediagram);

            Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        catalogue.modelList.Add(sekvensdiagram);
            
            List<MethodBlock> metode2 = new List<MethodBlock>();
            List<MethodBlock> metode3 = new List<MethodBlock>();
            List<MethodBlock> uml = new List<MethodBlock>() { usecase, klassediagram, sekvensdiagram };
            catalogue.methodList.Add(uml);
            catalogue.methodList.Add(metode2);
            catalogue.methodList.Add(metode3);

          

            Transition transition = new Transition(usecase, klassediagram, "hej");
            Transition transition2 = new Transition(klassediagram, sekvensdiagram, "hejsaa");
            catalogue.transitionList.Add(transition);
            catalogue.transitionList.Add(transition2);

            View view = new View();
        view.DisplayMenu(catalogue);
        }
        
    }
}

