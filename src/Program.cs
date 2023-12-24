public class Program
{
    public static void Main(string[] args)
    {
        var rub = new Rubric();
        var cat = rub.Categories();

        Console.WriteLine($"{cat[0].CategoryName}: {cat[0].CategoryInfo}");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        var gradingInfoList = cat[0].GradingInfo;
        foreach (var item in gradingInfoList)
        {
            Console.WriteLine(item);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();
    }
}