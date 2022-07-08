namespace Demos.Day2.Lib
{
    public enum Key : ushort
    {
        Enter,
        Home,

        Shift,
    }

    public enum Gender : byte
    {
        Male,
        Female
    }

    public enum Kleur
    {
        Wit,
        Zwart,

        Rood = 10,
        Groen,
        Blauw
    }

    public struct Fiets
    {
        public const int StandaardAantalBanden = 2;

        // wel uitlezen, niet schrijven
        //public int AantalBandenOrigineel { private get; set; }


        private int _aantalBanden;
        public int AantalBanden 
        {
            get { return _aantalBanden; }
            set
            {
                if (value < 0 || value > 2)
                    throw new Exception();

                _aantalBanden = value;
            }
        }




        public Kleur Kleur;

        public string KleurNaam 
        { 
            get 
            { return Kleur.ToString(); } 
        }

        public Fiets()
        {
            _aantalBanden = 0;
            Kleur = Kleur.Wit;

            AantalBanden = 6;
        }
        public Fiets(Kleur kleur)
        {
            _aantalBanden = StandaardAantalBanden;
            Kleur = kleur;
        }

        public void RijOverGlas()
        {
            AantalBanden = 0;
        }

    }

    public static class DemosDay2
    {
        public const int HuisNummer = 11;

        public static void DoDemos()
        {
            var fiets = new Fiets();

            var zwarteFiets = new Fiets(Kleur.Zwart);

            var naam = zwarteFiets.KleurNaam;

            var aantalBanden = zwarteFiets.AantalBanden;
            //zwarteFiets.AantalBanden = 5;

            return;
        }

        static void HandleKeyInput(Key param)
        {
            switch(param)
            {
                case Key.Enter:
                    break;

                case Key.Home:
                    break;


                default:
                    Console.WriteLine("Ongeldige key waarde");
                    break;
            }
        }

        static void PrintToScreen(string text, int x, int y)
        {
            int windowX = 100;
            int windowY = 200;

            var actualX = windowX + x;
            var actualY = windowY + y;

        }
        static void PrintToScreen(string text, Vector v)
        {
            Vector screenPos = new Vector(100, 400);

            Vector targetPos = screenPos.Add(v);

            //Console.WriteLine(targetP)

            return;
        }
    }
}