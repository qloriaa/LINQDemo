using System.Collections;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Test Scores
            int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            // print scores using foreach loop
            int num = 1;
            foreach (var individualScore in scores)
            {
                Console.WriteLine("Student #{0} score is {1}", num, individualScore);
                num++;
            }

            // Pause console
            Console.ReadLine();

            // Use a LINQ statement to filter the list
            var A_students = 
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            // Print only A student scores
            foreach (var individualScore in A_students)
            {
                Console.WriteLine("One of the Best scores was {0}", individualScore);
            }

            // Pause console
            Console.ReadLine();

            // Use LINQ to sort the results
            var sortedStudents = 
                from individualScore in scores
                orderby individualScore
                select individualScore;

            // Print all scores sorted in ascending order
            int score = scores.Length;
            foreach(var individualScore in sortedStudents)
            {
                Console.WriteLine("Score #{0} : {1}", score, individualScore);
                score--;
            }

            // Pause console
            Console.ReadLine();

            // Use LINQ statement to filter B students
            var B_students =
                from individualScore in scores
                where individualScore >= 80 && individualScore < 90
                select individualScore;

            // Use LINQ statement to sort B students in ascending order
            var sortedB_students =
                from individualScore in B_students
                orderby individualScore
                select individualScore;

            // Print B student's cores in ascending order
            foreach (var individualScore in sortedB_students)
            {
                Console.WriteLine("One of the B scores is " + individualScore);
            }

            // Create an Array List of students
            List<Student> students = new List<Student>();

            students.Add(new Student("Jane", "Doe", 13, 8));
            students.Add(new Student("Jimmy", "Schmitt", 15, 10));
            students.Add(new Student("Barbara", "Johnson", 12, 8));
            students.Add(new Student("Rebecca", "Nelson", 10, 5));
            students.Add(new Student("Douglas", "Campbell", 11, 6));
            students.Add(new Student("Brittany", "Powell", 14, 9));
            students.Add(new Student("James", "Potter", 13, 9));

            // Sorts the students by Grade, then alphabetical order
            students.Sort();
            students.ForEach(student => Console.WriteLine(student));


            Console.ReadLine();
        }
    }
}