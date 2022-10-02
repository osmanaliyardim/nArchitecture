using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        
        // A brand might have more than one model.
        public virtual ICollection<Model> Models { get; set; }
        
        public Brand()
        {
        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}