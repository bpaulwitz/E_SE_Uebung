# Übungslösungen Einführung in die Softwareentwicklung
## Sommersemester 21

### Änderungen für die `launch.json` in VS Code:
um mit F5 zu debuggen und für eine funktionierende Eingabe in der Console ersetzt
```
            "console": "internalConsole",
```
durch
```
            "console": "integratedTerminal",
            "internalConsoleOptions": "neverOpen",
```

### Links:
#### Zur Veranstaltung
- Vorlesung: https://github.com/TUBAF-IfI-LiaScript/VL_Softwareentwicklung
  - (als PDF: https://github.com/TUBAF-IfI-LiaScript/VL_Softwareentwicklung/actions/workflows/GeneratePdf.yml )
    - Bei Github anmelden
    - Neuesten run anklicken
    - output herunterladen und entpacken
- Übungsaufgaben: https://github.com/ComputerScienceLecturesTUBAF

#### Zur Entwicklung
##### Editoren
- Visual Studio 2019: https://visualstudio.microsoft.com/de/downloads/
- Visual Studio Code: https://code.visualstudio.com/download
- Atom: https://atom.io/

##### .NET
- .NET (Framework oder <u>Core</u>): https://dotnet.microsoft.com/download

### Wichtige `dotnet` Befehle
| Funktion                      | Befehl                                                   |
|:------------------------------|:---------------------------------------------------------|
| Hilfe                         | `dotnet --help` oder `man dotnet` (nur Linux)            |
| Hilfe zu einem Befehl         | `dotnet [BEFEHL] --help`                                 |
| SDKs anzeigen                 | `dotnet --list-sdks`                                     |
| Neues Konsolenprojekt anlegen | `dotnet new console` bzw. `dotnet new console -n [NAME]` |
| Neu linken/ Abhäng. erstellen | `dotnet restore`                                         |
| Projekt erstellen             | `dotnet build [PROJEKT].csproj `                         |
