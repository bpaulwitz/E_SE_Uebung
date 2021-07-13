using System;

public class Blu_Ray
{
    public int id
    {
        get; private set;
    }
    public string name
    {
        get; private set;
    }
    public string content
    {
        get; private set;
    }

    /*
        private -> Nur die Klasse kann darauf zugreifen
        static -> dieses Feld wird von der Klasse (nicht den Objekten der Klasse) verwaltet. Das bedeutet, dass alle Objekte
            dieser Klasse sich dieses Feld 'teilen'. Wenn es ein Objekt ändert, wird es für alle geändert
    */
    private static int idCounter = 0;

    public Blu_Ray(string _name, string _content)
    {
        //statisches int inkrementieren -> erhöht es für alle anderen Objekte
        id = idCounter++;
        name = _name;
        content = _content;
    }
}