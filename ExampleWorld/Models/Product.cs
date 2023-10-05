using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleWorld.Models
{

    public enum ProductWeightUnit
    {
        GRAMS,
        KILOGRAMS,
        POUNDS,
        OUNCES,
        LITRES,
        UNITS,
    }
    public class Product
    {
        [Key] //data annotation (species this is a primary key)
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; } = 0;

        [Required, StringLength(300)]
        public string Name { get; set; } = String.Empty;

        [StringLength(1000)]
        public string? Description { get; set; } = String.Empty;

        [StringLength(250)]
        public string? Image { get; set; } = String.Empty;

        [Required]
        [Range(0.01, 999999.99)]
        [DataType(DataType.Currency)]
        public decimal MSRP { get; set; } = 0.01M;

        [Required]
        [Range(0.01, 999999.99)]
        public decimal Weight { get; set; } = 0.01M;

        [Required]
        public ProductWeightUnit WeightUnit { get; set; } = ProductWeightUnit.UNITS; 

        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }//creates the association to departments
        //allow a department to be stored in an instance of a product
    }
}