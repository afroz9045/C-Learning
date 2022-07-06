namespace PassByReferenceLib
{
    public class PassByReference
    {
        public int PassByRef(ref int num)
        {
            num = num + 30;
            return num;
        }
    }
}