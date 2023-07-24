using MediatR;
using Students.Entities;

namespace Students.CQRS.Queries
{
    public class GetStudentsQuery : IRequest<IReadOnlyCollection<Student>>
    {

    }
}
