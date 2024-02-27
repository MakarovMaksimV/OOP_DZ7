using System;
using System.Numerics;

namespace DZ7
{
    public class Subtraction : Calculate
    {
        public override Complex GetResult(Complex z1, Complex z2)
        {
            return new Complex (z1.Real - z2.Real,z1.Imaginary - z2.Imaginary);
        }
    }
}

