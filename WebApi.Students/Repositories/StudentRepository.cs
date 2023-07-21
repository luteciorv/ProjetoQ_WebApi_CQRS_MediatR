using Microsoft.EntityFrameworkCore;
using Students.Context;
using Students.Entities;
using Students.Interfaces;

namespace Students.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _dataContext;

        public StudentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IReadOnlyCollection<Student>> GetAllAsync() =>
            await _dataContext.Students.ToListAsync();

        public async Task<Student?> GetByIdAsync(Guid id) =>
            await _dataContext.Students.FindAsync(id);


        public void Add(Student student) =>
            _dataContext.Students.Add(student);

        public void Delete(Student student) =>
            _dataContext.Students.Remove(student);

        public void Update(Student student) =>
            _dataContext.Students.Update(student);

        public async Task SaveAsync() =>
            await _dataContext.SaveChangesAsync();
    }
}
