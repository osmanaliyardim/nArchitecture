using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Model : Entity
    {
        // To have a relation with brand table
        public int BrandId { get; set; }

        public string Name { get; set; }
        public decimal DailyPrice { get; set; } 
        public string ImageUrl { get; set; }

        // Defined as virtual to be able to use more than one ORMs.
        // A model can not have more than one model.
        public virtual Brand? Brand { get; set; }

        // A parameterless constructor is needed for EntityFramework mapping
        public Model()
        {
                
        }

        public Model(int id, int brandId, string name, decimal dailyPrice, string imageUrl) : this()
        {
            Id = id;
            BrandId = brandId;
            Name = name;
            DailyPrice = dailyPrice;
            ImageUrl = imageUrl;
        }
    }
}