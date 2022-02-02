using System;

namespace MusterlösungÜbung
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
            Console.WriteLine("Geben sie ein mindest Alter an");
            int minAlter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie ein maximal Alter an");
            int maxAlter = Convert.ToInt32(Console.ReadLine());

            int alterSpanne = AlterSpanne(maxAlter,minAlter);
            int[] alterRahmen = new int[alterSpanne];

            for (int i = 0; i < alterRahmen.Length; i++)
            {
                alterRahmen[i] = maxAlter;
                maxAlter--;
            }

            Console.WriteLine("Wie alt ist die Person");
            int alter = Convert.ToInt32(Console.ReadLine());

            bool alterImRahmen = AlterImRahmen(alterRahmen, alter);

            char geschlecht = Geschlecht();
            string geschlechtAusgeschriben = AusgeschribenesGeschlecht(geschlecht);

            Console.WriteLine("Wie heißt die Person");
            string name = Console.ReadLine();


            string anrede = Anrede();
            

            
            if(alterImRahmen)
                Console.WriteLine($"{anrede} {name} sie sind {geschlechtAusgeschriben} und  {alter} jahre alt und liegen somit im vorgesehenem altersbereich von {minAlter} bis {maxAlter}");
            else
                Console.WriteLine($"{anrede} {name} sie sind {geschlechtAusgeschriben} und  {alter} jahre alt und liegen somit nicht im vorgesehenem altersbereich von {minAlter} bis {maxAlter}");


        }

       /// <summary>
       /// Prüft in welchem Raum Sich das alter der Person befindet
       /// </summary>
       /// <returns>int Zwischenwert von min und max alter</returns>
       /// <exception cref="ArgumentException"></exception>
        static int AlterSpanne(int maxAlter,int minAlter)
        {

            int alterSpanne = 0;

            if (maxAlter < minAlter)
            {
                throw new ArgumentException("Das max alter darf nicht über dem min alter liegen");
            }
            if (minAlter < 0 || maxAlter < 0)
            {
                throw new ArgumentException("Das alter einer person kan nicht unter 0 liegen");
            }
            if (minAlter > 200 || maxAlter > 200)
            {
                throw new ArgumentException("Das alter einer person kann nicht bei über 200 liegen");
            }

            for (int i = minAlter; i <= maxAlter; i++)
            {
                alterSpanne++;
            }

            return alterSpanne;
        }

        /// <summary>
        /// Vordert die eingabe einer anrede
        /// </summary>
        /// <returns>anrede für den text string</returns>
        static string Anrede()
        {
            
            Console.WriteLine("Geben sie bitte eine anrede für die gewünschte person ein");
            
            string anrede = Console.ReadLine();

            return anrede;
        }

        /// <summary>
        /// Prüft ob das Alter im erlaubten raum ist
        /// </summary>
        /// <param name="erlaubtesAlter"></param>
        /// <param name="alter"></param>
        /// <returns>Ob das alter erlaubt ist wen true dan im rahmen ansonsten false</returns>
        static bool AlterImRahmen(int[] erlaubtesAlter, int alter)
        {
            bool alterErlaubt = false;

            for (int i = 0; i < erlaubtesAlter.Length; i++)
            {
                if (erlaubtesAlter[i] == alter)
                {
                    alterErlaubt = true;
                }
            }
            return alterErlaubt;
        }

        /// <summary>
        /// Gibt das zeichen für das geschlecht zurück
        /// </summary>
        /// <returns>m/w/d</returns>
        static char Geschlecht()
        { 
            Console.WriteLine("Geben sie bitte m,w,d ein");

            char zeichen = Convert.ToChar(Console.ReadLine());

            if(zeichen != 'm'&& zeichen != 'w' && zeichen != 'd')
                {
                throw new ArgumentException("Das geschlecht war nicht richtig");

            }

            return zeichen;
        }

        /// <summary>
        /// Prüft welches zeichen bei geschlecht(); genommen wurde und schreibt es aus
        /// </summary>
        /// <param name="zeichen"></param>
        /// <returns>Männlich/Weiblich/Divers</returns>
        static string AusgeschribenesGeschlecht(char zeichen)
        {
            string ausgeschribenesGeschlecht = "";
            switch(zeichen)
            {
                case 'm':
                    ausgeschribenesGeschlecht = "Männlich";
                    break;
                case 'w':
                    ausgeschribenesGeschlecht = "Weiblich";
                    break;
                case 'd':
                    ausgeschribenesGeschlecht = "Divers";
                    break;
                    
            }
            return ausgeschribenesGeschlecht;
        }
    }
}
