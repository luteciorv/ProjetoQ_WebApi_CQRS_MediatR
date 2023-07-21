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
    }
}
