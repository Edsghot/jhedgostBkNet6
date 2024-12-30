namespace jhedgostBK.Modules.Services.Domain.Entity;

public record ServiceEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}