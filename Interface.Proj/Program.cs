using System;

namespace Interface.Proj {
    class Program : IStudents {                    // ": IStudents" implements interface
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
        public Student[] GetStudents() {
            return new Student[0];
        }
    }
    class Student { }
    interface IStudents {               // must start with a capital I  /  Allows you and others to use at same time
        Student[] GetStudents();
            
    }
}
