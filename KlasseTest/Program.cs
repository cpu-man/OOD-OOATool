using KlasseTest;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace KlasseTest
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //Opretter container til modeller, metodelister og transitions.
            Catalogue catalogue = new Catalogue();

            //Opretter model til "Use Case", med beskrivelse og ID 1.
            Model usecase = new Model("Use Case", "En Use Case beskriver, hvordan brugeren interagerer med systemet.\r\nDen viser de funktionelle krav og de handlinger, der foregår i forskellige scenarier.\r\nFormålet er at skabe et overblik over, hvad systemet skal kunne ud fra brugerens perspektiv.", 1);
            //Tilføjer model 1 til kataloget
            catalogue.modelList.Add(usecase);

            //Opretter model til "Klassediagram", med beskrivelse og ID 2.
            Model klassediagram = new Model("Klassediagram", "Et Klassediagram viser systemets struktur ved hjælp af klasser, attributter og relationer. Det bruges til at modellere data, funktioner og forbindelser mellem forskellige dele af systemet. Klassediagrammet giver et statistisk overblik over, hvordan systemet er bygget op.", 2);
            //Tilføjer model 2 til kataloget.
            catalogue.modelList.Add(klassediagram);

            //Opretter model til "Sekvensdiagram", med beskrivelse og ID 3.
            Model sekvensdiagram = new Model("Sekvensdiagram", "Et sekvensdiagram viser rækkefølgen af beskeder og kald mellem objekter i et bestemt scenarie.\r\nDet bruges til at illustrere, hvordan systemets dele arbejder sammen for at udføre en funktion.\r\nSekvensdiagrammet giver et klart billede af programmets flow og logiske forløb.", 3);
            //Tilføjer model 3 til kataloget
            catalogue.modelList.Add(sekvensdiagram);

            //Opretter en tom metodesamling til metode2.
            List<MethodBlock> metode2 = new List<MethodBlock>();
            //Opretter en tom metodesamling til metode3.
            List<MethodBlock> metode3 = new List<MethodBlock>();
            //Opretter en tom metodesamling til UML som indeholder 3 modeller.
            List<MethodBlock> uml = new List<MethodBlock>() { usecase, klassediagram, sekvensdiagram };

            //Lægger UML-listen ind som første element i methodList.
            catalogue.methodList.Add(uml);
            //Lægger palceholder metode2 ind som andet element i methodList.
            catalogue.methodList.Add(metode2);
            //Lægger placeholder metode 3 ind som tredje element i methodList.
            catalogue.methodList.Add(metode3);


            //Opretter transition: Use Case -> Klassediagram, med beskrivelse.
            Transition transition = new Transition(usecase, klassediagram, "Denne transition viser sammenhængen mellem brugerens handlinger (Use Case)\r\nog systemets struktur (Klassediagram).\r\nDen illustrerer, hvordan de funktionelle krav bliver omsat til klasser og relationer i systemets design.");
            //Opretter transition: Klassediagram -> Sekvensdiagram med beskrivelse.
            Transition transition2 = new Transition(klassediagram, sekvensdiagram, "Denne transition viser, hvordan elementerne fra klassediagrammet interagerer over tid.\r\nDen forbinder den statiske struktur med den dynamiske opførsel i systemet.\r\nDet hjælper med at forstå, hvordan objekter sender beskeder og udfører handlinger i en bestemt rækkefølge.");

            //Lægger transition (usecase-klassediagram) i transitionList.
            catalogue.transitionList.Add(transition);
            //Lægger transition (klassediagram-sekvensdiagram) i transitionList.
            catalogue.transitionList.Add(transition2);

            //Opretter View som står for console-UI (Layout og Navigation).
            View view = new View();

            //Starter hovedmenu med catalogue som parameter.
            view.DisplayMenu(catalogue);
        }

    }
}

