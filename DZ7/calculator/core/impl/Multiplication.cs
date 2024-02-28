using DZ7.core;

namespace DZ7.repository
{
    public class Multiplication : Calculate
    {
        public override Complex GetResult(Complex z1, Complex z2)
        {
            return new Complex(z1.Real * z2.Real - z1.Img * z2.Img,
                + z1.Real * z2.Img + z1.Img * z2.Real);
        }
    }
}

