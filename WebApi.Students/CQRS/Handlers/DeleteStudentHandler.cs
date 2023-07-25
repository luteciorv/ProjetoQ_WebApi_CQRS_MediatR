using MediatR;
using Students.CQRS.Commands;
using Students.Interfaces;

namespace Students.CQRS.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);
            if (student is null) return;

            student.Delete();
            await _studentRepository.SaveAsync();
        }
    }
}
