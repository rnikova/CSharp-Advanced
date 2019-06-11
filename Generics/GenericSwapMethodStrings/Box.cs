namespace GenericSwapMethodStrings
{
    using System.Collections.Generic;
    using System.Text;

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

        public List<T> SwapElements(int firstIndex, int secondIndex)
        {
            var element = elements[firstIndex];

            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = element;

            return elements;
        }

        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();

            foreach (var element in elements)
            {
                stringbuilder.AppendLine($"{typeof(T)}: {element}");
            }
            return stringbuilder.ToString();
        }
    }
}
