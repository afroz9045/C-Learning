using System.Collections;
namespace QueueLib
{
    public class NonGenQueue
    {
        public static void ShowQueue()
        {
            Queue q = new Queue();
            q.Enqueue("mahmood");
            q.Enqueue(true);
            q.Enqueue(5.5);
            q.Enqueue(25);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            Console.WriteLine("--------------------------");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(q.Peek());

        }
    }
}