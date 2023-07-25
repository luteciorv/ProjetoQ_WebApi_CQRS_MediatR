using MediatR;
using Students.CQRS.Commands;
using Students.Entities;
using Students.Interfaces;
using Students.ValueObjects;

namespace Students.CQRS.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var perfil = new Perfil(request.FirstName, request.LastName, (Enums.EGender) request.Gender, request.Age);
            var email = new Email(request.Email);
            var address = new Address(request.Country, request.City, request.State, request.ZipCode, request.Street, request.Number);

            var student = new Student(perfil, email, address);

            _studentRepository.Add(student);
            await _studentRepository.SaveAsync();

            request.GeneratedId = student.Id;
        }
    }
}
