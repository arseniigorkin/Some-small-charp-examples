

public class Calc
{
    public static double Average(int[] numbers)
    {
        double sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        return sum / numbers.Length;
    }

    // этот метод даёт возможность проверить деление (на исключение 0) прежде, чем выполнить, а потом выполнить.
    public static bool TryDevide(double divisible, double divisor, out double result)
    {
        result = 0;
        if (divisor == 0)
        {
            return false;

        }

        result = divisible / divisor;
        return true;
    }
}
