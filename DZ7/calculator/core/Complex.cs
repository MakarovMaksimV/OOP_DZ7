namespace DZ7.core
{
    public class Complex
    {
        private double real;
        private double img;

        public Complex(double real, double img)
        {
            this.real = real;
            this.img = img;
        }

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Img
        {
            get { return img; }
            set { img = value; }
        }

        public override string ToString()
        {
            return real + "+" + img + "i";
        }
    }
}

