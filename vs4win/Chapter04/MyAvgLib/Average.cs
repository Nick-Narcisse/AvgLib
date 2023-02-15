namespace MyAvgLib
{
    public static class Average
    {
        public static double Avg(double a, double b)
        {
            return (a + b) / 2;
        }

        public static double Avg(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
    }
}