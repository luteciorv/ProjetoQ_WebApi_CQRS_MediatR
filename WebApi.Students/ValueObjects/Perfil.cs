using Students.Enums;

namespace Students.ValueObjects
{
    public class Perfil
    {
        public Perfil(string firstName, string lastName, EGender gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public EGender Gender { get; private set; }
        public int Age { get; private set; }

        internal void Update(string firstName, string lastName, int gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = (EGender)gender;
            Age = age;
        }
    }
}
