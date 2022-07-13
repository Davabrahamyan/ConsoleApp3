// See https://aka.ms/new-console-template for more information
class Program
{
    public static int Sum(int []b,int c)
    {
       for(int i = 0; i < b.Length; i++)
        {
            c=b[i]+ c;
        }
        return c;
    }
    static void Main(string[] args)
    {
        
        int t = Convert.ToInt32(Console.ReadLine());
        int []arr = new int[t];
        for (int i = 0; i < t; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

      
        Console.WriteLine(Sum(arr, 0));
        
    }
}
