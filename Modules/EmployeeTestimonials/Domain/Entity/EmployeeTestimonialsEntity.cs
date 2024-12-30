namespace jhedgostBK.Modules.EmployeeTestimonials.Domain.Entity;

public record EmployeeTestimonialsEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Message { get; set; }
    public string Occupation { get; set; }
}