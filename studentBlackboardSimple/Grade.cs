namespace studentBlackboardSimple
{
    public class Grade
    {
        // has a courseNumber and letterGrade
        
        private string CourseNumber { get; set; }
        private string LetterGrade { get; set; }

        public Grade(string courseNumber, string letterGrade)
        {
            CourseNumber = courseNumber;
            LetterGrade = letterGrade;
        }

        public override string ToString()
        {
            return $"Course Number: {CourseNumber} Letter Grade: {LetterGrade}";
        }
    }
}