namespace studentBlackboardSimple
{
    public class Owner
    {
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public static int _ownerId;

        public Owner(string name)
        {
            Name = name;
            SetId();
        }

        public void SetId()
        {
            OwnerId = _ownerId++;
        }

        public override string ToString()
        {
            return $"Owner name {Name}, ID Number {OwnerId}";
        }
    }
}