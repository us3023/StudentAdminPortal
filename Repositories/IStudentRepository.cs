using StudentAdminPortal.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
