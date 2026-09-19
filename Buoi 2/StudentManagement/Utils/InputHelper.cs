namespace StudentManagement.Utils;

// Module nho: ham nhap lieu dung chung
public static class InputHelper
{
    public static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine()?.Trim() ?? string.Empty;
    }

    public static double ReadDouble(string prompt, double min = 0, double max = 10)
    {
        while (true)
        {
            Console.Write($"{prompt} ({min}-{max}): ");
            if (double.TryParse(Console.ReadLine(), out double v) && v >= min && v <= max)
                return v;
            Console.WriteLine("Diem khong hop le, nhap lai!");
        }
    }
}
