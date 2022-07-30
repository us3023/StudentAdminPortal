using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.DomainModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOFBirth { get; set; }

        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }
        //navigation properties
         public Gender Gender { get; set; }
         public Address Address { get; set; }
    }
}
