using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial11.Models
{
    public class Helper
    {
        static List<Student> students; 
        public Helper()
        {

        }
        public static List<Student> getStudents()
        {
            return students;
        }
        public static void setStudents(List<Student> studs)
        {
            students = studs;
        }

        public static Student getStudent(int StudentId)
        {
            return students.Where(x => x.Id == StudentId).FirstOrDefault();
        }
    }
}
