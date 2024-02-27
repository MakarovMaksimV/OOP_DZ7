using System;
using System.Numerics;

namespace DZ7
{
    public class Division : Calculate
    {
        public override Complex GetResult(Complex z1, Complex z2)
        {
            double Denominator = z2.Real * z2.Real + z2.Imaginary * z2.Imaginary;
            return new Complex((z1.Real * z2.Real + z1.Imaginary * z2.Imaginary) / Denominator,
                (z2.Real * z1.Imaginary - z2.Imaginary * z1.Real) / Denominator);
        }
    }
}

