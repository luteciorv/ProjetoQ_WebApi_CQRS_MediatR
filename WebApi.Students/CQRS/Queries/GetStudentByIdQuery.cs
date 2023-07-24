using MediatR;
using Students.Entities;

namespace Students.CQRS.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public Guid Id { get; set; }
    }
}
