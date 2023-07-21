using Students.Entities;

namespace Students.Interfaces
{
    public interface IStudentRepository
    {
        Task<IReadOnlyCollection<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(Guid id);

        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);

        Task SaveAsync();
    }
}
