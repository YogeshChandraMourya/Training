using System.Security.Cryptography;

namespace Relations.Models
{
    public class Parentclass
    {
        public int ParentProperty1 { get; set; }
        public int ParentProperty2 { get; set; }
        public int ParentProperty3 { get; set; }
        public int ParentProperty4 { get; set; }

        int p1;
        int p2;
        public int ParentMethod(int p1, int p2)
        {
            return (p1 + p2);
        }
    }
    public class ChildClass : Parentclass
    {
        public int ChildProperty1 { get; set; }
        public int ChildProperty2 { get; set; }

        public string GetValue()
        {
            return "90%";
        }
    }

    public class ExecuteClass : IParentClass
    {
        public void DraftMethod()
        {
            ChildClass child = new ChildClass();
        }



        public int ParentProperty1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParentProperty2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParentProperty3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParentProperty4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int ParentMethod()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class AbstractClass
    {
        public abstract void AbMethod();
        public void ProfitorLoss()
        {
            Console.WriteLine("Profit");

        }
    }
    public class ChildAb : AbstractClass
    {
        public override void AbMethod()
        {
            throw new NotImplementedException();
        }
    }


}
