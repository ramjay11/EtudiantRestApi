using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtudiantRestApi
{
    public class Etudiant
    {
        public int EtudiantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhhotoPath { get; set; }
    }
}
