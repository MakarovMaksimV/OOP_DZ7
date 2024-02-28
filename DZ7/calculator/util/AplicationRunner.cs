
using DZ7.calculator.repository.impl;
using DZ7.calculator.view;

namespace DZ7
{
	public class AplicationRunner
	{
		public static void Run()
		{
			IRepository repository = new Repository("repository.txt");
			CalculatorView calculatorView = new();
			calculatorView.Run();
		}
	}
}

