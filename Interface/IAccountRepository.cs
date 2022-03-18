public interface IAccountRepository
{
    Account FindAccountByEmailAndPassword(LoginDTO loginDTO);
    Account FindAccountById(int id);
    
}

