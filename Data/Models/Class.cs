using System;
using System.Collections.Generic;

namespace DbFirstSchool
{
    public partial class Class
    {
        public Class()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; } = null!;
        
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
