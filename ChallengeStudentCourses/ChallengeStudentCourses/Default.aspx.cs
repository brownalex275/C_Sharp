using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var result = "";

            List<Course> courses = new List<Course>()
            {
                new Course {CourseId = 1, Name = "BIOL 101", Students = new List<Student>()
                {   new Student {StudentId = 1, Name = "John Roberts" },
                    new Student {StudentId = 2, Name = "Francisco Marco"} } },
                 new Course {CourseId = 2, Name = "MATH 528", Students = new List<Student>()
                {   new Student {StudentId = 3, Name = "Martin Lawrence" },
                    new Student {StudentId = 4, Name = "Jeff Thompson"} } },
                  new Course {CourseId = 1, Name = "GEOL 101", Students = new List<Student>()
                {   new Student {StudentId = 1, Name = "Simon Powell" },
                    new Student {StudentId = 2, Name = "Dante Boyd"} } }
            };

            foreach (var course in courses)
            {
                result += String.Format("<br />Course: {0} - {1}", course.CourseId, course.Name);

                foreach (var student in course.Students)
                    result += String.Format("<br />&nbsp;&nbsp;Student: {0} - {1}", student.StudentId, student.Name);
            
            }
            resultLabel.Text = result;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var result = "";
            Course course1 = new Course() { CourseId = 1, Name = "Differential Equations" };
            Course course2 = new Course() { CourseId = 2, Name = "Linear Algebra" };
            Course course3 = new Course() { CourseId = 3, Name = "Organic Chemistry I" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student {StudentId = 1, Name = "Ron Johnson",Courses = new List<Course> {course1, course3}} },
                {2, new Student {StudentId = 2, Name = "Ted Jackson",Courses = new List<Course> {course2, course3}} },
                {3, new Student {StudentId = 3, Name = "Michael Robinson",Courses = new List<Course> {course1, course2}} }
            };

            foreach (var student in students)
            {
                result += String.Format("<br /> Student: {0} - {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                    result += String.Format("<br />&nbsp;&nbsp;Course: {0} {1}", course.CourseId, course.Name);
            }

            resultLabel.Text = result;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var result = "";

            List<Student> students = new List<Student>()
            {
                new Student {StudentId = 5, Name = "Ralph Matthews", Courses = new List<Course>() {
                new Course {Name = "Human Physiology 433", Grades = new List<Grade>() {
                    new Grade {grade = 82 } } },
                new Course {Name = "Advanced Macroeconomics 233", Grades = new List<Grade>(){
                    new Grade {grade = 54} } } } },

                new Student {StudentId = 2, Name = "Marty McFly", Courses = new List<Course>() {
                new Course {Name = "Thermodynamics 338", Grades = new List<Grade>() {
                    new Grade {grade = 99 } } },
                new Course {Name = "Relativity and Electromagnetism 177", Grades = new List<Grade>(){
                    new Grade {grade = 88} } } } },

                new Student {StudentId = 13, Name = "Karen Sanders", Courses = new List<Course>() {
                new Course {Name = "Renaissance Art 532", Grades = new List<Grade>() {
                    new Grade {grade = 78 } } },
                new Course {Name = "Roman History 278", Grades = new List<Grade>(){
                    new Grade {grade = 92} } } } }



            };

            foreach (var student in students)
            {
                result += String.Format("<br /> Student: {0} {1}", student.StudentId, student.Name);

                foreach (var course in student.Courses)
                {
                    result += String.Format("<br />Enrolled In: {0} - Grade: ", course.Name);
                    foreach (var grade in course.Grades)
                    {
                        result += String.Format("{0}", grade.grade);
                    }

                }
            }

            resultLabel.Text = result;

        }
    }
}