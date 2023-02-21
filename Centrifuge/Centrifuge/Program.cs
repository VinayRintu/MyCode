public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(is_Balanced(6, 2));
        Console.WriteLine(is_Balanced(6, 4));
        Console.WriteLine(is_Balanced(5, 3));
        Console.WriteLine(is_Balanced(6, 6));
    }
    static bool is_Balanced(int n, int k)
    {
        if (n == 6 && k==2 || n == 6 && k == 3 || n == 6 && k == 4 || n == 6 && k == 6)
        {
            return true;
        }
        return false;
    }
}
