public class TechnicalSkillsData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public TechnicalSkillsData()
    {
        Name = "Techical Skills";
        Info = "This is you fluency with you DAW or Notation software.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 is the highest level of fluency when it comes to operating the highly complex software that composers work with on a daily basis. This level is characterized by: Familiarity with all keybinds, Understanding advanced functions of your software (i.e. Cubase Logical Editor, Macros or Plugins.), Extremely minimal use of mouse for regular software functions, A constant eye towards optimization");
        gi.Add("Grade 4 is the probably the level that is required to start working as an intern or studio assistant. Young composers should focus on this area if they want to make themselves useful while they build all of their other skiils. These composers have a good understanding of their software but they don't use it quite as efficiently as the composers from grade 5. Here are some things grade 4s do: Familiar with routing, DSP, file formats/codecs and their settings, Understand all of the functionality of their software, Good project organization, Overuse of the mouse, Lack of knowing all of the relevent keybinds.");
        gi.Add("Grade 3 is the level of most composers who have some understanding of what their software does but they havent invested enough time to develop mastery of everything. This composer typically doesn't use a template and rebuilds everything from scratch every track. They use the mouse for everything and lack even the most back keybinds. This composer though is able to good results.");
        gi.Add("Grade 2 is the level of someone who only uses prepackaged resources with zero understanding of how to reconstruct them. There is a low level of understanding of software functionality. This composer strugles with the software and fails to produce good results most of the time. This composer spends a very long time on a given track.");
        gi.Add("Grade 1 composers can't use their software either because they struggle with using a computer or they have zero experience with music software in general.");
    }
}
