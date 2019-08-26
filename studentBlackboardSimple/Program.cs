using System;
using System.Collections.Generic;
using System.IO;

namespace studentBlackboardSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student(new Name("John", "Doe"), new Address(400, "College st.", "Harrisburg","PA",17016),"631-564-8457","Computer Science"  );
            Student studentTwo = new Student(new Name("Mike", "B","Meyers"), new Address(235, "York st.", "York","PA",17526),"631-563-7854","Information Technology"  );

            Faculty facultyOne = new Faculty(new Name("Mike", "B","Meyers"), new Address(235, "York st.", "York","PA",17526),"631-563-7854","Information Technology"  );
            Faculty facultyTwo = new Faculty(new Name("Mike", "B","Meyers"), new Address(235, "York st.", "York","PA",17526),"631-563-7854","Information Technology"  );

            Console.WriteLine(studentOne.ToString());
            Console.WriteLine(studentTwo.ToString());
            Console.WriteLine(facultyOne.ToString());
            facultyTwo.Salary = "24000";
            Console.WriteLine(facultyTwo.ToString());
            
            Textbook t1 = new Textbook("Intro to java first edition", new Name("James", "Michael"), true,
                "658-4521-956", 106.65);
            Textbook t2 = new Textbook("Advanced programming 2nd edition", new Name("michael", "johnson"),
                true, "125-4521-458", 125.52);
            
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            
            Course c1 = new Course("Intro to java", "CST111", 3);
            Course c2 = new Course("Advanced Programming", "CST112", 4);
            Course c3 = new Course("Pre-calculus", "MAT126", 3);
            Course c4 = new Course("Algebra", "MAT145", 3);
            Course c5 = new Course("Database", "CST172", 4);
            Course c6 = new Course("English", "ENG101", 2);
            Course c7 = new Course("Chemistry", "CHEM214", 3);
            Course c8 = new Course("Physics", "PHY122", 5);
            Course c9 = new Course("Science", "SCI115", 3);
            
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            
            
            studentOne.AddCourseTaking(c1);
            studentOne.AddCourseTaking(c4);
            studentOne.AddCourseTook(c5);
            studentOne.AddCourseTook(c3);
            studentOne.AddCoursesToTake(c8);
            studentOne.AddCoursesToTake(c9);
            
            studentTwo.AddCourseTaking(c8);
            studentTwo.AddCourseTaking(c4);
            studentTwo.AddCourseTook(c2);    
            studentTwo.AddCourseTook(c6);
            studentTwo.AddCoursesToTake(c5);
            studentTwo.AddCoursesToTake(c7);
            
            Console.WriteLine("COURSES STUDENT ONE TOOK");
            foreach (var eachCourse in studentOne.GetCoursesTook())
            {
                if (eachCourse != null)
                {
                    Console.WriteLine(eachCourse.ToString());
                }
            }
            
            Console.WriteLine("COURSES STUDENT ONE IS TAKING");
            foreach (var eachCourse in studentOne.GetCoursesTaking())
            {
                if (eachCourse != null)
                {
                    Console.WriteLine(eachCourse.ToString());
                }
            }
            
            Persons p1 = new Persons();
            p1.AddPerson(studentOne);
            p1.AddPerson(studentTwo);
            p1.AddPerson(facultyOne);
            p1.AddPerson(facultyTwo);
            
            Person p2 = p1.GetPersonById("000001");
            if (p2 != null)
            {
                Console.WriteLine("Student Found");
                Console.WriteLine(p2.ToString());
            }
            Vehicle toyota = new Vehicle("Toyota",4,150);
            // to check to see if you can use the interface for a specific object check like below
            if (toyota is IDriveable)
            {
                toyota.Move();
                toyota.Stop();
            }
            
            // Dictionary is a key value pair
            Dictionary<string, string> superheros = new Dictionary<string, string>();
            superheros.Add("spider-man","spider-man-junior");
            superheros.Add("Bruce Wayne","Batman");
            superheros.Add("Barry West","Some superhero");
            Console.WriteLine(superheros.Count);
            superheros.Remove("Barry West");
            Console.WriteLine(superheros.Count);
            Console.WriteLine(superheros.ContainsKey("Bruce Wayne"));
            superheros.TryGetValue("spider-man", out string test);
            Console.WriteLine($"spider-man {test}");
            foreach (KeyValuePair<string,string> item in superheros)
            {
                Console.WriteLine($"Item key = {item.Key} ");
                Console.WriteLine($"Item Value = {item.Value} ");
            }
            
            
            // below we are using an array list to add the students and faculty
            List<Person> personList = new List<Person> {studentOne, studentTwo, facultyOne, facultyTwo};
            foreach (var eachPerson in personList)
            {
                Console.WriteLine(eachPerson.ToString());
            }
            Console.WriteLine($"person list has {personList.Count} people");
            personList.RemoveAt(1);
            Console.WriteLine($"person list has {personList.Count} people after removing 1");
            
            personList.Insert(1,new Student(new Name("Bugs","Bunny"),new Address(27, "peanut st", "Park Slope ","NY",12458),"718-232-5648","Engineering" ));
            foreach (var eachPerson in personList)
            {
                Console.WriteLine(eachPerson.ToString());
            }
            
            // you can use generic data types when using collections like so 
//            Queue<T> persons = new Queue<T>();
//            Stack<J> allPersons = new Stack<J>();
//            Dictionary<Tkey,Tvalue> allPersons = new Dictionary<Tkey,Tvalue>();
            
            // this method is in student class and is a generic method
            // below we are also using a refrenece to the variables
            // because we are using generics we will use the same method for many data types
            var tuitionPayment = 200;
            var moneyAvailable = 120;
            Student.GetTuitionPayment( ref tuitionPayment, ref moneyAvailable);

            string tPayment = "300";
            string moneyAvail = "134";
            Student.GetTuitionPayment(ref tPayment,ref moneyAvail);








        }
    }
}