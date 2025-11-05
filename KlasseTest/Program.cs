using KlasseTest;


namespace KlasseTest
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //Console.WriteLine("Projekt 3 Anna, Lasse, Matias, Philip & Sidney");
            Catalogue catalogue = new Catalogue();

            //public List<Model> modelList = new List<Model>();
            Model usecase = new Model("Use Case", "Hejsa", 1);
        catalogue.modelList.Add(usecase);

            Model klassediagram = new Model("Klassediagram", "Lav nogle klasser", 2);
        catalogue.modelList.Add(klassediagram);

            Model sekvensdiagram = new Model("Sekvensdiagram", "Et eller andet", 3);
        catalogue.modelList.Add(sekvensdiagram);

            Transition transition = new Transition(usecase, klassediagram, "hej");
            Transition transition2 = new Transition(klassediagram, sekvensdiagram, "hejsaa");

            View view = new View();
        view.DisplayMenu(catalogue);
        }
        
    }
}

