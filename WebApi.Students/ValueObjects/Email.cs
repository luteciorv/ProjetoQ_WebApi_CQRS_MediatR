namespace Students.ValueObjects
{
    public record Email
    {
        public Email(string address)
        {
            Address = address;
            Confirmed = false;
        }

        public string Address { get; private set; }
        public bool Confirmed { get; private set; }

        public void Confirm() => Confirmed = true;
    }
}
