using System;
using System.Threading;
using System.IO;

public class Computer
{
    //RNG für die zufälligen Abstürze
    private Random randomNumberGenerator;
    //internes Feld für die IP Adresse
    private byte[] ipAddress;

    //nach außen lesbare string-Property der IP Adresse
    public string ip
    {
        get
        {
            return IPTools.IPToString(ipAddress);
        }
        set
        {
            ipAddress = IPTools.IPToArray(value);
        }
    }
    public string userName
    {
        get;
        private set;
    }
    public bool failedSaving
    {
        get;
        private set;
    }

    //Konstruktor
    public Computer()
    {
        userName = "Administrator";
        failedSaving = false;
        ipAddress = IPTools.Localhost;
        randomNumberGenerator = new Random();
    }

    public void switchUser(string user)
    {
        Console.WriteLine("Logging out...");
        //1 sek warten
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + user);
        userName = user;
    }

    public void saveFile(string path, string fileName)
    {
        Console.WriteLine("Saving file: " + Path.Combine(path, fileName));

        //Wenn im Fehlerzustand oder Zufallszahl (im Bereich [0,1]) unter 0.25 ist
        if(failedSaving || randomNumberGenerator.NextDouble() <= 0.25)
        {
            //Fehlerzustand erreichen und InvalidOperationException werfen
            failedSaving = true;
            throw new InvalidOperationException("Failed to save file " + fileName);
        }
    }

    public void saveFile(string fileName)
    {
        //Überladene Methode mit dem Desktop Verzeichnis aufrufen
        string desktop = Path.Combine("C:", "Benutzer", userName, "Desktop");
        this.saveFile(desktop, fileName);
    }

    public void reboot()
    {
        Console.WriteLine("Rebooting...");
        //1 sek warten
        Thread.Sleep(1000);
        Console.WriteLine("Logging in as " + userName);
        //Fehlerzustand zurücksetzen
        failedSaving = false;
    }

    //out-Parameter: wird beim Methodenaufruf überschrieben
    public void burn(string name, string content, out Blu_Ray bluRay)
    {
        bluRay = new Blu_Ray(name, content);
    }

    public void print()
    {
        Console.WriteLine("Benutzer: " + userName +
            "\nIP-Adresse: " + ip +
            $"\nAbsturzzustand: {failedSaving}");
    }
}