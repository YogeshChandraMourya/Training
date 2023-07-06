namespace Relations.Models
{
    public class MultipleInheritence
    {
        public string A;
    }
    public interface Mul
    {

    }

    public class B{

    }
    public class C : MultipleInheritence, Mul
    {
       
    }
}
