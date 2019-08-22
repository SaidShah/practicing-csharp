using System;
using System.IO;

namespace studentBlackboardSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student(new Name("John", "Doe"), new Address(400, "College st.", "Harrisburg","PA",17016),"631-564-8457","Computer Science"  );
            Student studentTwo = new Student(new Name("Mike", "Meyers"), new Address(235, "York st.", "York","PA",17526),"631-563-7854","Information Technology"  );

            Console.WriteLine(studentOne.ToString());
            Console.WriteLine(studentTwo.ToString());
        }
    }
}