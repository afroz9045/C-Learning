namespace WithdrawValidation
{
    public class Withdraw
    {
        public static void DoWithdraw()
        {
            try
            {
                int account_balance = 5000;
                int withdrawl_amount = 30000;

                if (account_balance < withdrawl_amount)
                {
                    throw new Exception("Insufficient Balance...");
                }
                else
                {
                    account_balance -= withdrawl_amount;
                    Console.WriteLine($"Remaining balance is: {account_balance}");
                    Console.WriteLine("Transaction completed successfully...");
                }

            }
            catch (Exception m)
            {

                Console.WriteLine(m.Message);
            }
        }
    }
}