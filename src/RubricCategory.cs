public record RubricCategory
{
    public string CategoryName { get; set; }
    public string CategoryInfo { get; set; }
    public List<string> GradingInfo;

    public RubricCategory(string name, string info, List<string> gradeInfo)
    {
        CategoryName = name;
        CategoryInfo = info;
        GradingInfo = gradeInfo;
    }
}