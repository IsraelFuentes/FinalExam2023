namespace Mid_Term.Models
{
    public class AccountRepository
    {
        private readonly ApplicationDbContex _appDbContext;

        public AccountRepository(ApplicationDbContex appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Account> AllAccounts { get { return _appDbContext.Account; } }

        public Account GetAccountById(int id) 
        {
            return _appDbContext.Account.FirstOrDefault(a => a.Id == id);
        }
    }
}
