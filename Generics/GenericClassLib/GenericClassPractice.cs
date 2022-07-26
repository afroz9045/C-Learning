namespace GenericClassLib
{
    public class GenericClassPractice<T>
    {
        T box;
        public GenericClassPractice(T b)
        {
            this.box = b;
        }
        public T getBox()
        {
            return box; 
        }
    }
}