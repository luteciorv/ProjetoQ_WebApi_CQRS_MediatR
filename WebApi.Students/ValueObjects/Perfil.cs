using Students.Enums;

namespace Students.ValueObjects
{
    public record Perfil(string FirstName, string LastName, EGender Gender, int Age);
}
