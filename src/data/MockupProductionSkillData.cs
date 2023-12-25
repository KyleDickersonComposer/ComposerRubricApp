public class MockupProductionSkillData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }
    public MockupProductionSkillData()
    {
        Name = "Mockup and Production Skills";
        Info = "These are one of the most fundamental skills for becoming a working composer. Many composers with an elite musical background overlook this skill and composers with less chops tend to specialize in it.";

        List<string> gi = new List<string>();
        GradingInfo = gi;

        gi.Add("Grade 5 is the top level of production skill. These are mockups that could sit in a film or game without being noticed by musical laymen. Though veteran producers would recognize the some imperfections in the musical quality of the mockup. Some names who produce at this level are: Hans Zimmer, Jason Graves, Trevor Morris.");
        gi.Add("Grade 4 is a level of production skills where a musical laymen would notice a slight drop off from AAA and blockbuster level production (if listening with a high quality environment with tracks isolated), but it would not impact how the music functions in context.");
        gi.Add("Grade 3 is the entry level of music production skill for a composer. If you can't compose at this level you will have a hard time working. This composer knows how to work with synths drones and pads along with production drum libraries to beef up their track. They use common tricks like: String ostinatos, Synth pads, Synth drones, Synth arps, Brass rips, Production drum libraries, Twelve horn patch melodies, Additive rhythm and odd meters, Sub bass, Risers and downers, Hits, Impacts, and Booms.");
        gi.Add("Grade 2 is the most common level of music production chops. This level of composer is able to compose at the same level of a grade 3 composer but lacks the production chops to make it sound good enough to function correctly. This level of composer often has issues with: Bad eq and compression choices, Poor master bus processing, Lacking a premixed template that automatically exports properly stems, Lack of a spacial (i.e. the 3D effect that a good stereo mix gives you.) element due to over-reliance on headphones for mixing,  Messed up reverb and delay, lack of dynamics due to over limiting or poor arrangement of your music, Poor balance of levels among the instruments, Too much or not enough low end, Piercing mids.");
        gi.Add("Grade 1 is a level of prodction skill that is extermely poor relative to a professional standard of work. This level of production is rare because most people go to youtube and find a plethora of marketing content that pushes people in the direction of decent sounding libraries and production tools. This level is characterize by: Mockups made with notation software or general midi sounds, Arranger keyboards with crappy sounds, Stock instruments from the early 2000s, A complete lack of basic production tools like eq, panning, and limiting, Raw sounds without processing, Lack of quantization, Horrible drum loops, Badly missused production elements (i.e. risers, downers, booms, impacts), Dead sounding midi programming.)");
    }
}