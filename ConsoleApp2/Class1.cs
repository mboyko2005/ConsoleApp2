using System;

namespace Class1
{
	public class MyFunctions
	{
		// 1. Функция сложения двух чисел
		public int Add(int a, int b)
		{
			return a + b;
		}

		// 2. Функция вычитания двух чисел
		public int Subtract(int a, int b)
		{
			return a - b;
		}

		// 3. Функция умножения двух чисел
		public int Multiply(int a, int b)
		{
			return a * b;
		}

		// 4. Функция деления двух чисел
		public double Divide(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException("Деление на ноль невозможно.");
			return (double)a / b;
		}

		// 5. Функция для вывода сообщения
		public void PrintMessage(string message)
		{
			Console.WriteLine($"Сообщение из DLL: {message}");
		}
	}
}
