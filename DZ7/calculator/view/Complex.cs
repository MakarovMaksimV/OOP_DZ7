using System;

namespace DZ7.core
{
    class Complex
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

        public Complex complexNumber1(double real, double img)
        {
            return new Complex(real, img);
        }

        public Complex complexNumber2(double real, double img)
        {
            return new Complex(real, img);
        }

    }

}

