using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializaer
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        private List<Course> courses;

        public List<Course> Courses
        {
            get
            {
                if (courses == null)
                {
                    courses = new List<Course>();
                }
                return courses;
            }
            set { courses = value; }
        }

    }
}
