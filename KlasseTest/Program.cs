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
            

            Model usecase = new Model("Use Case", "En Use Case beskriver, hvordan brugeren interagerer med systemet.\r\nDen viser de funktionelle krav og de handlinger, der foregår i forskellige scenarier.\r\nFormålet er at skabe et overblik over, hvad systemet skal kunne ud fra brugerens perspektiv.", 1);
        catalogue.modelList.Add(usecase);

            Model klassediagram = new Model("Klassediagram", "Et Klassediagram viser systemets struktur ved hjælp af klasser, attributter og relationer.\r\nDet bruges til at modellere data, funktioner og forbindelser mellem forskellige dele af systemet.\r\nKlassediagrammet giver et statistisk overblik over, hvordan systemet er bygget op.", 2);
        catalogue.modelList.Add(klassediagram);

            Model sekvensdiagram = new Model("Sekvensdiagram", "Et sekvensdiagram viser rækkefølgen af beskeder og kald mellem objekter i et bestemt scenarie.\r\nDet bruges til at illustrere, hvordan systemets dele arbejder sammen for at udføre en funktion.\r\nSekvensdiagrammet giver et klart billede af programmets flow og logiske forløb.", 3);
        catalogue.modelList.Add(sekvensdiagram);
            
            List<MethodBlock> metode2 = new List<MethodBlock>();
            List<MethodBlock> metode3 = new List<MethodBlock>();
            List<MethodBlock> uml = new List<MethodBlock>() { usecase, klassediagram, sekvensdiagram };
            catalogue.methodList.Add(uml);
            catalogue.methodList.Add(metode2);
            catalogue.methodList.Add(metode3);

          

            Transition transition = new Transition(usecase, klassediagram, "Denne transition viser sammenhængen mellem brugerens handlinger (Use Case)\r\nog systemets struktur (Klassediagram).\r\nDen illustrerer, hvordan de funktionelle krav bliver omsat til klasser og relationer i systemets design.\r\n");
            Transition transition2 = new Transition(klassediagram, sekvensdiagram, "Denne transition viser, hvordan elementerne fra klassediagrammet interagerer over tid.\r\nDen forbinder den statiske struktur med den dynamiske opførsel i systemet.\r\nDet hjælper med at forstå, hvordan objekter sender beskeder og udfører handlinger i en bestemt rækkefølge.");
            catalogue.transitionList.Add(transition);
            catalogue.transitionList.Add(transition2);

            View view = new View();
        view.DisplayMenu(catalogue);
        }
        
    }
}

