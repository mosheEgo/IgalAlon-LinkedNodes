using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut2025_271_LinkedNodes
{
    internal class Store
    {
        private Node<Game> lst;
        public Store(Node<Game> lst)
        {
            this.lst = lst;
        }
        public Node<Game> GetLst()
        {
            return this.lst;
        }
        public void SetLst(Node<Game> lst)
        {
            this.lst = lst;
        }
        //=======================================================
        // סעיף א
        //=======================================================
        public int Remove(int n, int pr)
        {
            int count = 0;

            // ==========================
            // שלב 1: מחיקה מהראש
            // ==========================
            while (this.lst != null &&
                   count < n &&
                   this.lst.GetValue().GetPrice() == pr)
            {
                this.lst = this.lst.GetNext(); // מדלגים על הראש
                count++;
            }

            //חוליות אז מסיימים n אם הרשימה התרוקנה או כבר נמחקו   
            if (this.lst == null || count == n)
                return count;

            // ==========================
            // שלב 2: מחיקה באמצע השרשרת
            // ==========================
            Node<Game> current = this.lst;

            while (current != null && current.GetNext() != null && count < n)
            {
                if (current.GetNext().GetValue().GetPrice() == pr)
                {
                    // מחיקה: מדלגים על הצומת הבא
                    current.SetNext(current.GetNext().GetNext());
                    count++;
                }
                else
                {
                    current = current.GetNext();
                }
            }
            return count;
        }
        //========================================================
        // סעיף ב
        //========================================================

        //:(קודם ניצור פעולת עזר (לא חובה
        // מציאת המחיר המינימלי בשרשרת
        private int FindMinPrice()
        {
            int min = this.lst.GetValue().GetPrice();
            Node<Game> current = this.lst.GetNext();

            while (current != null)
            {
                int price = current.GetValue().GetPrice();
                if (price < min)
                    min = price;

                current = current.GetNext();
            }
            return min;
        }
        // 
        public int RemoveCheap(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int minPrice = FindMinPrice();            // המחיר הזול ביותר כרגע
                int deletedGames = Remove(num, minPrice); // מוחקים משחקים במחיר הזה
                sum += deletedGames * minPrice;           // מוסיפים לסכום
                num -= deletedGames;                      // מפחיתים את כמות הנמחקים
            }
            return sum;
        }
        public override string ToString()
        {
            return lst.ToString();
        }
    }
}
