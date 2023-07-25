using MediatR;
using Students.CQRS.Commands;
using Students.Interfaces;

namespace Students.CQRS.Handlers
{
    public class ActivateStudentHandler : IRequestHandler<ActivateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        public ActivateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task Handle(ActivateStudentCommand request, CancellationToken cancellationToken)
        {
            var user = await _studentRepository.GetByIdAsync(request.Id);
            if (user is null) return;

            user.Activate();
            await _studentRepository.SaveAsync();
        }
    }
}
