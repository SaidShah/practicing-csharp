using System;

namespace studentBlackboardSimple
{
    public class Student:Person
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

        public override string ToString()
        {
            return "Student -> Name: " + Name + " Address: " + Address + " PhoneNumber: " + PhoneNumber + " Major: " + Major + " Id Number: " + _id + "\n";
        }
    }
}