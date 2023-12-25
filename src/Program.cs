public class Program
{
    public static void Main(string[] args)
    {
        var rub = new Rubric();
        var cat = rub.Categories();

        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine(cat[i].CategoryName);
            Console.WriteLine(cat[i].CategoryInfo);
            Console.ReadLine();

            for (int j = 0; j < cat[i].GradingInfo.Count; j++)
            {
                Console.WriteLine(cat[i].GradingInfo[j]);

            }

            Console.ReadLine();
        }
    }
}