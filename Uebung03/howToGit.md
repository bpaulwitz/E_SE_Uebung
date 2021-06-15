1. Rollen zuweisen
2. teams.config anpassen
3. Mainainer - Projekt initialisieren:
    1. Issue anlegen
    2. Issue zuweisen
4. Developer - Implementierung:
    1. Projekt clonen (`git clone [Repository]`)
    2. neuen Branch anlegen (`git checkout -b [neuer Branch, z.B. issue-change-markdown]`)
    3. Änderungen hinzufügen (und ein paar Fehler einbauen, die der Maintainer finden soll)
    4. Änderungen auf dem Branch commiten (`git add [file]`, `git commit -m "[commit-message]"`, `git push origin [Branch]`) - kann auch mehrmals commitet werden
    5. Auf Github: neuen Pull Request eröffnen, als 'base:' Main-Branch und als 'compare:' den neuen Branch auswählen und Kommentar schreiben 
5. Maintainer - Review:
    1. Fehler finden
    2. Review changes - Kommentare dazu schreiben
6. Schritt 4 und 5 wiederholen
7. Maintainer - Deploy
    1. Pull request abschließen -> mergen
    2. Release erstellen
