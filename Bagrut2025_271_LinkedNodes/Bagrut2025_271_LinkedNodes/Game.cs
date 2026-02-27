using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut2025_271_LinkedNodes
{
    internal class Game
    {
        private string name;
        private int price;
        public Game(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetPrice()
        {
            return this.price;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public override string ToString()
        {
            return $"{this.name} price: {this.price}";
        }
    }
}
