namespace Library
{
    public class Book : Item
    {
        public int NumberOfPages { get; set; }
        public BookTypes BookType;
        public Book(int id, string name, int numberOfPages, BookTypes bookType) : base(id, name) 
        {
            NumberOfPages = numberOfPages;
            BookType = bookType;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, pages: {NumberOfPages}, category: {BookType.ToString()}";
        }
    }
}
