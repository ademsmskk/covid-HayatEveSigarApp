public class AccountRepository :IAccountRepository
{     
    
    
      

    private readonly CovidContext _context;
    public AccountRepository(CovidContext context)
    {
        _context=context;
    }
   
   
 
     public  Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
         Account accountFinded = (from x in _context.Account
                           where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                           select x).FirstOrDefault();
        return accountFinded;
    }

 
    Account IAccountRepository.FindAccountById(int id)
    {
     
         Account accountByID = (from x in _context.Account
                           where x.Id == id
                           select x).FirstOrDefault();
        return accountByID;
    }
}

   
