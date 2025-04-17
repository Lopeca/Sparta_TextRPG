namespace SpartaCanvas
{
    public abstract class Menu
    {
        public virtual string Name { get; set; }
        public abstract void Execute();
    }

}