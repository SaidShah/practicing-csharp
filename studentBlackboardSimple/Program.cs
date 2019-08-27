using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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

            // using a generic struct to add 2 numbers together
            Arithmatic<int>.GetSum(23,53);
            Arithmatic<string>.GetSum("324","33");
            
            
            // the Delegate method is all the way on the bottom
            DelegateMethod firstNum, secondNum, total;
            firstNum = new DelegateMethod(Add);
            secondNum = new DelegateMethod(Subtract);
            total = firstNum + secondNum;
            firstNum(3,3);
            secondNum(8, 4);
            // you can chain the delegate methods so calling the below method will run both of the methods
            total(8, 4);


            // using lambda expressions, they are expressions where the value is assigned on the left
            // and the method signature is on the right

            doubleIt dblIt = x => x * x;
            Console.WriteLine("using the doubleIt delegate and lambda to double a num 4 * 4 = {0}",dblIt(4));

            // you dont have to use delegates for a lambda expression 
            List<int> numList = new List<int>{1,2,3,4,5,45,6,94,6546,64,496,5498,48964,34};
            // below we are checking for even numbers then converting it to a list
            var evenNums = numList.Where(x => x % 2 == 0).ToList();
            foreach (var x in evenNums)
            {
                Console.Write($"{x}, ");
            }
            Console.WriteLine();
            // below we are using the lambda and the where to look for a range
            var rangeNums = numList.Where(x => (x > 4) && (x < 50)).ToList();
            foreach (var w in rangeNums)
            {
                Console.Write($"{w}, ");
            }

            // you can also use .Select to perform an operation on each item in a collection
            // you can also use .Zip to perform an operation on 2 collections
            // you can also use .Aggregate to perform operations on collections
            // other Linq methods 
            // .AsQueryable.Average => to get the average of a list
            // .All to check if all values in a collection meet a condition
            // .Any to check if any values meet a condition
            // .Distinct used to eliminate duplicates from a collection
            // .Except will take 2 lists and return values not found in the second list
            // .Intersect will take 2 lists and return values found in both lists
            
            // USING LINQ FUNCTIONS => WHICH ARE ESSENTIALLY QUERIES THAT CAN BE USED ON DATA 
            
            
            Console.WriteLine();
            Animal a1 = new Animal("john", 23, true);
            Console.WriteLine(a1.ToString());
            string[] dogs =
                {"K 9", "Scooby Doo", "Brian Griffin", "Lassie", "Rin Tin Tin", "Benji", "Snoopy", "Charlie B. Barkin"};

            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog descending select dog;
            foreach (var dog in dogSpaces)
            {
                Console.Write($"{dog}, ");
            }

            Console.WriteLine();

            int[] intArray = {23, 43, 54, 34, 5, 64, 6, 87, 65, 45645, 67, 657, 56, 67, 56};
            var smallNumArray = from num in intArray where num > 50 orderby num select num;
            foreach (var num in smallNumArray)
            {
                Console.Write($"{num}, ");
            }
            // you can convert to list or to array ToArray() or ToList<int>();
            int[] smallNums = smallNumArray.ToArray();

            ArrayList animals = new ArrayList
            {
                new Animal("Scooby Doo",43,true),new Animal("Snoopy",12,true),
                new Animal("Brian Griffin",22,false), new Animal("Lassie",48,true)
            };

            Console.WriteLine();
            // you have to convert the array list into an enumerable 
            var famousAnimals = animals.OfType<Animal>();
            var smallAnimals = from animal in famousAnimals
                where animal.Height < 40
                orderby animal.Height ascending
                select animal;
            foreach (var animal in smallAnimals)
            {
                Console.WriteLine(animal.ToString());
            }

            Console.WriteLine();
            List<Animal> animalList = new List<Animal>
            {
                new Animal("Scooby Doo",43,true),new Animal("Snoopy",12,true),
                new Animal("Brian Griffin",22,false), new Animal("Lassie",48,true),
                new Animal("Garfield",52,true), new Animal("K 9", 88, true)
            };
            List<Owner> ownerArray = new List<Owner>
            {
                new Owner("John"), new Owner("Mike"), new Owner("Sally"), new Owner("James"), new Owner("Michelle"), new Owner("Superman")
            };
            
            // to grab values out of a collection the parent collection should be a list or an array
            var nameHeight = from anim in animalList
                            select new {anim.Name, anim.Height};

            foreach (var a in nameHeight)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            // to convert into an array you can do 
            Array newNameHeight = nameHeight.ToArray();
            foreach (var eachAnim in newNameHeight)
            {
                Console.WriteLine(eachAnim.ToString());
            }
            
            // you can also do inner, outter and full joins 
            Console.WriteLine();
            var joinQuery = from animal in animalList
                join owner in ownerArray on animal.DogId equals owner.OwnerId
                select new {OwnerName = owner.Name, AnimalName = animal.Name};
            foreach (var dogOwner in joinQuery)
            {
                Console.WriteLine(dogOwner);
            }
            
            // you can also do a group join to take all matching objects
            var groupJoin = from owner in ownerArray
                orderby owner.OwnerId
                join animal in animalList
                    on owner.OwnerId equals animal.DogId
                    into ownerGroup
                select new {Owner = owner.Name, Animals = from owner2 in ownerGroup orderby  owner2.Name select owner2};

            Console.WriteLine();
            foreach (var owner in groupJoin)
            {
                Console.WriteLine(owner.Owner);
                foreach (var animal in owner.Animals)
                {
                    Console.WriteLine(" {0}",animal);
                }
            }









        }
        // using delegate to add and manipulate methods
        public delegate void DelegateMethod(double firstNum, double secondNum);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine("using delegate method to add {0}" ,(num1 + num2));
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine("using delegate method to Subtract {0}" ,(num1 - num2));
        }

        delegate double doubleIt(double givenNum);
    }
}