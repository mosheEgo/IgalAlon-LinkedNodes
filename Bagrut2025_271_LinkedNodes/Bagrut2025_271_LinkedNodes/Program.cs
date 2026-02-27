using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut2025_271_LinkedNodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---בפעולה הראשית נבדוק שהכול עובד---
            //---זה לא חלק מדרישות שאלת הבגרות---
            //---אבל זה מאוד מומלץ לחיזוק ההבנה---


            //קודם ניצור 7 משחקים כמו בדוגמה בשאלה
            //ואז נכניס אותם בחוליות
            Game g1 = new Game("g1", 30);
            Game g2 = new Game("g2", 30);
            Game g3 = new Game("g3", 27);
            Game g4 = new Game("g4", 99);
            Game g5 = new Game("g5", 30);
            Game g6 = new Game("g6", 25);
            Game g7 = new Game("g7", 30);

            //עכשיו נכניס אותם כערכים בתוך חוליות
            Node<Game> game1 = new Node<Game>(g1);
            Node<Game> game2 = new Node<Game>(g2);
            Node<Game> game3 = new Node<Game>(g3);
            Node<Game> game4 = new Node<Game>(g4);
            Node<Game> game5 = new Node<Game>(g5);
            Node<Game> game6 = new Node<Game>(g6);
            Node<Game> game7 = new Node<Game>(g7);

            //נקבע את חוליית הראש
            Node<Game> lst = game1;

            //נקשור את החוליות זה לזה ליצירת שרשרת
            game1.SetNext(game2);
            game2.SetNext(game3);
            game3.SetNext(game4);
            game4.SetNext(game5);
            game5.SetNext(game6);
            game6.SetNext(game7);

            //ניצור עצם של חנות ונעביר לה 
            //את השרשרת שיצרנו
            Store s1 = new Store(lst);  //עבור בדיקת סעיף א
            Store s2 = new Store(lst);  //עבור בדיקת סעיף ב

            //נדפיס את הרשימה לפני מחיקה
            Console.WriteLine("Original List Of Games");
            Console.WriteLine($"======================\n{lst}");
            
            //ונעביר לה Remove נקרא לפעולה 
            //:שני נתונים כמו בשאלה
            //n = 3, pr = 30
            int deleted = s1.Remove(3, 30);

            //נדפיס את הרשימה אחרי מחיקה
            Console.WriteLine("\nNew List Of Games");
            Console.WriteLine($"=================\n{s1}");

            //נציג כמה נמחקו מהרשימה המקורית
            Console.WriteLine($"\nThe {deleted} cheapest games were deleted from the original list!");

            //נציג את סכום המשחקים שנמחקו
            //RemoveCheap ניעזר בקריאה לפעולה
            //num = 5 ונעביר לה
            Console.WriteLine($"Sum Of deleted games: {s2.RemoveCheap(5)}");
        }
    }
}
