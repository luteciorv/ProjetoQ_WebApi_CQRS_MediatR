using MediatR;
using Students.DTOs;

namespace Students.CQRS.Queries
{
    public class GetStudentsQuery : IRequest<IReadOnlyCollection<ReadStudentDto>>
    {
    }
}
