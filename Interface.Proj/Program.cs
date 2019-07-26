
// Create a list of students from Greg's program that has an array of all students
// Contract: Greg has to produce file for me to use // Need to collaborate
// Greg will build part I need with interface, then I can access it through the interface
// We can both access at same time
// Use interface -- We start coding our classes at same time.
// seperate files for greg's, mine and interface
// Greg's code will have method "GetStudents()" that will return array of Student
// I will use his method to loop through students.  He is not done with it, but I want to begin working on my file
//



using System;

namespace Interface.Proj {
    class Program /*: IStudents*/ {                    // ": IStudents" implements interface
        static void Main(string[] args) {



            //// MY CODE CREATED BECAUSE GREG'S WASNT FINISHED YET

            /*IStudent greg;*/                             // create variable name with "I" in front of 
            IStudent greg = new FakeGreg();                 // Write this after creating fake class to test
            Student[] students = greg.GetStudents();
            int idx = 0;
            while (idx < students.Length) {
                Console.WriteLine($"Student name is {students[idx].Name}");
                idx++;           // same as 'idx = idx + 1' or 'idx += 1'
            }
        }
    }
        
    class Student {
                                        // every instance will have a next           
       // private int Id { get; set; }        // primary key  
        public string Name { get; set; }
    }
    interface IStudent {               // must start with a capital I  /  Allows you and others to use at same time
        Student[] GetStudents();
            
    }


    
    
    
 ////  class to test with fake data
    class FakeGreg: IStudent {                   // Not sure what the name is so use "I"
        public Student[] GetStudents() {
            Student[] students = new Student[] {        // return this array of students
                new Student { Name = "Denise"},         // By creating method with Student "IStudent", we are saying that there is only 1 method in that class
                new Student { Name = "Kim"},
                new Student { Name = "Greg"},
            };

            return students;
          //return new Student[0];                         // every instance created will have a different ID #

        }
    }
}
