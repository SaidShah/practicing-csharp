using System;

namespace studentBlackboardSimple
{
    public class Student
    {
        // has a Name, Address, phone number, and major(enum)
        // has coursesTook array, coursesTaking array, and coursesToTake array -> all are grade classes

        private Name Name { get; set; }
        private Address Address { get; set; }
        private string PhoneNumber { get; set; }
        private string Major { get; set; }

        private Course[] _coursesTook = new Course[10];
        private int _coursesTookElement;

        private Course[] _coursesTaking = new Course[10];
        private int _coursesTakingElements;
        
        private Course[] _coursesToTake = new Course[10];
        private int _coursesToTakeElements;

        public Student(Name name, Address address, string phoneNumber, string major)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Major = major;
        }

        public void addCourseTaking(Course givenCourse)
        {
            if (_coursesTaking.Length < 10)
            {
                _coursesTaking[_coursesTakingElements] = givenCourse;
                _coursesTakingElements++;
            }
        }

        public void addCourseTook(Course course)
        {
            if (_coursesTook.Length < 10)
            {
                _coursesTaking[_coursesTookElement] = course;
                _coursesTookElement++;
            }
        }

        public void addCoursesToTake(Course course)
        {
            if (_coursesToTake.Length < 10)
            {
                _coursesToTake[_coursesToTakeElements] = course;
                _coursesToTakeElements++;
            }
        }

        public Course[] getCoursesToTake()
        {
            return _coursesToTake;
        }

        public Course[] getCoursesTook()
        {
            return _coursesTook;
        }

        public Course[] getCoursesTaking()
        {
            return _coursesTaking;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Address: " + Address + " PhoneNumber: " + PhoneNumber + " Major: " + Major;
        }
    }
}