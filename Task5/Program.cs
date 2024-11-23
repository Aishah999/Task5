namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
    public class User: IAccount
    {
        public int Id
        {
            get;private set;
        }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        private static int _idCounter = 1;
    }
    public User (string fullname,string email,string password)
    {
        
        fullname = fullname;
        email = email;

        if(PasswordChecker(password))
        {
            _password = password;
        }
        else
        {
            ArgumentException("Sifre teleblere cavab vermir");
        }
                
    }
}

