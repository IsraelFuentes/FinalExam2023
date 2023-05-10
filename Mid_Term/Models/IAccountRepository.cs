namespace Mid_Term.Models
{
    public interface IAccountRepository
    {
        IEnumerable<Account> AllAccounts { get; }

        Account GetAccountById(int id);
    }
}
