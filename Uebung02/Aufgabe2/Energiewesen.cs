namespace Aufgabe2
{
    public class Energiewesen
    {
        //Kategorie Enum
        public enum Kategorie 
        {
            THERMO, ELEKTRO, NONE
        }

        //unsere privaten Felder
        private string bezeichnung;
        private int registriernummer;
        private Kategorie kategorie;
        private float leistung;

        //Alternativ zu den Feldern (Teil b) mit Properties (erspart uns die mühseligen getter- und setter-Methoden)
        /*
        public string bezeichnung {get; set;}
        public int registriernummer {get; set;}
        public Kategorie kategorie {get; set;}
        public float leistung {get; set;}
        
        //-> ausführliche Schreibweise mit get und set (hier wird das Property als Wrapper für das Feld 'leistung' benutzt)
        public float leistungProperty  
        {
            get 
            {
                return this.leistung;
            }
            set
            {
                this.leistung = value;
            }
        }
        //Auch ausführlich, aber in Kurzform:
        public float leistungProperty 
        {
            get  => this.leistung;
            
            set => this.leistung = value;
        }
        */
        

        //Konstruktor mit vier Parametern
        public Energiewesen(string bez, int regNr, Kategorie kat, float leistung)
        {
            bezeichnung = bez;
            registriernummer = regNr;
            kategorie = kat;
            this.leistung = leistung;
        }

        //Konstruktor ohne Parameter nutzt unseren anderen Konstruktor mit festgelegten Werten 
        //(eigener Konstruktor der Klasse kann mit 'this' aufgerufen werden)
        public Energiewesen() : this("NOT_SET", -1, Kategorie.NONE, -1.0f) { }

        //setter-Methoden
        public void setBezeichnung(string bezeichnung) { this.bezeichnung = bezeichnung;}
        public void setRegistriernummer(int registriernummer) { this.registriernummer = registriernummer;}
        public void setKategorie(Kategorie kategorie) { this.kategorie = kategorie;}
        public void setLeistung(float leistung) { this.leistung = leistung;}

        //getter-Methoden
        public string getBezeichnung() {return this.bezeichnung;}
        public int getRegistriernummer() {return this.registriernummer;}
        public Kategorie getKategorie() {return this.kategorie;}
        public float getLeistung() {return this.leistung;}

        /*
            Wir überschreiben die Standard Methode ToString, damit wir z.B. Console.WriteLine([Energiewesen])
            nutzen können. Console.WriteLine ruft implizit diese ToString Methode auf, wir können sie aber
            natürlich auch sonst an jeder Stelle nutzen, um eine String-Repräsentation von einem Objekt der
            Klasse Energiewesen zu bekommen.
        */
        public override string ToString()
        {
            return $"Bezeichnung: {bezeichnung}\nRegistriernummer: {registriernummer}\n" +
                $"Kategorie: {kategorie}\nLeistung: {leistung:0.00}\n";
        }
    }
}