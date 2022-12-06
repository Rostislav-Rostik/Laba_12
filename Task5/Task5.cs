using System.Text.RegularExpressions;

internal class Task5
{
    static void Main()
    {
        string pattern = @"\s?\w*[A-Z,a-z]\w(@)\w*[a-z, A-Z]\w[.]\w*[a-z]";
        while (true)
        {
            var temp = Console.ReadLine().Split();
            if (temp[0] == "END" || temp[0] == "End")
            {
                break;
            }
            else
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (Regex.IsMatch(temp[i], pattern))
                    {
                        Console.WriteLine(temp[i]);
                    }
                }
            }
        }

    }
}