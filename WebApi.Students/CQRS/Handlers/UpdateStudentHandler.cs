using MediatR;
using Students.CQRS.Commands;
using Students.Interfaces;

namespace Students.CQRS.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);
            if (student is null) return;

            student.Update(request.FirstName, request.LastName, request.Gender, request.Age, request.Email, request.Country, request.State, request.City, request.ZipCode, request.Street, request.Number);

            _studentRepository.Update(student);
            await _studentRepository.SaveAsync();
        }
    }
}
