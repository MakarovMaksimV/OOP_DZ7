
//using System.Numerics;
using DZ7.core;
using DZ7.repository;

namespace DZ7.calculator.view
{
	public class CalculatorView
	{
        double real;
        double img;
        string? op;

        public void Run()
		{
			while (true)
			{
				Console.Write("Enter real part: ");
				real = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter imaginary: ");
                img = Convert.ToDouble(Console.ReadLine());
				Complex z1 = new Complex(real,img);

                Console.Write("Select operation (+,-,*,/): ");
                op = Console.ReadLine();

                Console.Write("Enter real part: ");
                real = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter imaginary: ");
                img = Convert.ToDouble(Console.ReadLine());
                Complex z2 = new Complex(real,img);

				switch (op)
				{
					case "+":
						Addition add = new ();
						Console.WriteLine(add.GetResult(z1, z2)); 
						break;
					case "-":
						Subtraction sub = new ();
                        Console.WriteLine(sub.GetResult(z1, z2));
						break;
					case "*":
                        Multiplication mult = new ();
                        Console.WriteLine(mult.GetResult(z1, z2));
						break;
					case "/":
                        Division div = new ();
                        Console.WriteLine(div.GetResult(z1, z2));
                        Console.ReadKey();
						break;
					default:
						Console.WriteLine("Unknown operation");
						break;
                }

				Console.WriteLine("Continue? (y/n)");
				string answer = Console.ReadLine();

				if (answer == "n") break;
			}
        }
    }
}

