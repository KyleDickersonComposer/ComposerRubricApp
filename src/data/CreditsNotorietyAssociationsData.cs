public class CreditsNotorietyAssociationsData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public CreditsNotorietyAssociationsData()
    {
        Name = "Credits, Notoriety, and Associations";
        Info = "These are the signals to clients and colleagues that your work is up to par. Getting work is about doing the right things and finding the right people.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 composers have established careers with AAA credits and industry awards. These composers have great networks and are friendly with most other established composers in their field. This composer might have gone to a well regarded institution with a great alumni network. This composer also lives in a a hub for the has plenty of opportunities for their area of specialization.");
        gi.Add("Grade 4 composers don't have the credits at a AAA level but have similar awards that are appropriate for their level. These composers are friends with grade 5 composers and other grade 4s. This composer might also have gone to a well established institution and live in a bustling area where a lot of opportunities and work are available.");
        gi.Add("Grade 3 composers are composers who are friendly with some composers but don't make themselves available at trade events and shows. This composer might have a few awards. This composer may have a few credits posted on their website.");
        gi.Add("Grade 2 composers have very few credits or awards and have gone to very few in person industry conventions. They might participate in some online events. This composer is anonymous to most industry people.");
        gi.Add("Grade 1 this person in on the outside looking in.");
    }
}
