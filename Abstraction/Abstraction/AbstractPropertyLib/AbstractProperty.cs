namespace AbstractPropertyLib
{
    public abstract class AbstractProperty
    {
        public abstract int Id { get; set; }
    }
    public class ChildImplementation: AbstractProperty
    {
         public override int Id { get; set; }
    }
}