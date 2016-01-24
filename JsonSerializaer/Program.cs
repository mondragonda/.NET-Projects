using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Json;

namespace JsonSerializaer
{
    class Program
    {
        static void Main(string[] args)
        {
            String jsonString = File.ReadAllText("student.json");
            //comment

            Student student = new Student();
            student.Id = 232425;
            student.Name = "Diego Mondragon";
            student.Age = 22;
            student.Courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "Software Engineering",
                },

                new Course()
                {
                    Id = 2,
                    Name = "Quality and Assurance",
                },
            };


            string serialization = JsonParser.Serialize<Student>(student);

            File.WriteAllText("newstudent.json", serialization);

        }
    }
}
