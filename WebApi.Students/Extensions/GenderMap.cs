using Students.Enums;

namespace Students.Extensions
{
    public static class GenderMap
    {
        public static string MapToString(this EGender gender)
        {
            return gender switch
            {
                EGender.Male => "Male",
                EGender.Female => "Female",
                EGender.PreferNotToSay => "Prefer not to say",
                _ => throw new Exception("Gênero não identificado"),
            };
        }
    }
}
