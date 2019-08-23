namespace studentBlackboardSimple
{
    public class Textbook
    {
        // has title, Name, published, isbn, price

        private string Title { get; set; }
        private Name Name { get; set; }
        private bool Published { get; set; }
        private string Isbn { get; set; }
        private double Price { get; set; }

        public Textbook(string title, Name name, bool published, string isbn, double price)
        {
            Title = title;
            Name = name;
            Published = published;
            Isbn = isbn;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} By: {Name} ISBN: {Isbn} ${Price} \n";
        }
    }
}