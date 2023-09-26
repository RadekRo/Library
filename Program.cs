using Library.Enum;
using Library.Models;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book(1, "Fairytale", 250, BookTypes.Novel);
            Console.WriteLine(book);
            LocalResident LocalResidentOne = new("Radek");
            Console.WriteLine(LocalResidentOne.Name);
            Console.WriteLine(LocalResidentOne.Id);
        }
    }
}