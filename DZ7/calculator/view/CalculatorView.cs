
using System.Numerics;
using DZ7.repository;

namespace DZ7.calculator.view
{
	public class CalculatorView
	{

		public void Run()
		{
			double real;
			double img;
			String op;
			while (true)
			{   
				Console.WriteLine("Введите вещественную часть числа: ");
				real = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите мнимую часть числа: ");
                img = Convert.ToDouble(Console.ReadLine());
				Complex z1 = new Complex(real, img);
			

                Console.WriteLine("Введите арифметический оператор (+,-,*,/): ");
				op = Console.ReadLine();

                Console.WriteLine("Введите вещественную часть числа: ");
                real = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите мнимую часть числа часть числа: ");
                img = Convert.ToDouble(Console.ReadLine());
                Complex z2 = new Complex(real,img);

				switch (op)
				{
					case "+":
						Addition addition = new Addition();
                        Console.WriteLine(addition.GetResult(z1, z2));
						break;
					case "-":
						Subtraction subtraction = new Subtraction();
                        Console.WriteLine(subtraction.GetResult(z1, z2));
						break;
					case "*":
                        Multiplication multiplication = new Multiplication();
                        Console.WriteLine(multiplication.GetResult(z1, z2));
						break;
					case "/":
                        Division division = new Division();
                        Console.WriteLine(division.GetResult(z1, z2));
                        Console.ReadKey();
						break;
					default:
						Console.WriteLine("Неизвестная команда");
						break;
                }

            }

        }

	}
}

