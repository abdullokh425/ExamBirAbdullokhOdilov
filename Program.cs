namespace FirstModulRetakeExam_AbdullokhOdilov;

class Program
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var result = RemoveTwoFirstAndLastChars(text);
        Console.WriteLine(result);
    }
    
    // 1
    public static bool EndStartWith(string text)
    {
        var startsWith = text.StartsWith("crud");
        var endsWith = text.EndsWith("crud");

        if (startsWith == endsWith is true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 2
    public static int CountThreeDigitAndEvenNumbers(List<int> numbers)
    {
        var count = 0;
        foreach (var number in numbers)
        {
            if (number > 99 && number < 1000 && number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    // 3
    public static bool IslowerEndAndStart(List<string> texts)
    {
        foreach (var text in texts)
        {
            if (char.IsLower(text[0]) && char.IsLower(text[text.Length - 1]))
            {
                return true;
            }
        }
        return false;
    }
    
    // 4
    public static string RemoveTwoFirstAndLastChars(string text)
    {
        var result =text.Remove(0, 2);
        result = result.Remove(result.Length - 2);
        
        return result;
    }
}