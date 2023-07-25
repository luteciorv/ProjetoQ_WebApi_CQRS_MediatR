using MediatR;
using Students.DTOs;

namespace Students.CQRS.Queries
{
    public class GetStudentByIdQuery : IRequest<ReadStudentDto>
    {
        public GetStudentByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
