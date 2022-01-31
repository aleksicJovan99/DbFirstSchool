using System;
using System.Collections.Generic;

namespace DbFirstSchool
{
    public partial class School
    {
        public School()
        {
            Students = new HashSet<Student>();
        }

        public int SchoolId { get; set; }
        public string SchoolName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
