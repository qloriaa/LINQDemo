namespace LINQDemo
{
    internal class Student : IComparable<Student>
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="age"></param>
        /// <param name="grade"></param>
        public Student(string first, string last, int age, int grade)
        {
            FirstName = first;
            LastName = last;
            Age = age;
            Grade = grade;
        }

        /// <summary>
        /// ToString() to display all of Object's properties
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}. Age: {2} Grade: {3}", LastName, FirstName, Age, Grade);
        }

        /// <summary>
        /// Compare the Students to sort them by Grade (ascending)
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            // Alphabetic sort if Grade is equal
            if (this.Grade == other.Grade)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            // Default to salary sort. (Ascending)
            return this.Grade.CompareTo(other.Grade);
        }
    }
}