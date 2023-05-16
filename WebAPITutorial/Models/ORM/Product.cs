using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITutorial.Models.ORM
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
