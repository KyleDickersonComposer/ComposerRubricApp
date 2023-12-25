public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Composer! What is your name?");
        var cn = Console.ReadLine();
        var pc = new ProsectiveComposer();

        if (string.IsNullOrEmpty(cn))
        {
            Console.WriteLine("Invalid input. Please enter a valid name.");
            cn = Console.ReadLine();
        }
        else
        {
            pc.Name = cn;
        }

        var rub = new Rubric();
        var cat = rub.Categories();

        for (int i = 0; i < cat.Count; i++)
        {
            Console.WriteLine(cat[i].CategoryName);
            Console.WriteLine(cat[i].CategoryInfo);

            for (int j = 0; j < cat[i].GradingInfo.Count; j++)
            {
                Console.WriteLine(cat[i].GradingInfo[j]);

            }

            Console.WriteLine("Evaluate yourself based on the above critera.");
            Console.WriteLine("Please input your grade number.");

            bool done = false;

            while (!done)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result) && result > 0 && result <= cat[i].GradingInfo.Count)
                {
                    pc.ratings.Add(cat[i].CategoryName, result);
                    done = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid grade number between 1 and {0}.", cat[i].GradingInfo.Count);
                }
            }
        }

        Console.WriteLine("Press enter to generate Report");
        Console.ReadLine();

        for (int i = 0; i < cat.Count; i++)
        {
            Console.WriteLine($"{cat[i].CategoryName} Grade: {pc.ratings[cat[i].CategoryName]} out of {cat[i].GradingInfo.Count}");
        }
    }
}