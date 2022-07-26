namespace InterfaceInheritanceLib
{
    public interface I1
    {
        public void Print();
    }
    public interface I2
    {
        public void Print1();
    }
    public interface I3:I1,I2
    {
        public void Print2();
    }
}