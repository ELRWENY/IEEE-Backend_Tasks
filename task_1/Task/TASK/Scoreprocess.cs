using System;
namespace TASK
{
    public delegate bool Studentcriteria(Student student);
    public class Scoreprocess
    {

        public List<Student> students = new List<Student>();
        public Scoreprocess()
        {
            students.Add(new Student("osama", 36m));
            students.Add(new Student("ahmed", 77m));
            students.Add(new Student("mohamed", 78.5m));
            students.Add(new Student("malacia", 49.5m));
            students.Add(new Student("vini jr", 99.5m));
            students.Add(new Student("raphinha", 56.5m));
            students.Add(new Student("pedri", 93.5m));
            students.Add(new Student("casado", 85.5m));
            students.Add(new Student("cristiano", 99.9m));
            students.Add(new Student("messi", 100m));
            students.Add(new Student("valverde", 100m));
            students.Add(new Student("camavinga", 88m));
            students.Add(new Student("cubarsi", 90m));
            students.Add(new Student("mariam", 45m));
            students.Add(new Student("menna", 44m));
            students.Add(new Student("habiba", 90m));
            students.Add(new Student("ibraheem", 88m));
            students.Add(new Student("omar", 56m));
            students.Add(new Student("ali", 70.7m));
            students.Add(new Student("hamdy", 47m));
            students.Add(new Student("waleed", 97m));
            students.Add(new Student("jhon snow", 80m));
        }

        public void Filterstudents(Studentcriteria process)
        {
            foreach (Student student in students)
            {
                if (process(student))
                {
                    Console.WriteLine($"student name: {student.Name} student degree : {student.Score}");
                }
            }
        }
        public void AVGscorer(List<Student> students)
        {
            decimal sum = 0;
            int count = 0;
            foreach (var student in students)
            {
                sum += student.Score;
                count++;
            }
            decimal result = sum / count;

            Console.WriteLine($"average for students is {Math.Round(result, 2)}");
        }
    }
}
