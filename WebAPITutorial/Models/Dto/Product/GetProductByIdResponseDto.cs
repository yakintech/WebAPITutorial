namespace WebAPITutorial.Models.Dto.Product
{
    public class GetProductByIdResponseDto
    {
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public int Stock { get; set; }
    }
}
