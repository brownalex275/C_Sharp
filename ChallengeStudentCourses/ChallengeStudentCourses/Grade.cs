using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Grade
    {
        
        public int grade { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
        
    }
}