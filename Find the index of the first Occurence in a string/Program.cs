internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Please Enter the haystack");
        string haystack = Console.ReadLine();
        Console.WriteLine("Please Enter the needle");
        string needle = Console.ReadLine(); 
        int i = StrStr(haystack, needle);
        Console.WriteLine(i);

    }
    public static int StrStr(string haystack, string needle)
    {
        int haystacklen = haystack.Length;
        int needlelen = needle.Length;
        if (haystacklen < needlelen)
        {

            return -1;

        }
        if (needlelen == 0) 
        {
           return 0;
        }
        for(int i = 0; i <= haystacklen - needlelen; i++)
        {
            if(haystack.Substring(i, needle.Length) == needle) { return i; }
        }

        return -1; 

    }
}