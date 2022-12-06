using System.Text.RegularExpressions;

internal class Task2
{
    static void Main()
    {
        string pattern = @"([+][0-9]{3}-(2)-[0-9]{3}-[0-9]{4})|([+][0-9]{3}\s(2)\s[0-9]{3}\s[0-9]{4})";

        while (true)
        {
            string temp = Console.ReadLine();

            if (temp == "End" || temp == "END")
            {
                break;
            }
            else
            {
                if (Regex.IsMatch(temp, pattern))
                {
                    Console.WriteLine(temp);
                }
            }
        }
    }
}