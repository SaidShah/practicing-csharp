using System;
using System.ComponentModel.Design;
using System.Text;
using System.Runtime.Serialization;

namespace studentBlackboardSimple
{
    [Serializable]
    public class Person:ISerializable
    {
        // has an id, phone, Name, Address and static idCounter to set each id
        private static int _idCounter=1;
        private Name Name { get; set; }
        private Address Address { get; set; }
        public string _id;

        public Person()
        {
            
        }

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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",Name);
            info.AddValue("Address",Address);
            info.AddValue("_id",_id);
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = (Name) info.GetValue("Name", typeof(Name));
            Address = (Address) info.GetValue("Address", typeof(Address));
            _id = (string) info.GetValue("_id", typeof(string));
        }
    }
}