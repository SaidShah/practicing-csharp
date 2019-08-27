using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace studentBlackboardSimple
{
    [Serializable()]
    public class Student:Person, ISerializable
    {
        // has a Name, Address, phone number, and major(enum)
        // has coursesTook array, coursesTaking array, and coursesToTake array -> all are grade classes

        private Name Name { get; set; }
        private Address Address { get; set; }
        private string PhoneNumber { get; set; }
        private string Major { get; set; }

        private readonly Course[] _coursesTook = new Course[10];
        private int _coursesTookElement;

        private Course[] _coursesTaking = new Course[10];
        private int _coursesTakingElements;
        
        private readonly Course[] _coursesToTake = new Course[10];
        private int _coursesToTakeElements;

//        public Student()
//            : this(new Name(" "," "), new Address(4," "," "," ",0),"34334","no major"){}
        public Student(Name name, Address address, string phoneNumber, string major):base(name, address)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Major = major;
        }
        

        public void AddCourseTaking(Course givenCourse)
        {
            if (_coursesTakingElements < 10)
            {
                _coursesTaking[_coursesTakingElements] = givenCourse;
                _coursesTakingElements++;
            }
        }

        public void AddCourseTook(Course course)
        {
            if (_coursesTookElement < 10)
            {
                _coursesTook[_coursesTookElement] = course;
                _coursesTookElement++;
            }
        }

        public void AddCoursesToTake(Course course)
        {
            if (_coursesToTakeElements < 10)
            {
                _coursesToTake[_coursesToTakeElements] = course;
                _coursesToTakeElements++;
            }
        }

        public Course[] GetCoursesToTake()
        {
            return _coursesToTake;
        }

        public Course[] GetCoursesTook()
        {
            return _coursesTook;
        }

        public Course[] GetCoursesTaking()
        {
            return _coursesTaking;
        }

        public static void GetTuitionPayment<T>(ref T billAmount, ref T payedToday)
        {
            var owed = Convert.ToInt32(billAmount);
            var paid = Convert.ToInt32(payedToday);
            var balance = owed - paid;
            if (balance > 0)
            {
                Console.WriteLine($"total owed: ${balance}");
            }
            else
            {
                Console.WriteLine($"We owe you: ${balance}");
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {// serializing data to write as binary to a file
            info.AddValue("Name",Name);
            info.AddValue("Address",Address);
            info.AddValue("PhoneNumber",PhoneNumber);
            info.AddValue("Major",Major);
            info.AddValue("_id",_id);
        }

        // rebuilding the object
        public Student(SerializationInfo info, StreamingContext context)
        {
            Name = (Name) info.GetValue("Name", typeof(Name));
            Address = (Address) info.GetValue("Address", typeof(Address));
            PhoneNumber = (string) info.GetValue("PhoneNumber", typeof(string));
            Major = (string) info.GetValue("Major", typeof(string));
            _id = (string) info.GetValue("_id", typeof(string));
        }
        public override string ToString()
        {
            return "Student -> Name: " + Name + " Address: " + Address + " PhoneNumber: " + PhoneNumber + " Major: " + Major + " Id Number: " + _id + "\n";
        }
    }
}