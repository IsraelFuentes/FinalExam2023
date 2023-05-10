namespace Mid_Term.Models
{
    public interface IProductsRepository
    {
        IEnumerable<Products> AllProducts { get; }

        Products GetProductsById(int id);
    }
}
