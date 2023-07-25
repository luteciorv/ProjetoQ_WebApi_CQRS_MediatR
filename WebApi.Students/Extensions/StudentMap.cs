using Students.CQRS.Commands;
using Students.DTOs;
using Students.Entities;

namespace Students.Extensions
{
    public static class StudentMap
    {
        public static CreateStudentCommand MapToCreateStudentCommand(this CreateStudentDto dto) =>
            new(dto.FirstName, dto.LastName, dto.Gender, dto.Age, dto.Email, dto.Country, dto.ZipCode, dto.City, dto.State, dto.Street, dto.Number);

        public static UpdateStudentCommand MapToUpdateStudentCommand(this UpdateStudentDto dto, Guid id) =>
            new(id, dto.FirstName, dto.LastName, dto.Gender, dto.Age, dto.Email, dto.Country, dto.ZipCode, dto.City, dto.State, dto.Street, dto.Number);

        public static ReadStudentDto MapToReadStudentDto(this Student entity) =>
            new(entity.Id,
                $"{entity.Perfil.FirstName} {entity.Perfil.LastName}",
                entity.Perfil.Gender.MapToString(),
                entity.Perfil.Age,
                entity.Email.Address,
                entity.Address.ToString());
    }
}
