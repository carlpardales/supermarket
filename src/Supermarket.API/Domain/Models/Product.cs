namespace Supermarket.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMasurement { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}