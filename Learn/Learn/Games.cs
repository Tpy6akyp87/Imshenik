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
        public void ToSale()
        {
            var staff = StaffToSale();
            SmthMethod(staff);
        }
        private void SmthMethod(object staff) { }
        
        protected abstract object StaffToSale();        
    }
}
