namespace Bhaskara
{
    public static class Bhaskarer
    {
        public static (double?, double?) Raizes(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                return (null, null);
            }

            double raizDelta = Math.Sqrt(delta);
            double x1 = (-b + raizDelta) / (2 * a);
            double x2 = (-b - raizDelta) / (2 * a);

            return (x1, x2);
        }
    }
}
