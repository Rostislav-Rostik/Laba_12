using System.Text.RegularExpressions;

internal class Task4
{
    static void Main()
    {
        string pattern = @"<a\shref=\W((\W|\w)*)\W>\s?(.*)\s?<\/a>";

        string target = "[URL href=$1>$3[/URL]";

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