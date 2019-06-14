namespace GenericCountMethodStrings
{
    using System.Collections.Generic;

    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public List<T> Data => this.elements;
    }
}
