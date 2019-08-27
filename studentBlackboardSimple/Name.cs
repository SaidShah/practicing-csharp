using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace studentBlackboardSimple
{
    [Serializable()]
    public class Name:ISerializable
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
                if (string.IsNullOrWhiteSpace(GetMiddleInitial()))
                {
                    return FirstName + " "+ LastName + "\n";
                }
                
                return FirstName + " " + GetMiddleInitial() + " " + LastName + "\n";
            }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("FirstName",FirstName);
                info.AddValue("LastName",LastName);
            }

            public Name(SerializationInfo info, StreamingContext context)
            {
                FirstName = (string) info.GetValue("FirstName", typeof(string));
                LastName = (string) info.GetValue("LastName", typeof(string));
            }
    }
}