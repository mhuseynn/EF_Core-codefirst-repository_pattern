using LibraryDb_Model.Entities.Abstracts;

namespace LibraryDb_Model.Entities.Concretes;

public class Author : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? About { get; set; }


    // Navigation Property
    public virtual ICollection<Book>? Books { get; set; }

}
