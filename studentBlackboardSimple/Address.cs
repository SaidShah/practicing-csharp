using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace studentBlackboardSimple
{
    [Serializable()]
    public class Address:ISerializable // implementing the ISerializable interface
    {
        // has a houseNumber, streetName, city, state, zip
        
        private int HouseNumber { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private int Zipcode { get; set; }
        private string StreetName { get; set; }
        
        public Address(int houseNumber, string streetName, string city, string state, int zipcode)
        {
            HouseNumber = houseNumber;
            StreetName = streetName;
            City = city;
            State = state;
            Zipcode = zipcode;
        }

        public override string ToString()
        {
            return $"{HouseNumber} {StreetName} {City} {State} {Zipcode} \n";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("HouseNumber",HouseNumber);
            info.AddValue("City",City);
            info.AddValue("State",State);
            info.AddValue("Zipcode",Zipcode);
            info.AddValue("StreetName",StreetName);
        }

        public Address(SerializationInfo info, StreamingContext context)
        {
            HouseNumber = (int) info.GetValue("HouseNumber",typeof(int));
            City = (string) info.GetValue("City", typeof(string));
            State = (string) info.GetValue("State", typeof(string));
            Zipcode = (int) info.GetValue("Zipcode", typeof(int));
            StreetName = (string) info.GetValue("StreetName", typeof(string));
        }

    }
} 