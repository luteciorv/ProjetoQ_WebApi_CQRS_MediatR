namespace Students.ValueObjects
{
    public class Address
    {
        public Address(string country, string city, string state, string zipCode, string street, string number)
        {
            Country = country;
            City = city;
            State = state;
            ZipCode = zipCode;
            Street = street;
            Number = number;
        }

        public string Country { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }

        internal void Update(string country, string city, string zipCode, string street, string number)
        {
            Country = country;
            City = city;
            ZipCode = zipCode;
            Street = street;
            Number = number;

        }

        public override string ToString() =>
                $"{Country} - {City}/{State} ({ZipCode}) - {Street} . {Number}";
    }
}
