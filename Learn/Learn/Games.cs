using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Learn
{
    public abstract class Game
    {
        public string? Name { get; set; }
        public string? Company { get; set; }
        public int Price { get; set; }
        public void Preparation()
        {
            var des = Description();
            AddDescription(des);
            SetDescription(des);
        }
        private void AddDescription(object des)
        {
            Console.WriteLine("Добавил описание");
        }
        private void SetDescription(object des) 
        {
            Console.WriteLine("Установил описание");
        }

        protected abstract object Description();        
    }
}
