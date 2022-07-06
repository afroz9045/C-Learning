namespace AutoImplementPropertyLib
{
    public class Account
    {
        public long AccountNumber { get; private set; }

        static long AccountSeed = 10000000000;
        public Account()
        {
            AccountNumber = AccountSeed++;
        }
    }
}