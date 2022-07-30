using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataModels
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Passeword { get; set; }
        public string Role { get; set; }

        [NotMapped]
        public string Token { get; set; }

    }
}
