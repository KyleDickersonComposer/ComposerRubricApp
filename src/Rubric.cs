public class Rubric
{
    public List<RubricCategory> Categories()
    {
        var categories = new List<RubricCategory>();

        var categoryData = CategoryDataCreator();

        var musicalAbility = new RubricCategory(categoryData[0].Name, categoryData[0].Info, categoryData[0].GradingInfo);
        var CreditsNotorietyAssociations = new RubricCategory(categoryData[1].Name, categoryData[1].Info, categoryData[1].GradingInfo);
        var TechnicalSkills = new RubricCategory(categoryData[2].Name, categoryData[2].Info, categoryData[2].GradingInfo);
        var MockupProductionSkills = new RubricCategory(categoryData[3].Name, categoryData[3].Info, categoryData[3].GradingInfo);
        var ArrangingOrchestrationSkills = new RubricCategory(categoryData[4].Name, categoryData[4].Info, categoryData[4].GradingInfo);
        var OnlinePresence = new RubricCategory(categoryData[5].Name, categoryData[5].Info, categoryData[5].GradingInfo);
        var SocialSkills = new RubricCategory(categoryData[6].Name, categoryData[6].Info, categoryData[6].GradingInfo);
        var OrganizationSkills = new RubricCategory(categoryData[7].Name, categoryData[7].Info, categoryData[7].GradingInfo);
        var ComputerProgramming = new RubricCategory(categoryData[8].Name, categoryData[8].Info, categoryData[8].GradingInfo);
        var IndustryKnowledge = new RubricCategory(categoryData[9].Name, categoryData[9].Info, categoryData[9].GradingInfo);

        categories.Add(musicalAbility);
        categories.Add(CreditsNotorietyAssociations);
        categories.Add(TechnicalSkills);
        categories.Add(MockupProductionSkills);
        categories.Add(ArrangingOrchestrationSkills);
        categories.Add(OnlinePresence);
        categories.Add(SocialSkills);
        categories.Add(OrganizationSkills);
        categories.Add(ComputerProgramming);
        categories.Add(IndustryKnowledge);

        return categories;
    }

    private List<ICategoryData> CategoryDataCreator()
    {
        var cd = new List<ICategoryData>();

        ICategoryData mba = new MusicalAbilityData();
        ICategoryData cna = new CreditsNotorietyAssociationsData();
        ICategoryData tsd = new TechnicalSkillsData();
        ICategoryData mps = new MockupProductionSkillData();
        ICategoryData ao = new ArrangingOrchestrationData();
        ICategoryData op = new OnlinePresenceData();
        ICategoryData ss = new SocialSkillsData();
        ICategoryData os = new OrganizationSkillsData();
        ICategoryData cp = new ComputerProgrammingData();
        ICategoryData ik = new IndustryKnowledgeData();

        cd.Add(mba);
        cd.Add(cna);
        cd.Add(tsd);
        cd.Add(mps);
        cd.Add(ao);
        cd.Add(op);
        cd.Add(ss);
        cd.Add(os);
        cd.Add(cp);
        cd.Add(ik);
        return cd;
    }

}
