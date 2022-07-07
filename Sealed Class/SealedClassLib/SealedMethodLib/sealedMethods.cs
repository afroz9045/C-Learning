namespace SealedMethodLib
{
    public class a
    {
        public virtual void ShowData()
        {
            Console.WriteLine("Message from A");
        }
    }
    class  b:a
    {
        public sealed override void ShowData()
        {
            Console.WriteLine("Message from B");
        }
    }
    class c : b
    {
        //public override void ShowData()
        //{
        //    Console.WriteLine("Message from B");
        //} This method can't be override further

    }
}