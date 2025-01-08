


using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson9DzOne;
class Student
{
  public string Name { get; set; }
  public int Age { get; set; }
  public double GPA { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    List<Student> students = new List<Student>
        {
            new Student { Name = "Артур", Age = 20, GPA = 3.8 },
            new Student { Name = "Витя", Age = 19, GPA = 4.0 },
            new Student { Name = "Гена", Age = 21, GPA = 3.5 },
            new Student { Name = "Катя", Age = 18, GPA = 3.9 },
            new Student { Name = "Тимофей", Age = 22, GPA = 3.7 }
        };

    students.Sort((s1, s2) => s2.GPA.CompareTo(s1.GPA));

    Console.WriteLine("Список студентов, отсортированный по среднему баллу:");
    foreach (var student in students)
    {
      Console.WriteLine($"Имя: {student.Name}, Возраст: {student.Age}, Средний балл: {student.GPA}");
    }

    Student youngestStudent = students.OrderBy(s => s.Age).First();
    Console.WriteLine($"Информация о самом младшем студенте:");
    Console.WriteLine($"Имя: {youngestStudent.Name}, Возраст: {youngestStudent.Age}, Средний балл: {youngestStudent.GPA}");
    Console.ReadKey();
  }
}
