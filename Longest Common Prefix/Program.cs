internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of string");
        int count = int.Parse(Console.ReadLine());

        string[] strs = new string[count];

        for (int i = 0; i < strs.Length; i++)
        {
            Console.WriteLine("Enter string " +(i + 1) + ":");
            strs[i] = Console.ReadLine();
        }
        string t =  LongestCommonPrefix(strs);
        Console.WriteLine(t);
        

    }

    public static string LongestCommonPrefix(string[] strs)
    {
       

        string prefix = "";
        if (strs == null || strs.Length == 0) return prefix;

        for (int i = 0;i < strs[0].Length;i++)
        {
            char currentChar = strs[0][i];

            for(int j= 0; j < strs.Length; j++)
            {
                if (i == strs[j].Length ||strs[j][i] != currentChar)
                    return prefix;
            }
            prefix = prefix + currentChar;
        }
        return prefix;

    }





    }