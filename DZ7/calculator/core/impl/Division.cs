using DZ7.core;

namespace DZ7
{
    public class Division : Calculate
    {
        public override Complex GetResult(Complex z1, Complex z2)
        {
            double Denominator = z2.Real * z2.Real + z2.Img * z2.Img;
            return new Complex((z1.Real * z2.Real + z1.Img * z2.Img) / Denominator,
                (z2.Real * z1.Img- z2.Img * z1.Real) / Denominator);
        }
    }
}

