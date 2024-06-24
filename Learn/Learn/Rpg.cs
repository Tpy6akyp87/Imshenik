using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class Rpg : Game
    {
        public Rpg(string name, string country, int price) 
        {
            this.Name = name;
            this.Company = country;
            this.Price = price;
            Console.WriteLine("obj created");
        } 
        protected override object Description()
        {
            return new object();
        }
    }
}
