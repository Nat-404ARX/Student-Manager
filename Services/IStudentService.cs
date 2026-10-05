using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudentManager.Models.Entities;

namespace StudentManager.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(Guid id);
        Task CreateAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(Guid id);
    }
}
