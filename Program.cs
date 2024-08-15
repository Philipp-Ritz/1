string[,] fullnames = new string[3, 2]; // 3 ist die anzahl der zeilen und 2 die anzahl der spalten


fullnames[0, 0] = "friedrich"; //friedrich ist der vorname und nietsche der nachname
fullnames[0, 1] = "Nietsche"; //0 ist die zeilenkoordinate und 1 die spaltenkoordinate
                               //spalte 0 sind die vornamen und zeile 1 sind die Nachnamen

fullnames[1, 0] = "sigmund";
fullnames[1, 1] = "freud";


fullnames[2, 0] = "karl";
fullnames[2, 1] = "marx";

Console.WriteLine(fullnames[0, 0] + " " + fullnames[0, 1]);
Console.WriteLine(fullnames[1, 0] + " " + fullnames[1, 1]);
Console.WriteLine(fullnames[2, 0] + " " + fullnames[2, 1]);