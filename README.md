# WCF á la Microsoft

***Dient nur zu Schulungszwecken***<p>

Es werden ein Service und ein Client erstellt. Der Service hat lediglich zwei Methoden. Deren Kapselung erfolgte per `svcutil.exe`. Die so erzeugte `Service.cs` wurde dann einfach ins Client-Projekt übernommen. Die in der `output.config` erzeugten Einträge wurden in die `App.config` kopiert.
Nun gibt der Web-Dienst die aktuellen Pausenzeiten aus und je nachdem, ob die Zahl gerade ist, erscheint dass aktuell pause ist.


<p>
***
--> _Keine Fehlerbehandlung!!_