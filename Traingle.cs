/***********************************************************************************************
 * Übungsnr:        09                                    
 * Programmname:    StarTriangle                                  
 * Autor:           karlof002  
 * Klasse:          -
 * Datum:           -                              
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Es ist ein Quadrat aus Sternen (*) zu zeichnen. 
 * Der Benutzer kann dabei eingeben, welche Seitenläge das Quadrat besitzen soll.
 * ************************************************
*/
using System;

namespace StarSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int len;
            int colSpaces;
            int lineSpaces;
            int starsInLines;
            string again;

            const int LINES = 30;
            const int COLUMNS = 80;

            Console.SetWindowSize(COLUMNS, LINES);

            do
            {
                Console.Clear();
                Console.WriteLine("Welche Basis soll das Stern-Dreieck besitzen?");
                len = Convert.ToInt32(Console.ReadLine());

                if ((len < 3) || (len > 25))
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
                else
                {
                    lineSpaces = (LINES - len) / 2;
                    

                    Console.Clear();

                    //Leerzeilen vor dem Dreieck schreiben
                    for (int i = 0; i < lineSpaces; i++)
                    {
                        Console.WriteLine();
                    }

                    colSpaces = COLUMNS / 2;
                    //Nun kommen die Zeilen mit den Sternchen
                    for (int line = 1; line <= len; line++) //Äußeres For für die Zeilen
                    {
                        colSpaces--;
                        //Erst Leerzeichen je Zeile:
                        for (int i = 0; i < colSpaces; i++)
                        {
                            Console.Write(" ");
                        }
                        //Jetzt die Sterne für eine Zeile
                        for (int i = 1; i <= line; i++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                Console.WriteLine("Programm nochmal ausführen (J/N)?");
                again = Console.ReadLine();
            } while (again.ToUpper() == "J");

        }
    }
}
