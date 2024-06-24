namespace Learn
{
    public class Arpg : Rpg
    {     

        public Arpg(string name, string country, int price) : base(name, country, price)
        {
        }

        protected override object Description()
        {
            var des = base.Description();
            var rating = AddRating(des);
            return rating;
        }
        private object AddRating(object des)
        {
            Console.WriteLine("Рейтинг добавлен");
            return des;           
        }
    }
}
