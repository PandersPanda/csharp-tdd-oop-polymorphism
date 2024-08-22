using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_polymorphism.CSharp.Main;

namespace Products
{
    public class Game : IProduct
    {
        public string name {  get; set; }
        public int price { get; set; }

        public Game(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
