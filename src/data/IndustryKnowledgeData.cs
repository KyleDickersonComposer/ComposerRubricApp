public class IndustryKnowledgeData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public IndustryKnowledgeData()
    {
        Name = "Industry Knowledge";
        Info = "This is a composers knowledge of the field and the people in it.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 3 is a composer that is very familiar with every detail of their field. For games its the process of being a game composer and working with your clients (Same for all other areas). This composer not only knows everything about the industry but they know everything about every job in the industry. They are familiar with those jobs and have friends that do those jobs. They are familiar with different sets of approaches to the same problem set.");
        gi.Add("Grade 2 composers are somewhat knowledgeable in their field but aren't that interested in things that don't directly impact them.");
        gi.Add("Grade 1 composers have very limited understanding of their field and don't know anybody who works in their field. Also, they don't understand what they did even if they knew them.");
    }
}
