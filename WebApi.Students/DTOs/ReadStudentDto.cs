namespace Students.DTOs
{
    public record ReadStudentDto(Guid Id, string FullName, string Gender, int Age, string Email, string FullAddress);
}
