public class AccountRepository : IAccountRepository
{

    private readonly CovidContext _context;
    public AccountRepository(CovidContext context)
    {
        _context = context;
    }

    public Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
        var accountFinded = (from x in _context.Account
                             where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                             select x).FirstOrDefault();
        return accountFinded;
    }

    Account IAccountRepository.FindAccountById(int id)
    {
        var accountByID = (from x in _context.Account
                           where x.Id == id
                           select x).FirstOrDefault();
        return accountByID;

    }

    async Task<List<Account>> IAccountRepository.GetAllAccounts()
    {
        return await _context.Account.ToListAsync();
    }

    async Task<Account> IAccountRepository.CreateAccount(Account account)
    {
        await _context.Set<Account>().AddAsync(account);
        await _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.GetAccountByEmail(string email)
    {
        return await _context.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
    }


    async Task<Account> IAccountRepository.UpdateAccountByEmail(Account account)
    {
        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.UpdateAccountPassword(Account account)
    {

        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.ChangeVisibilityOfAccount(Account account)
    {
        account.Visibility = !account.Visibility;
        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.ChangeRoleOfAccount(Account account)
    {
        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.GetAccountById(int id)
    {
        return await _context.Set<Account>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public Account FindAccountsByEmailAndPassword(LoginDTO loginDTO)
    {
        Account accountFinded = (from x in _context.Account
                                 where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                                 select x).FirstOrDefault();
        return accountFinded;
    }


}


