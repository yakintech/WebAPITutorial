using System.ComponentModel.DataAnnotations;

namespace WebAPITutorial.Models.Dto.Product
{ 
    public class CreateProductRequestDto
    {
        //[Required]
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
}
