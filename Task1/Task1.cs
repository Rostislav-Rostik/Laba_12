using System.Text.RegularExpressions;

internal class Task1
{
    static void Main()
    {
        string pattern = @"^[A-Z]{1}[a-z]*\s[A-Z]{1}[a-z]*";

        while (true) 
        {
            string temp = Console.ReadLine();

            if (temp == "END" || temp == "End")
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