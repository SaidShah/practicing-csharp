using System;

namespace studentBlackboardSimple
{
    public class Name
    {
            // has a firstName, lastName and middleInitial

            private string FirstName { get; set; }
            private string MiddleInitial { get; set; }
            private string LastName { get; set; }

            public Name(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            
            public Name(string firstName, string middleInitial, string lastName)
            {
                FirstName = firstName;
                MiddleInitial = middleInitial;
                LastName = lastName;
            }

            private string GetMiddleInitial()
            {
                if (string.IsNullOrEmpty(MiddleInitial) || string.IsNullOrWhiteSpace(MiddleInitial))
                {
                    return "";
                }
                else
                {
                    return MiddleInitial;
                }
            }

            public override string ToString()
            {
                return FirstName + " " + GetMiddleInitial() + " " + LastName;
            }
    }
}