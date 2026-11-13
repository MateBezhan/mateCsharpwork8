using System;

namespace mateCsharpwork8
{
    internal class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private string phone;
        private string course;
        private double gpa;
        private int enrollmentYear;
        private bool isActive;

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Id must be greater than 0.");
                id = value;
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("First name must be at least 2 characters.");
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                    throw new ArgumentException("Last name must be at least 2 characters.");
                lastName = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16 || value > 100)
                    throw new ArgumentException("Age must be between 16 and 100.");
                age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                    throw new ArgumentException("Email is not valid.");
                email = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 9)
                    throw new ArgumentException("Phone must be at least 9 characters.");
                phone = value;
            }
        }

        public string Course
        {
            get { return course; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Course cannot be empty.");
                course = value;
            }
        }

        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentException("GPA must be between 0 and 4.");
                gpa = value;
            }
        }

        public int EnrollmentYear
        {
            get { return enrollmentYear; }
            set
            {
                if (value < 2000 || value > DateTime.Now.Year)
                    throw new ArgumentException("Enrollment year is not valid.");
                enrollmentYear = value;
            }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("GPA: " + Gpa);
            Console.WriteLine("Enrollment year: " + EnrollmentYear);
            Console.WriteLine("Is active: " + IsActive);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.Id = 1;
                student.FirstName = "Mate";
                student.LastName = "Beridze";
                student.Age = 20;
                student.Email = "mate@gmail.com";
                student.Phone = "555123456";
                student.Course = "Software Development";
                student.Gpa = 3.5;
                student.EnrollmentYear = 2024;
                student.IsActive = true;

                student.PrintInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}