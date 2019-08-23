using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace studentBlackboardSimple
{
    public class Persons
    {
        // is an array of persons and an numOfElements variable -> has all typical array methods 
        // including add, remove, totalStudents, findById, getPassword etc..
        // should have lots of other methods because of the access to faculty and students
        
        List<Person> AllPersons = new List<Person>();

        public void AddPerson(Person person)
        {
            AllPersons.Add(person);
            
        }

        public List<Person> GetAllPersons()
        {
            return AllPersons;
        }

        public Person GetPersonById(string givenId)
        {
            foreach (var eachPerson in AllPersons)
            {
                if (givenId.Equals(eachPerson._id))
                {
                    return eachPerson;
                }
            }

            return null;
        }
        
    }
}