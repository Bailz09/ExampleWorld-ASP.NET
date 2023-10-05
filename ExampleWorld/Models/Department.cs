using System.ComponentModel.DataAnnotations;

namespace ExampleWorld.Models
{
    public class Department
    {
        [Key] //data annotation (species this is a primary key)
        public int ID { get; set; } = 0;

        [Required, StringLength(300)]
        public string Name { get; set; } = String.Empty;

        [StringLength(1000)]
        public string? Description { get; set; } = String.Empty;

        //Relationship with Products and place to store products in the Department instance
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}