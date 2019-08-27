using System.ComponentModel.Design;
using System.IO;

namespace studentBlackboardSimple
{
    public class Animal
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public bool IsNeutered { get; set; }
        public int DogId { get; set; }

        public static int _id;

        public Animal()
            : this("no name", 0, false)
        {
            SetId();
        }

        public Animal(string name, int height, bool isNeutered)
        {
            Name = name;
            Height = height;
            IsNeutered = isNeutered;
            SetId();
        }

        public void SetId()
        {
            DogId = _id++;
        }

        public override string ToString()
        {
            return $"Dog Name {Name} Height {Height} Is Neutered {IsNeutered} ID Number {_id}";
        }
    }
}