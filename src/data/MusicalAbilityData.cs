public class MusicalAbilityData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public MusicalAbilityData()
    {
        Name = "Musical Ability";
        Info = "This is your musical talent and craft. It has virtually zero influence on your ability to get a job (or successfully fulfill its requirements), but other composers recognize it as extremely valueable and admirable.";

        List<string> gi = new List<string>();
        gi.Add("Grade 10 is the highest level of musical ability and there are few living people who are able to attain it. Musicians at this level are close to the musical proficiency of a great composer but use their skills for a more practical end. Some musicians at this level are: Hugo Friedhofer, Miklos Rozsa, Bernard Herrmann, Conrad Salinger, Henry Mancini, John Scott Trotter, Barry Harris, John Clayton, Sammy Nestico, Bill Holman, Billy May, Hank Jones.");
        gi.Add("Grade 9 is a similarly unattainable level of musicality, but, you have to draw the line somewhere! You could put virtually any above average composer/arranger from the 50s in this category. Here are some names: Ennio Morricone, Gil Evans, Claus Ogerman, Eddie Sauter, Bill Finegan, Leigh Harline, Oliver Wallace, Carl Stalling, Erich Korngold, Chick Corea.");
        gi.Add("Grade 8 is a level of skill that most people are familiar with. Some of the composers from this level are probably your favorites. These composers are fantastically skilled and talented but don't shine quite as bright as the composers from grades 9 and 10. Here are a few names: John Williams, Jerry Goldsmith, Elmer Bernstein, Alexander Courage, Alex North, David Raksin, John Berry, Alfred Reed.");
        gi.Add("Grade 7 is a group of highly successful and skillful composers who have had great success in a domain. These composers were so successful in their domain that they are highly associated with it and that makes them first call. Here are some names: Bruce Broughton, Howard Shore, Vangelis, Garry Schyman, Martin O'Donnell, Harry Gregson-Williams, James Newton Howard, John Powell, Patrick Doyle, Thomas Newman.");
        gi.Add("Grade 6 is a group of premier game composers that have been recognized for their success. They are regularly asked to pitch for the next big AAA composing gig. Here are some names: Gordy Haab, Stephen Barton, Austin Wintory, Wilbert Roget II, Gareth Coker, Yoko Shimomura, Grant Kirkhope, Penka Kouneva, Jason Graves.");
        gi.Add("Grade 5 composers are musicians out of music school who have an elite background. They often have high-level performance experience, advanced music composition/arranging, or a jazz improvization background. These composers could be successful as professional musicians on their own and are versatile and highly valuable as a composer's assistant.");
        gi.Add("Grade 4 composers are often ghostwriters and co-composers on large projects. They don't have the acclaim of a grade 6 composer and that means they are often working without credit. These composers have a good musical background often stemming from a degree at a music school in instrumental performance or music composition.");
        gi.Add("Grade 3 composers are often talented instrumentalists or producers without a strong musical background. These composers are the ones who work their way up bit by bit often in the hands of a skilled mentor. It may take years before this composer is able to work professionally.");
        gi.Add("Grade 2 composers are the most common type of composer in todays climate. This type of composer is exemplified by Hans Zimmer. A composer who has a weak musical background and is limited by his lack of musical craft. This type of composer is heavily reliant on ghostwriters and orchestrators.");
        gi.Add("Grade 1 composers are at the very early stage of their musical development. They have quite a bit of work to do before they can get access to a high quality mentor. This composer should use as many resources as they can to level up their musical skills. Music school is a good choice or maybe they should play some Mozart.");

        GradingInfo = gi;
    }

}
