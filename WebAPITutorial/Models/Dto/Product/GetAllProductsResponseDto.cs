namespace WebAPITutorial.Models.Dto.Product
{
    public class GetAllProductsResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public string CategoryName { get; set; }
    }
}
