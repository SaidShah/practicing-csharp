using System.ComponentModel.Design;
using System.Net.Mime;

namespace studentBlackboardSimple
{
    public class Course
    {
        // has title, courseNumber, numOfCredits variables
        // also has get and set for textbook isbn, and facultyID
        
        private string Title { get; set; }
        private string CourseNumber { get; set; }
        private Textbook Textbook { get; set; }
        private int NumCredits { get; set; }
        private string FaultyId { get; set; }

        public Course(string title, string courseNumber, int numCredits)
        {
            Title = title;
            CourseNumber = courseNumber;
            NumCredits = numCredits;
        }

        public override string ToString()
        {
            return $"Course Name: {Title}, Number: {CourseNumber}, Credits {NumCredits}\n";
        }
    }
}