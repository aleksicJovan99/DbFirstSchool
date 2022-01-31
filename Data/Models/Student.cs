using System;
using System.Collections.Generic;

namespace DbFirstSchool
{
    public partial class Student
    {
        public Student()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public int? SchoolId { get; set; }

        public virtual School? School { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
