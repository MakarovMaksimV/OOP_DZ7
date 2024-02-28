using System.Text;
using DZ7.core;
using DZ7.repository;

namespace DZ7.calculator.view
{
    public class CalculatorView
    {
        Repository rep = new Repository();
        double real;
        double img;
        string op;
        string z3;

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
                        z3 = add.GetResult(z1, z2).ToString(); 
						break;
					case "-":
						Subtraction sub = new ();
                        z3 = sub.GetResult(z1, z2).ToString();
						break;
					case "*":
                        Multiplication mult = new ();
                        z3 = mult.GetResult(z1, z2).ToString(); ;
						break;
					case "/":
                        Division div = new ();
                        z3 = div.GetResult(z1, z2).ToString();
						break;
					default:
						Console.WriteLine("Unknown operation");
						break;
                }

                string ms = Writer(z1, op, z2);
                Console.WriteLine(ms);
             
                rep.Write(ms);

                Console.WriteLine("Continue? (y/n)");
				string answer = Console.ReadLine();

				if (answer == "n") break;
			}
        }

		public string Writer(Complex z1, string op, Complex z2)
		{
			StringBuilder sb = new StringBuilder();
            sb.Append("(");
            sb.Append(z1.ToString());
            sb.Append(") ");
            sb.Append(op);
            sb.Append(" (");
            sb.Append(z2.ToString());
            sb.Append(") ");
            sb.Append("=");
            sb.Append(" ");
            sb.Append(z3);
            return sb.ToString();
        }
    }
}

