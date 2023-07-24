using Students.CQRS.Commands;
using Students.DTOs;

namespace Students.Extensions
{
    public static class StudentMap
    {
        public static CreateStudentCommand MapToCommand(this CreateStudentDto dto) =>
            new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Age = dto.Age,
                Gender = dto.Gender,
                Country = dto.Country,
                City = dto.City,
                ZipCode = dto.ZipCode,
                Number = dto.Number,
                State = dto.State,
                Street = dto.Street
            };
    }
}
