using System;
using Class1; // Правильное пространство имен вашей DLL

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Создаём экземпляр класса из DLL
			MyFunctions functions = new MyFunctions();

			// Используем функцию сложения
			int sum = functions.Add(10, 5);
			Console.WriteLine($"10 + 5 = {sum}");

			// Используем функцию вычитания
			int difference = functions.Subtract(10, 5);
			Console.WriteLine($"10 - 5 = {difference}");

			// Используем функцию умножения
			int product = functions.Multiply(10, 5);
			Console.WriteLine($"10 * 5 = {product}");

			// Используем функцию деления
			try
			{
				double quotient = functions.Divide(10, 5);
				Console.WriteLine($"10 / 5 = {quotient}");
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine(ex.Message);
			}

			// Используем функцию вывода сообщения
			functions.PrintMessage("Привет из DLL!");

			Console.WriteLine("Нажмите любую клавишу для выхода...");
			Console.ReadKey();
		}
	}
}
