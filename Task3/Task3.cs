using System.Text.RegularExpressions;

internal class Task3
{
    static void Main()
    {
        string pattern = @"(\w)\1+";
        string target = @"$1";

        while (true)
        {
            string temp = Console.ReadLine();


            if (temp == "End" || temp == "END")
            {
                break;
            }
            else
            {
                Regex regex = new Regex(pattern);
                string result = regex.Replace(temp, target);
                Console.WriteLine(result);
            }
        }
    }
}