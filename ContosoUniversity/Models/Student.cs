using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        [Column("first_mid_name", TypeName = "varchar(50)")]
        public string FirstMidName { get; set; }
        [Column("enrollment_date", TypeName = "date")]
        public DateTime EnrollmentDate { get; set; }
        [Column("created_at", TypeName = "timestamp")]
        public DateTimeOffset? CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTimeOffset? UpdatedAt { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}