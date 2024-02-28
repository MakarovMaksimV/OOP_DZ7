using System;
using DZ7.calculator.util;
using DZ7.repository;

namespace DZ7.calculator.core.impl
{
	public class ComplexCalculator
	{
		Dictionary<int, Calculate> valueKey;

        public ComplexCalculator()
        {
            valueKey.Add((int)OperationType.ADD, new Addition());
            valueKey.Add((int)OperationType.ADD, new Subtraction());
            valueKey.Add((int)OperationType.ADD, new Multiplication());
            valueKey.Add((int)OperationType.ADD, new Division());
        }
    }
}

