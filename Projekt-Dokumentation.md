# Projekt-Dokumentation
Damian Eisenring und Jan Frey

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt
Wir Programmieren einen "Frick-Renner", der wie ein Pferderennenn agiert, aber anstatt Pferde rennen unsere Kollegen um den Sieg.
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1|Muss|Funktional|Als Benutzer möchte ich verschiedene Kollegen im Spiel haben.|
|2|Muss|Funktional|Als Benutzer möchte ich auf einen der verschiedenen Kollegen wetten können.|
|3|Muss|Qualität|Als Benutzer möchte ich, dass das Rennen so spannend wie möglich ist.|
|4|Muss|Qualität|Als Benutzer möchte ich am Ende des Spiels eine Rangliste sehen.|
|5|Kann|Qualität|Als Benutzer möchte ich, dass die verschiedenen Kollegen unterschiedliche Fähigkeiten besitzen. |
|6|Kann|Qualität|Als Benutzer möchte ich, dass die Fähigkeiten alle gleich Stark sind.|
|7|Kann|Qualität|Als Benutzer möchte ich auswählen können, wie viele der Kollegen beim rennen teilnehmen.|
|8|Kann|Qualität|Als Benutzer möchte ich auf die Teilnehmerzahl angepasste gewinne erhalten. Das heisst, dass es eine grössere Gewinnausschöpfung bei grösserer Teilnehmerzahl geben soll.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1|Benutzer startet das Spiel|-|Verschiedene Kollegen befinden sich im Spiel.|
|2.1|Benuutzer startet das Spiel|-|Benutzer kann auf Kollegen wettetn.|
|3.1|Benutzer startet das Spiel|Benutzer setzt Wetteinsatz auf eine Person|Spiel startet.|
|4.1|Benutzer hat Wetteinsatz gesetzt, Spiel hat gestartet|-|Spiel endet, Rangliste wird angezeigt.|
|5.1|Benutzer hat Spiel gestartet|Benutzer setzt seinenn Wetteinsatz|Spiel beginnt, Kollegen nutzen ihre Fähigkeiten.|
|6.1|Benutzer hat Spiel gestartet|Benutzer setzt seinenn Wetteinsatz|Spiel ist fair, kein Kollege ist zu Stark.|
|7.1|Benutzer  startet das Spiel|-|Auswahlmöglichkeit der Anzahl Kollegen.
|8.1|Benutzer startet das Spiel|Wählt Anzahl Kollegen aus und setzt Wetteinsatz|Benutzer erhählt angepasste Gewinne, jenachdem wie viele Kollegen teilnehmen.|

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
