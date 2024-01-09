public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Composer! What is your name?");
        var pc = new ProspectiveComposer();

        var nameValid = false;
        while (!nameValid)
        {
            var cn = Console.ReadLine();
            if (string.IsNullOrEmpty(cn))
            {
                Console.WriteLine("Invalid input. Please enter a valid name.");
            }
            else
            {
                pc.Name = cn;
                nameValid = true;
            }
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

            Console.WriteLine("Evaluate yourself based on the above criteria.");
            Console.WriteLine("Please input your grade number.");

            var inputValid = false;

            while (!inputValid)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result) && result > 0 && result <= cat[i].GradingInfo.Count)
                {
                    pc.Ratings.Add(cat[i].CategoryName, result);
                    inputValid = true;
                }
                else
                {
                    Console.WriteLine($"Invalid input. Please enter a valid grade number between 1 and {cat[i].GradingInfo.Count}.");
                }
            }
        }

        Console.WriteLine("Press enter to generate Report");
        Console.ReadLine();

        Console.WriteLine(pc.Name);
        for (int i = 0; i < cat.Count; i++)
        {
            Console.WriteLine($"{cat[i].CategoryName} Grade: {pc.Ratings[cat[i].CategoryName]} out of {cat[i].GradingInfo.Count}");
        }
    }
}
