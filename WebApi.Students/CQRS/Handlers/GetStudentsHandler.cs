using MediatR;
using Students.CQRS.Queries;
using Students.Entities;
using Students.Interfaces;

namespace Students.CQRS.Handlers
{
    public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, IReadOnlyCollection<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentsHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IReadOnlyCollection<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetAllAsync();
        }
    }
}
