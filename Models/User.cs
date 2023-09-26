namespace Library.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public bool IsBlocked { get; private set; } = false;
        public int lateReturns { get; private set; } = 0;
        public User(string name)
        {
            Name = name;
            Id = 1;
        }

        public void lateReturn()
        {
            lateReturns++;
        }

        public void blockUser()
        {
            IsBlocked = true;
        }
    }
}
