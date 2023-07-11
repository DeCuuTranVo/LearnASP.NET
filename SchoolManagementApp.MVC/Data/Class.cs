using System;
using System.Collections.Generic;

namespace SchoolManagementApp.MVC.Data;

public partial class Class
{
    public int Id { get; set; }

    public int? LecturerId { get; set; }

    public int? CourseId { get; set; }

    public TimeSpan? Time { get; set; }

    // Navigation property for ForeignKey property CourseId
    public virtual Course? Course { get; set; }

    // Relationship one-to-many: one class can have many enrollment
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    // Navigation property for ForeignKey property LecturerId
    public virtual Lecturer? Lecturer { get; set; }
}
