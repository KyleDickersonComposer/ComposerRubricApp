public class ComputerProgrammingData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public ComputerProgrammingData()
    {
        Name = "Computer Programming Skills";
        Info = "This is not a common skill for a composer to have today. Composers that are able to program often function as a technical sound designer because technical composers are a rare position game companies to employ.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 composers are able to program at approximately the same level as an employable programmer. These composers are rare but are valuable for certain companies and situations. These composers understand how to use complex game engines (i.e. Unity3D and Unreal Engine) and can easily integrate audio middleware solutions or build their own custom solutions for a given scenario. These high-tech composers can also build their own tools whether programs or web servers to enhance their operations as a composer. These composers can build audio tools for the rest of the audio team on a given project.");
        gi.Add("Grade 4 is a composer who can code to a scripting level but can't build things that resemble real software. This composer can integrate audio middleware solutions with help from the other programmers on the team. This composer can communicate succesfully with a technical and artistic sides of a given project. This composer is very proficient when using the editors that come bundled with audio middleware solutions (i.e. WWise Editor or Fmod Studio.), This composer may be able to do some visual scripting in Unreal Engine or Unity3D.");
        gi.Add("Grade 3 composers are only able to do a small amount of work in audio middleware editors. They have no understanding of coding but can sort of talk their way through a problem with the assistance of a techincal person.");
        gi.Add("Grade 2 composers can't use audio middleware at all and are completely depended on people who are more techinical. Very limited understanding of programming.");
        gi.Add("Grade 1 composers don't know what a computer is or what programming is.");
    }
}