internal class Program
{
    static void Main(string[] args)
    {
        string[] answer = new string[4];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = Console.ReadLine();
        }
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = Console.WriteLine();
        }
    }
}