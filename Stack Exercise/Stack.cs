using System;
namespace StackExercise
{ 
public class Stack<T>
{
	private T[] elements;
	private int currentIndex = -1;

		public Stack() => elements = new T[10]; 
		// the simple stack class will work with only 10 items  _item: field
													// => expression body instead of {}


		// push items
		public void Push(T element)
	{
		elements[++currentIndex] = element;
	}

		// Cou t method to calculate the number of elements in the stack
		public int Count() { 
			return (currentIndex + 1); 
		}

	// remove the top element of the stack and retrurn it. 
	public T Pop()
	{
		return elements[currentIndex--];
	}

	public void Peak()
	{
		if (currentIndex == -1)
			Console.WriteLine("no elements in the stack");
		else
			Console.WriteLine(elements[currentIndex]);
	}

	// Print out the stack objects
	public void Print()
	{
		while (currentIndex != -1)
			Console.WriteLine(elements[currentIndex]);
		currentIndex--;
	}

	public void Clear()
	{
		while (currentIndex != -1)
			currentIndex--;
	}
}
}
