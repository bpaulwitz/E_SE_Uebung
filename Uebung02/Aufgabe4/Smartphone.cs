using System;

namespace Aufgabe4
{
    public class Smartphone
    {
        //Nullable int -> kann entweder eine Ganzzahl oder null enthalten
        private int? pin;
        private bool isLocked;
        private int pinFailures;

        //Konstruktor
        public Smartphone()
        {
            pin = null;
            isLocked = true;
            pinFailures = 0;
        }

        private bool authentifizierung()
        {
            //Wenn bereits mehr als drei Fehlversuche gemacht wurden, kann man sich nicht mehr authentifizieren
            if(pinFailures > 3)
            {
                Console.WriteLine("Smarphone gesperrt, es gab drei fehlerhafte Anmeldungsversuche");
                return false;
            }

            //Wenn das Smartphone nicht gesperrt ist, muss man sich nicht authentifizieren
            if(!isLocked)
                return true;

            //Nullable type, in dem wir die eingabe speichern
            int? authPin;

            Console.WriteLine("Bitte PIN eingeben:");
            string pinStr = Console.ReadLine();
            
            //Bei leerer eingabe setzen wir null
            if(pinStr == "")
                authPin = null;
            //Sonst testen wir, dass die Eingabe auch eine ganzzahl ist und parsen den Wert
            else
            {
                try
                {
                    authPin = int.Parse(pinStr);
                }
                catch(Exception)
                {
                    Console.WriteLine("ERROR: Kein valider PIN!");
                    return false;
                }
            }

            //Wenn der eingegebene PIN korrekt ist (also entweder die richtige Ganzzahl oder wenn beides null ist)
            if(authPin == this.pin)
            {
                //Fehlversuche auf 0 setzen, entsperren und true für die Authentifikation zurück geben
                pinFailures = 0;
                isLocked = false;
                return true;
            }
            else
            {
                //Fehlversuche inkrementieren und falsch zurück geben
                pinFailures++;
                Console.WriteLine($"Falscher PIN! Nur noch {4 - pinFailures} Versuche");
                return false;
            }
            
        }

        public void lockSmartphone()
        {
            isLocked = true;
        }
    
        public void pinSetzen()
        {
            Console.WriteLine("Neuen PIN setzen...");

            //Smartphone sperren, damit sich der Nutzer authentifizieren muss
            this.lockSmartphone();

            //Abbrechen, wenn die Authentifizierung nicht erfolgreich ist
            if(!authentifizierung())
            {
                Console.WriteLine("Authentifizierung fehlgeschlagen!");
                return;
            }

            //Sonst: neuen PIN eingeben wie auch bei der Authentifizierung
            int? pinNew;
            Console.WriteLine("Authentifizierung erfolgreich. Bitte neuen PIN eingeben:");
            string pinStr = Console.ReadLine();
            //Bei leerer eingabe setzen wir null
            if(pinStr == "")
                pinNew = null;
            //Sonst testen wir, dass die Eingabe auch eine ganzzahl ist und parsen den Wert
            else
            {
                try
                {
                    pinNew = int.Parse(pinStr);
                }
                catch(Exception)
                {
                    Console.WriteLine("ERROR: Kein valider PIN!");
                    return;
                }
            }

            //neuen PIN setzen
            this.pin = pinNew;
            Console.WriteLine("PIN erfolgreich geändert");
        }

        public override string ToString()
        {
            if(this.isLocked)
                return "Smartphone is locked";
            else
                return "Smartphone is not locked";
        }
    }
}