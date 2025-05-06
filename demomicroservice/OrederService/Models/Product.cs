using System.ComponentModel.DataAnnotations;



namespace OrederService.Models
{
   
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]

        public decimal? Price { get; set; }

    }
}
