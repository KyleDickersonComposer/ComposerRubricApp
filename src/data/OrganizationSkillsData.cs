public class OrganizationSkillsData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public OrganizationSkillsData()
    {
        Name = "Organization Skills";
        Info = "These are extremely underated skills for any professional let alone composers. The amount of data, communications, and logistical work a composer is overwhelming. This is the majority of what you will be doing by the way.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 composers have a great understanding of time management using a timeblocking and kanban style organization techniques. This composer keeps journals for thoughts and reponsibilities of their daily operations. Excel or Google Sheets are a fundamental tool for organizing a project. This composer has a personal slack channel for their collabortors with helpful documents and discussion boards. This composer has a good understanding of Quickbooks and other business management tools.");
        gi.Add("Grade 4 composers manage things well but without all of the tools of the grade 5 composers. They may not be able to automate things to the level that is necessary due to a lack of understanding that a given capability exists. This composer might use inadequate tools for the job like pen and paper when Excel is superior or text documents where kanban systems are better for the situation. Repeating menial tasks are a common theme.");
        gi.Add("Grade 3 composers are not organized to a professional standard and there are loose ends everywhere. This composer doesn't use very many organization tools, and if they did, they would use them poorly. This composer can use software but chooses not to learn or fails to understand the necessity of a very detailed oriented proceure.");
        gi.Add("Grade 2 is a composer who tries to remember every detail and fails to even write things down on paper. They are very noticably disorganized to the client. This is the type of composer that try to do whatever work is possible so that they can continue to tweak their procedure and add sophistication to their process.");
        gi.Add("Grade 1 is a composer who is completely disorganized and probably has bigger problems.");
    }
}
