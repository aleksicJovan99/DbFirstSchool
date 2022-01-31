using System;
using System.Collections.Generic;

namespace DbFirstSchool
{
    public partial class StudentClass
    {
        public int ListId { get; set; }
        public int? StudentId { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Student? Student { get; set; }
    }
}
