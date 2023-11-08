# Projekt-Dokumentation
Damian Eisenring und Jan Frey

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|20.09|0.0.1|Unsere Kollegen wurden in das Spiel implementiert und der Grundaufbau wurde geschaffen.|
|28.10|0.1.0|Das Grundgerüst des Rennens funktioniert.|
|25.10| 1.0.0|Die Fähigkeiten funktionieren und das Spiel ist somit fertig.|

## 1 Informieren

### 1.1 Ihr Projekt
Wir Programmieren einen "Frick-Renner", der wie ein Pferderennenn agiert, aber anstatt Pferde rennen unsere Kollegen um den Sieg.
### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1|Muss|Funktional|Als Benutzer möchte ich verschiedene Kollegen im Spiel haben.|
|2|Muss|Funktional|Als Benutzer möchte ich auf einen der verschiedenen Kollegen wetten können.|
|3|Muss|Qualität|Als Benutzer möchte ich, dass das Rennen so spannend wie möglich ist.|
|4|Muss|Qualität|Als Benutzer möchte ich am Ende des Spiels den Gewinner sehen.|
|5|Kann|Qualität|Als Benutzer möchte ich, dass die verschiedenen Kollegen unterschiedliche Fähigkeiten besitzen. |
|6|Kann|Qualität|Als Benutzer möchte ich, dass die Fähigkeiten alle gleich Stark sind.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1|Benutzer startet das Spiel|-|Verschiedene Kollegen befinden sich im Spiel.|
|2.1|Benuutzer startet das Spiel|-|Benutzer kann auf Kollegen wettetn.|
|3.1|Benutzer startet das Spiel|Benutzer setzt Wetteinsatz auf eine Person|Spiel startet.|
|4.1|Benutzer hat Wetteinsatz gesetzt, Spiel hat gestartet|-|Spiel endet, Rangliste wird angezeigt.|
|5.1|Benutzer hat Spiel gestartet|Benutzer setzt seinenn Wetteinsatz|Spiel beginnt, Kollegen nutzen ihre Fähigkeiten.|
|6.1|Benutzer hat Spiel gestartet|Benutzer setzt seinenn Wetteinsatz|Spiel ist fair, kein Kollege ist zu Stark.|


## 2 Planen
| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|1.A|20.09|Jan Frey|Implementation von Kollegen|90'|
|2.A|20.09|Damian Eisenring|Implementation von Wetten|90'|
|3.A|18.10|Jan Frey|Implementation von spannenden Rennen|180'|
|4.A|25.10|Damian Eisenring|Implementation von Fähigkeiten|180'|
|5.A|25.10|Jan Frey|Balancing der Fähigkeiten|90'|
Total eingeplante Zeit:640'

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |20.09.2023|Jan Frey| 90' |200'|
| 2.A  |20.09.2023|Damian Eisenring|90'|180'|
| 3.A  |18.10.2023|Jan Frey|180' |200'|
| 4.A  |18.10.2023|Damian Eisenring|180' |200'|
| 5.A  |25.10.2023|Jan Frey|90' |100'|

Total tatsächliche Zeit:880'

## 4 Realisieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 2.1  |   06.09.2023  | funktioniert nicht|Damian Eisenring|
| 3.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 4.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 5.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| 6.1  |   06.09.2023  | funktioniert|Damian Eisenring|
| ...  |       |          |        |
