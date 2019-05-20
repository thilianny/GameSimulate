using System;
using System.Security.Cryptography;
using MathNet.Numerics.Distributions;

namespace TestApp
{
    public class Random
    {
        internal static class PureRandom
        {
            private static readonly RNGCryptoServiceProvider Rnd;

            static PureRandom() => Rnd = new RNGCryptoServiceProvider();

            private static byte[] RandomBytes
            {
                get
                {
                    var x = new byte[4];
                    Rnd.GetBytes(x);
                    return x;
                }
            }

            private static byte _roundModifier = 10;

            public static byte RoundModifier
            {
                get => _roundModifier;
                set
                {
                    if (value > 10)
                        throw new ArgumentOutOfRangeException(nameof(value));
                    _roundModifier = value;
                }
            }

            public static double Common => FromRange(0.0, 1.0);

            private static double FromRange(double min, double max)
            {
                if (min > max)
                    throw new ArgumentOutOfRangeException(nameof(max));
                if (min == max)
                    return min;

                var rand = BitConverter.ToUInt32(RandomBytes, 0);

                return Math.Round(min + ((max - min) * rand / uint.MaxValue), _roundModifier);
            }


            public static int FromRange(int min, int max)
            {
                if (min > max)
                    throw new ArgumentOutOfRangeException(nameof(max));
                if (min == max)
                    return min;

                var diff = (long) max - min + 1;
                while (true)
                {
                    var rand = BitConverter.ToUInt32(RandomBytes, 0);
                    var upper = (long) uint.MaxValue + 1;
                    var remainder = upper % diff;

                    if (rand < upper - remainder)
                        return (int) (min + (rand % diff));
                }
            }

            public static double Gaussian(double mean, double stdDev)
            {
                var dist = new Normal(mean, stdDev);
                return dist.Sample();
            }
    }
}