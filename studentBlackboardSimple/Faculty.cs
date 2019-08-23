namespace studentBlackboardSimple
{
    public class Faculty:Person
    {
        private Name Name { get; set; }
        private Address Address { get; set; }
        private string PhoneNumber { get; set; }
        private string Major { get; set; }
        public string Salary { get; set; }

        public Faculty(Name name, Address address, string phoneNumber, string major) : base(name,
            address)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Major = major;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Salary))
            {
                return $"Faculty -> Name {Name} Address: {Address} Phone Number: {PhoneNumber}, Id Number: {_id}\n";
            }
            return $"Faculty -> Name {Name} Address: {Address} Phone Number: {PhoneNumber}, Salary: ${Salary}, Id Number: {_id}\n";
        }
    }
}