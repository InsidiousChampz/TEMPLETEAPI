namespace TEMPLETEAPI.DTOs.Product
{
    public class UpdateProductDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public int ProductGroupId { get; set; }
    }
}