namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var process = new Scoreprocess();

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("passed Students : ");
            Console.WriteLine("----------------------------------------------------------------");
            process.Filterstudents(student => student.Score >= 50m);
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("failed Students : ");
            Console.WriteLine("----------------------------------------------------------------");
            process.Filterstudents(student => student.Score < 50m);
            Console.WriteLine("----------------------------------------------------------------");
            process.students.PrintStudentList();
            Console.WriteLine("----------------------------------------------------------------");
            process.students.Topscorer();
            Console.WriteLine("----------------------------------------------------------------");
            process.students.AVGscorer();


            Console.ReadKey();
        }
        static bool Passed(Student student) => student.Score >= 50m;
        static bool Failed(Student student) => student.Score < 50m;
    }
}
