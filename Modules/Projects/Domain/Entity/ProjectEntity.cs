namespace jhedgostBK.Modules.Projects.Domain.Entity;

public record ProjectEntity
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Description { get; set; }
    
    
    public ICollection<int> TechnologyIds { get; set; }    
    public ICollection<int> ImageIds { get; set; }
}