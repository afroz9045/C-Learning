namespace GenericsCollection
{
    public class Collection
    {
        public static void ShowArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static bool Check<T>(T a,T b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
}