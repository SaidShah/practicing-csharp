namespace studentBlackboardSimple
{
    public class Address
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
    }
} 