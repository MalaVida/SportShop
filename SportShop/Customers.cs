using System.ComponentModel.DataAnnotations;

namespace SportShop

{
    public class Customers
    {
        public int Id { get; set; }
        [Required,StringLength(10)]
        public string Name { get; set; }

    }
}