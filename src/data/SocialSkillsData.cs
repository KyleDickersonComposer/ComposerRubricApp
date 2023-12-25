public class SocialSkillsData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public SocialSkillsData()
    {
        Name = "Social Skills";
        Info = "These are the in person skills that lead to client and colleagues liking you on a personal level. These include public speaking, vibe, and being nice.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 is a composer that is highly socially graceful speaks well without looking too self conscious or giving a bad vibe. This composer can introduce themselves and talk about their work in an engaging way. This composer isn't overbearing in trying to push their junk and is marketing quietly. This composer avoids the gross marketing tropes that are pushed on social media. And, they can engage with other people and seem interested in the work of others.");
        gi.Add("Grade 4 is a composer that fills the function of a grade 5 composer but does it with less grace. This composer might be slightly awkward or have a bad vibe. This composer might not be able to maintain peoples interest.");
        gi.Add("Grade 3 is a composer that can't talk about their work and lacks social graces. This composer might be outright rude or inconsiderate. ");
        gi.Add("Grade 2 is a composer that is extremely offputting and is unlikely to make any connections with civilized people.");
        gi.Add("Grade 1... yup...");
    }
}
