using System;
using System.Runtime.ConstrainedExecution;

namespace studentBlackboardSimple
{
    public struct Arithmatic<T>
    {
        // creating a generic struct which will accept any data type, notice above we declare the generic type
        private T Num1 { get; set; }
        private T Num2 { get; set; }

        public Arithmatic(T l, T w)
        {
            Num1 = l;
            Num2 = w;
        }

        public static void GetSum(T l, T w)
        {
            int firstNum = Convert.ToInt16(l);
            int secondNum = Convert.ToInt16(w);
            Console.WriteLine($"first num: {firstNum}, second num: {secondNum} and total = {firstNum+secondNum}");
            
        }

    }
}