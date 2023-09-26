using System.Diagnostics.Contracts;

namespace Library.Models
{
    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"id: {Id} title: {Name}";
        }
    }
}
