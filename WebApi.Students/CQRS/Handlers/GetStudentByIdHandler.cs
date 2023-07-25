using MediatR;
using Students.CQRS.Queries;
using Students.DTOs;
using Students.Extensions;
using Students.Interfaces;

namespace Students.CQRS.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, ReadStudentDto>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<ReadStudentDto> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);
            if(student is null || !student.Activated) return null;

            return student?.MapToReadStudentDto();
        }
    }
}
