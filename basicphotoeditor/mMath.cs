using System;

namespace basicphotoeditor
{
    class mMath
    {
        /*
         * mMath
         * This class contains additional mathematical operations
         * Remember to credit your sources! 
         * 
         * 24.5.2017 - Created by Samuli Kumo
         */


        /*
         * RealToFraction converter function
         * 
         * Algorithm by Ian Richards:
         * https://www.maa.org/sites/default/files/pdf/upload_library/22/Allendoerfer/1982/0025570x.di021121.02p0002y.pdf
         * 
         * C# implementation by Kay Zed
         * https://stackoverflow.com/a/32903747
         */
        public Fraction RealToFraction(double value, double accuracy)
        {

            if (accuracy <= 0.0 || accuracy >= 1.0)
            {
                throw new ArgumentOutOfRangeException("accuracy", "Must be > 0 and < 1.");
            }

            int sign = Math.Sign(value);

            if (sign == -1)
            {
                value = Math.Abs(value);
            }

            // Accuracy is the maximum relative error; convert to absolute maxError
            double maxError = sign == 0 ? accuracy : value * accuracy;

            int n = (int)Math.Floor(value);
            value -= n;

            if (value < maxError)
            {
                return new Fraction(sign * n, 1);
            }

            if (1 - maxError < value)
            {
                return new Fraction(sign * (n + 1), 1);
            }

            double z = value;
            int previousDenominator = 0;
            int denominator = 1;
            int numerator;

            do
            {
                z = 1.0 / (z - (int)z);
                int temp = denominator;
                denominator = denominator * (int)z + previousDenominator;
                previousDenominator = temp;
                numerator = Convert.ToInt32(value * denominator);
            }
            while (Math.Abs(value - (double)numerator / denominator) > maxError && z != (int)z);

            return new Fraction((n * denominator + numerator) * sign, denominator);
        }     
        // End of RealToFraction converter.
    }
}
