namespace GenericBoxOfString
{
    public class Box<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {item}";
        }
    }
}
