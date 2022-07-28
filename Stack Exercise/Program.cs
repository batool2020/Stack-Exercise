using System;
using System.Collections.Generic;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StackStrings();
            Console.ReadLine();


        }

        private static void StackStrings()
        {
            var stack = new Stack<string>();
            stack.Push("Jerusalme");
            stack.Push("Ramallah");
            stack.Push("Hebron");
            stack.Push("Nablus");

            stack.Peak();


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            stack.Peak();

            stack.Clear();

            stack.Print();


                }
    }
}
