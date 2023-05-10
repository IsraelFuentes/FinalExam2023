namespace Mid_Term.Models
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ApplicationDbContex _appDbContext;

        public ProductsRepository(ApplicationDbContex appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Products> AllProducts 
        {
            get { return _appDbContext.Produtcs; }
        }
       public Products GetProductsById(int id)
        {
            return _appDbContext.Produtcs.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
