using MediatR;

namespace Students.CQRS.Commands
{
    public class ActivateStudentCommand : IRequest
    {
        public ActivateStudentCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
