﻿using System;

namespace OhneHilfe
{
   #region Erklärung
    /* 

Erfragen sie in der konsole was dam mindest alter und das max alter sein sollen

Erstellen sie eine int methode in der sie den zwischenraum des min und max wertes übergeben den sie voher abfragen 
schreiben sie eine argument exeption wen das max alter über dem min alter ist
schreiben sie außerdem eine argumentexeption daführ wen min oder max unter 0 liegen oder über 200

die spanne zwischen beider werten gilt als index des arrays welchen sie nun befühllen mit den zahlen vom min bis max wertes

Fragen sie nun nach dem alter der Person und erstellen sie eine bool funktion in der sie prüfen ob das gegebene alter 
im zwischenraum liegt mit hilfe des eben erstellten arrays

Erstellen sie eine char function in der sie nach dem geschlächt fragen überprüfen sie dort ob das zeichen m w oder d ist
ansonsten geben sie eine argument exeption aus

erstellen sie nun eine string methode in der sie den char übergeben und als ausgeschriebenes geschlächt zurück beckommen

fragen sie nun nach einem Namen

erstellen sie jetzt eine string methode in der sie nach einer anrede fragen

Erstellen sie nun die ausgabe : 

Wen das Alter im Rahmen liegt und der bool true zurück gibt=
            Console.WriteLine($"{anrede} {name} sie sind {geschlechtAusgeschriben} und  {alter} jahre alt und liegen somit im vorgesehenem altersbereich von {minAlter} bis {maxAlter}");
        else
            Console.WriteLine($"{anrede} {name} sie sind {geschlechtAusgeschriben} und  {alter} jahre alt und liegen somit nicht im vorgesehenem altersbereich von {minAlter} bis {maxAlter}");

 */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
