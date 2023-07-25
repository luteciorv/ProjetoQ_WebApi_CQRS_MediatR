using MediatR;
using Students.CQRS.Queries;
using Students.DTOs;
using Students.Extensions;
using Students.Interfaces;

namespace Students.CQRS.Handlers
{
    public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, IReadOnlyCollection<ReadStudentDto>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentsHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<IReadOnlyCollection<ReadStudentDto>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentRepository.GetAllAsync();
            return students.Where(s => s.Activated).Select(s => s.MapToReadStudentDto()).ToList();
        }
    }
}
