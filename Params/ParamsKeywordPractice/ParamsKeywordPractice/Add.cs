namespace ParamsKeywordPractice
{
    public class Add
    {
        public static int Addition(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
