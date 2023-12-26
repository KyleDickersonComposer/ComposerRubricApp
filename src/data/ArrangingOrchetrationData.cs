public class ArrangingOrchestrationData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public ArrangingOrchestrationData()
    {
        Name = "Arranging and Orchestration Skills";
        Info = "This is a composers ability to properly structure their music and think orchestrally.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 is the highest level of arranging and orchestration ability. This is a level of proficiency that is embodied by John Williams. His understanding is not parallelled by any other living composer. His work is characterized by: Great separation of foreground/middleground/background, Use of Figures/Fills/Filigre/Hits/Counterlines/Pads/Accompaniment, Great use of arranging techniques (i.e. Stops, Pyramids, Planing, Reharmonization, Pedals, Vamps, Thickened Line/Drop Voicing), An ability to overload the sound space for a magisterial effect, Always great choice of register for exposed lines, Fun instrumental combinations for effects (There is a large body of tricks from the hollywood tradition of scoring.), All elements are distinguished via pitch and timbral juxtaposition.");
        gi.Add("Grade 4 is the level of most working arrangers today. There is a fairly large drop off from Williams' work to these arrangers though. These arrangers might be highly specialized in one area without the complete background that Williams brings. This leads to arrangers that work well in one medium (i.e. Big Band) and are very lacking in the other (i.e. Classical Arranging for small groups or orchestra.), This arranger has a good understanding of some of the arranging techniques but uses them in a rigid way. An arranger that specializes in media music or classical music might would sound well in their medium but might overuse tired tropes.");
        gi.Add("Grade 3 is a group of composers that get mixed results in their medium of specialization, but can sound good when it works. These composers don't have the tools or knowledge of grades 4 and 5 they rely on their instinct. This arranger can't leave their area of specialization at all.");
        gi.Add("Grade 2 composers are beginners who have a very limited understanding of instruments and music in general. They don't know basics of orchestration like instrument registers or the dynamic capabilities of said registers. They lack a realistic sense of what the instrument sound like in combination or by themselves because of lack of experience interacting with and writing for musicians. This composer has heard the word arrangement and kind of understands what it is but has no real knowledge of it.");
        gi.Add("Grade 1 is a group of composers who don't know what the categories of instruments available to the composer are let alone the instruments in those categories. This composer sees red notes in their notation software then changes the note so that it isn't red. This composers doesn't know what an arrangement is or what arranging is.");
    }
}
