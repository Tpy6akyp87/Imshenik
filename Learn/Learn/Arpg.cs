namespace Learn
{
    public class Arpg : Rpg
    {
        protected override object StaffToSale()
        {
            var staff = base.StaffToSale();
            var actStuff = Actioned(staff);
            return base.StaffToSale();
        }
        private object Actioned(object stuff)
        {
            return stuff;
        }
    }
}
