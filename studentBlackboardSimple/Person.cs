using System.ComponentModel.Design;
using System.Text;

namespace studentBlackboardSimple
{
    public class Person
    {
        // has an id, phone, Name, Address and static idCounter to set each id
        private static int _idCounter=1;
        private Name Name { get; set; }
        private Address Address { get; set; }
        public string _id;

        public Person(Name name, Address address)
        {
            Name = name;
            Address = address;
            CreateId();
        }

        private void CreateId()
        {
            var temp = "00000";
            _id = $"{temp}{_idCounter}";
            _idCounter++;
        }

        public override string ToString()
        {
            return $"{Name}, {Address}, ID Number: {_id}\n";
        }
    }
}