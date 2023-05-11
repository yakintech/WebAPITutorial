using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITutorial.Models.ORM
{
    public class WebUser : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }

        public int? CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }

    }
}
