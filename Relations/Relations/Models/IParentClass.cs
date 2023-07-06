namespace Relations.Models
{
    public interface IParentClass
    {
        public int ParentProperty1 { get; set; }
        public int ParentProperty2 { get; set; }
        public int ParentProperty3 { get; set; }
        public int ParentProperty4 { get; set; }

        public int ParentMethod();
        
    }
}