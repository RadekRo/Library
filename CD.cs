namespace Library
{
    public class CD : Item
    {
        public int NumberOfTracks { get; set; }
        public CD(int id, string name, int numberOfTracks) : base(id, name)
        {
            NumberOfTracks = numberOfTracks;
        }
    }
}
