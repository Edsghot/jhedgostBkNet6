namespace jhedgostBK.Modules.Team.Domain;

public record TeamEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ProfilePictureUrl { get; set; }
    public int ExperienceYears { get; set; }
    public string Position { get; set; }
    public string LinkedInUrl { get; set; }
    public string GitHubUrl { get; set; }
    public string InstagramUrl { get; set; }
}