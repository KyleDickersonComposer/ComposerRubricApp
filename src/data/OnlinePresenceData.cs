public class OnlinePresenceData : ICategoryData
{
    public string Name { get; set; }
    public string Info { get; set; }
    public List<string> GradingInfo { get; set; }

    public OnlinePresenceData()
    {
        Name = "Online Presence";
        Info = "This is an increasingly important factor in getting gigs. Many composers say that this should be a high priority. In the internet age a large boundary that separates composers from being successful is their discoverability. You have to put stuff out there for people to see it. And, it has to be decent.";

        List<string> gi = new();
        GradingInfo = gi;

        gi.Add("Grade 5 is a composer with an established social media following (i.e. youtube channel) and a polished website with high quality reel and credits if applicable. This composer isn't wasting their time on twitter or youtube and has a polished procedure for creating material that engages their audience. Clients look at their website and youtube page and are impressed by the quality of the material and how that material is presented. This composer has links that work and a way to easily contact them. If this composer has a blog, it is updated regularly and doesn't have year long gaps in their output (if you don't want to blog, don't blog!).");
        gi.Add("Grade 4 is a composer that has a strong online presence but the website looks out of date and doesn't have polished information on the composer or their material. This composer uses wordpress or SquareSpace and makes a website that functions well. This composer has an online presence that is highly functional but not as engaging as a grade 5 composer. ");
        gi.Add("Grade 3 composers might have a website or social media channel that is under serviced and lacks polish. It is up in the air whether or not their links work or if their website has up to date information. They probably have a blog from 5 years ago as their latest blog and no new material from the last two years. This composer might have an online presence that turns off clients because of excessive political content or bad spirited ranty material being posted on their social media. Remember that real human beings can read the stuff you post online. It's not just a bunch of degenerates in a chat room.");
        gi.Add("Grade 2 is a composer that may or may not have a website or youtube channel. If they have it they content is not of high quality and it is not up to date. There are clear quality concerns not just with the material but with its presentation. Their online footprint gives all clients and colleagues a bad taste in their mouth.");
        gi.Add("Grade 1 composers don't have anything posted online.");
    }
}
