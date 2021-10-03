using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            products.Sort(new HeapSortAlgorithm());
        }
    }

    public interface ISortAlgorithm
    {
        void Sort();
    }

    public class BubbleSortAlgorithm : ISortAlgorithm
    {
        public void Sort()
        {
            Console.WriteLine("Bubble sort...");
        }
    }

    public class HeapSortAlgorithm : ISortAlgorithm
    {
        public void Sort()
        {
            Console.WriteLine("Heap sort...");
        }
    }

    public class Products
    {
        public void Sort(ISortAlgorithm sortAlgorithm)
        {
            sortAlgorithm.Sort();
        }
    }
}
