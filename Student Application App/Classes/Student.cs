namespace Student_Application_App.Classes
{
    public class Student
    {

        private readonly string _firstName = string.Empty;
        private readonly string _lastName = string.Empty;
        public string FullName => $"{_firstName} {_lastName}";
        public readonly int Age = default;

        public Student() { }
        public Student(string firstName, string lastName, int age) => (_firstName, _lastName, Age) = (firstName, lastName, age);


    }
}
