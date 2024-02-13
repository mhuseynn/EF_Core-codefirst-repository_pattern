using LibraryDb_Model.Entities.Abstracts;

namespace LibraryDb_Model.Entities.Concretes;

public class Department : BaseEntity
{

    public string Name { get; set; }



    public virtual ICollection<Teacher>? Teachers { get; set; }
}
