using System.Collections;

namespace StackLib
{
    public class NonGenStack
    {
      public static void StackDataShow()
        {
            Stack myStack = new Stack();
            myStack.Push("Shafat khan");
            myStack.Push(23);
            myStack.Push(6.0);
            myStack.Push(5.11);
            myStack.Push(false);

            Console.WriteLine(myStack.Peek().ToString());
            foreach (object item in myStack)
            {
                Console.WriteLine(item);
            }
            myStack.Pop();
            Console.WriteLine(myStack.Peek().ToString());
            //myStack.Clear(); //It will clear the stack
            
        }
    }
}