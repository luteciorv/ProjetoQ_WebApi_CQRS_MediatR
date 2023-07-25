using Students.ValueObjects;

namespace Students.Entities
{
    public sealed class Student : EntityBase
    {
        private Student() { }

        public Student(Perfil perfil, Email email, Address address)
        {
            Perfil = perfil;
            Email = email;
            Address = address;
        }

        public Perfil Perfil { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }

        public void Update(string firstName, string lastName, int gender, int age, string email, string country, string state, string city, string zipCode, string street, string number)
        {
            Perfil.Update(firstName, lastName, gender, age);
            Email.Update(email);
            Address.Update(country, city, zipCode, street, number);
            UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            Activated = false;
            DeletedAt = DateTime.Now;
        }

        public void Activate()
        {
            Activated = true;
            DeletedAt = null;
            UpdatedAt = DateTime.Now;
        }
    }
}
