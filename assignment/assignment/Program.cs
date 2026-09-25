
using System.Globalization;
using System.Runtime.CompilerServices;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = StudentRepo.GetStudents();
            //1.Get all students whose Grade is greater than 80
            /*
            var x = s.Where(n => n.Grade > 80);
            foreach (var item in x)
            {
               Console.WriteLine($"id: {item.Id} , name: {item.Name} , age: {item.Age} , grade: {item.Grade}");
            }
            */
            //2. Get the names of students whose Grade is greater than 80.
            /*
            var x = s.Where(n => n.Grade > 80).Select(e=>e.Name);
            foreach (var item in x)
            {
                Console.WriteLine($" name: {item} ");
            }
            */
            //3. Get all students who are in the CS department
            /*
            var x = s.Where(n => n.Department =="CS");
            foreach (var item in x)
            {
                Console.WriteLine($"id: {item.Id} , name: {item.Name} , age: {item.Age} , grade: {item.Grade}, department: {item.Department}");
            }
            */
            //4. Get the names of students whose Age is less than 21
            /*
            var x = s.Where(n => n.Age < 21).Select(e => e.Name);
            foreach (var item in x)
            {
                Console.WriteLine($" name: {item} ");
            }
            */
            //5. Sort all students by Grade from lowest to highest
            /*
            var x = s.OrderBy(n => n.Grade);
            foreach (var item in x)
            {
                Console.WriteLine($"id: {item.Id} , name: {item.Name} , age: {item.Age} , grade: {item.Grade}, department: {item.Department}");
            }
            */
            //6. Sort all students by Grade from highest to lowest
            /*
            var x = s.OrderByDescending(n => n.Grade);
            foreach (var item in x)
            {
                Console.WriteLine($"id: {item.Id} , name: {item.Name} , age: {item.Age} , grade: {item.Grade}, department: {item.Department}");
            }
            */
            //7. Get only the students' names, ordered from the highest Grade to the lowest Grade
            /*
            var x = s.OrderByDescending(n => n.Grade).Select(e => e.Name);
            foreach (var item in x)
            {
                Console.WriteLine($" name: {item} ");
            }
            */
            //8. Count the students whose Grade is greater than or equal to 70
            /*
            int count = s.Where(n => n.Grade >= 70).Count();
            Console.WriteLine($" number all students whose Grade is greater than or equal to 70 : {count} ");
            */
            //9. Calculate the total Grade of all students
            /*
            double sum = s.Sum(e=>e.Grade);
            Console.WriteLine($" total Grade of all students : {sum} ");
            */
            //10. Calculate the average Grade of all students
            /*
            double avg = s.Average(e => e.Grade);
            Console.WriteLine($" average Grade of all students : {avg} ");
            */
            //11.Get the names of students who are in the CS department and whose Grade is greater than 80.Then sort th result from the highest Grade to the lowest Grade
            /*
            var x = s.Where(n => n.Department == "CS")
                     .Where(n => n.Grade >80)
                     .Select(e => new { e.Name, e.Grade })
                     .OrderByDescending(n => n.Grade);
            foreach (var item in x)
            {
                Console.WriteLine($"name: {item}");
            }
            */
            //12. Get the name of the student with the highest Grade.
            /*
            double ma = s.Max(e => e.Grade);
            var x = s.Where(n => n.Grade == ma).Select(e => e.Name);
            foreach (var item in x)
            {
                Console.WriteLine($"name: {item}");
            }
            */
            //13.Get the name of the student with the lowest Grade
            /*
            double mi = s.Min(e => e.Grade);
            var z = s.Where(n => n.Grade == mi).Select(e => e.Name);
            foreach (var item in z)
            {
                Console.WriteLine($"name: {item}");
            }
            */
            //30. Count how many students exist in each Department
            int count = s.Where(n => n.Grade >= 70).Count();
            Console.WriteLine($" number all students whose Grade is greater than or equal to 70 : {count} ");
        }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public string Department { get; set; }
    }
    public class StudentRepo
    {
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
            new Student { Id = 1, Name = "Ahmed", Age = 20, Grade = 85, Department = "CS" },
            new Student { Id = 2, Name = "Mona", Age = 22, Grade = 92, Department = "IT" },
            new Student { Id = 3, Name = "Omar", Age = 19, Grade = 67, Department = "CS" },
            new Student { Id = 4, Name = "Sara", Age = 21, Grade = 78, Department = "IS" },
            new Student { Id = 5, Name = "Ali", Age = 23, Grade = 95, Department = "CS" },
            new Student { Id = 6, Name = "Youssef", Age = 20, Grade = 55, Department = "IT" },
            new Student { Id = 7, Name = "Nour", Age = 22, Grade = 88, Department = "IS" },
            new Student { Id = 8, Name = "Hana", Age = 19, Grade = 73, Department = "CS" }

            };
        }
    }
}


