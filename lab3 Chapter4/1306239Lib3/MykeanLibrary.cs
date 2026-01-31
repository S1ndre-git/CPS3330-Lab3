namespace MyKeanLib;

public class MyKeanLibrary
{
    // 2 numbers: a^b
    public double MyPow(double a, double b)
    {
        return Math.Pow(a, b);
    }

    // 3 numbers: (a^b)^c
    public double MyPow(double a, double b, double c)
    {
        double first = Math.Pow(a, b);
        return Math.Pow(first, c);
    }
}
