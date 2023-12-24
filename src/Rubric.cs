public class Rubric
{
    public List<RubricCategory> Categories()
    {
        var categories = new List<RubricCategory>();

        var categoryData = CategoryDataCreator();

        var musicalAbility = new RubricCategory(categoryData[0].Name, categoryData[0].Info, categoryData[0].GradingInfo);
        //var CreditsNotorietyAssociations = new RubricCategory();
        //var TechnicalSkills = new RubricCategory();
        //var MockupProductionSkills = new RubricCategory();
        //var ArrangingOrchestrationSkills = new RubricCategory();
        //var OnlinePresence = new RubricCategory();
        //var SocialSkills = new RubricCategory();
        //var OrganizationSkills = new RubricCategory();
        //var ComputerProgramming = new RubricCategory();
        //var IndustryKnowledge = new RubricCategory();

        categories.Add(musicalAbility);
        //categories.Add(CreditsNotorietyAssociations);
        //categories.Add(TechnicalSkills);
        //categories.Add(MockupProductionSkills);
        //categories.Add(ArrangingOrchestrationSkills);
        //categories.Add(OnlinePresence);
        //categories.Add(SocialSkills);
        //categories.Add(OrganizationSkills);
        //categories.Add(ComputerProgramming);
        //categories.Add(IndustryKnowledge);

        return categories;
    }

    public List<ICategoryData> CategoryDataCreator()
    {
        var cd = new List<ICategoryData>();

        ICategoryData musicAbilityData = new MusicalAbilityData();

        cd.Add(musicAbilityData);
        return cd;
    }

}
