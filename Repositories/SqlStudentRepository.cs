using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataModels
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
          // return context.Student.ToList();
           return context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
        }
    }
}
