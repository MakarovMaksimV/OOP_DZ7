
//using System.Numerics;
using DZ7.core;
using DZ7.repository;

namespace DZ7.calculator.view
{
	public class CalculatorView
	{
        double real;
        double img;
        string op;

        public void Run()
		{

			while (true)
			{
				Console.Write("Введите вещественную часть числа: ");
				real = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите мнимую часть числа: ");
                img = Convert.ToDouble(Console.ReadLine());
				Complex z1 = new Complex(real,img);

                Console.Write("Введите арифметический оператор (+,-,*,/): ");
                op = Console.ReadLine();

                Console.Write("Введите вещественную часть числа: ");
                real = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите мнимую часть числа часть числа: ");
                img = Convert.ToDouble(Console.ReadLine());
                Complex z2 = new Complex(real,img);

				switch (op)
				{
					case "+":
						Addition add = new Addition();
						Console.WriteLine(add.GetResult(z1, z2)); 
						break;
					case "-":
						Subtraction sub = new Subtraction();
                        Console.WriteLine(sub.GetResult(z1, z2));
						break;
					case "*":
                        Multiplication mult = new Multiplication();
                        Console.WriteLine(mult.GetResult(z1, z2));
						break;
					case "/":
                        Division div = new Division();
                        Console.WriteLine(div.GetResult(z1, z2));
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

