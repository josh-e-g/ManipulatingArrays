using System;

namespace ManipulatingArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ManipulatingArrays.Program.Main()");
			int[] arrayA = { 0, 2, 4, 6, 8, 10 };
			int[] arrayB = { 1, 3, 5, 7, 9 };
			int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
			Console.WriteLine($"\nArray A is: [{Print(arrayA)}]");
			Console.WriteLine($"\n\tThe average of Array A is {Average(arrayA)}.");
			Console.WriteLine($"\tArray A reversed is [{Reverse(arrayA)}].");
			Console.WriteLine($"\tArray A rotated two places to the left is [{Rotate("left", 2, arrayA)}].");
			Console.WriteLine($"\tArray A sorted from least to greatest is [{Print(Sort(arrayA))}].");

			Console.WriteLine($"\nArray B is: [{Print(arrayB)}]");
			Console.WriteLine($"\n\tThe average of Array B is {Average(arrayB)}.");
			Console.WriteLine($"\tArray B reversed is [{Reverse(arrayB)}].");
			Console.WriteLine($"\tArray B rotated two places to the right is [{Rotate("right", 2, arrayB)}].");
			Console.WriteLine($"\tArray B sorted from least to greatest is [{Print(Sort(arrayB))}].");

			Console.WriteLine($"\nArray C is: [{Print(arrayC)}]");
			Console.WriteLine($"\n\tThe average of Array C is {Average(arrayC)}.");
			Console.WriteLine($"\tArray C reversed is [{Reverse(arrayC)}].");
			Console.WriteLine($"\tArray C rotated four places to the left is [{Rotate("left", 4, arrayC)}].");
			Console.WriteLine($"\tArray C sorted from least to greatest is [{Print(Sort(arrayC))}].");
		}
		public static string Print(int[] array)
		{
			string printed = "";
			foreach (var i in array)
			{
				printed += i + ", ";
			}
			return printed;
		}
		public static double Average(int[] array)
		{
			int sum = 0;
			double average = 0.0;

			for (int i = 0; i < array.Length; i++) sum += array[i];
			
			average = (double)sum / (double)array.Length;
			return average;
		}
		public static string Reverse(int[] array)
		{
			string reversed = "";

			for (int i = array.Length - 1; i >= 0; i--) reversed += array[i] + ", ";
			
			return reversed;
		}
		public static string Rotate(string direction, int number, int[] array)
		{
			string front = "";
			string back = "";
			if (direction == "left")
			{
				for (int i = 0; i < number; i++)
				{
					front += array[i] + ", ";
				}
				for (int i = number; i < array.Length; i++)
				{
					back += array[i] + ", ";
				}

				return back + front;
			}
			else if (direction == "right")
			{
				for (int i = array.Length - number; i < array.Length; i++)
				{
					back += array[i] + ", ";
				}
				for (int i = 0; i < array.Length - number; i++)
				{
					front += array[i] + ", ";
				}

				return back + front;
			}
			else
			{
				return "Please specify either \"left\" or \"right\" as a direction to rotate.";
			}
		}
		public static int[] Sort(int[] array)
		{
			int count;
			do
			{
				count = 0;
				for (int i = 0; i < array.Length - 1; i++)
				{
					if (array[i] > array[i + 1])
					{
						int p = array[i];
						array[i] = array[i + 1];
						array[i + 1] = p;
						count += 1;
					}
				}
			} while (count > 0);

			return array;
		}
	}
}
